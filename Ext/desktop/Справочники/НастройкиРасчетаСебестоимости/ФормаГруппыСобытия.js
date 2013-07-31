﻿Ext.define('Справочники.НастройкиРасчетаСебестоимости.ФормаГруппыСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Наименование','Родитель','Родитель.Ссылка','Родитель.Представление','Организация','Организация.Ссылка','Организация.Представление','НастройкаЗакрытияМесяца','НастройкаЗакрытияМесяца.Ссылка','НастройкаЗакрытияМесяца.Представление','ВидОтраженияВУчете','ВидОтраженияВУчете.Ссылка','ВидОтраженияВУчете.Представление','ФормироватьДокументыАвтоматически','РегламентноеЗадание','Задержка','Комментарий',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/НастройкиРасчетаСебестоимости/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.НастройкиРасчетаСебестоимости.ФормаЭлемента'], function ()
				{
					var количество = хранилище.getCount();
					if (количество == 0)
					{
						var массивЗначений = строкаЗначений;
					}
					else
					{
						var массивЗначений = хранилище.data.items[0].data;
					};
					var окно = Ext.create('Справочники.НастройкиРасчетаСебестоимости.ФормаЭлемента',
					{
						Хранилище: массивЗначений.Родитель,
					});
					var форма = окно.down('form');
					форма.getForm().setValues(массивЗначений);
					if (окно)
					{
						окно.show();
						return окно;
					}
				});
			},
			scope: this
		});
	}
});