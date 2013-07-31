﻿Ext.define('Справочники.НастройкиРасчетаЦеныНоменклатуры.ФормаЭлементаУправляемаяСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Наименование','Родитель','Родитель.Ссылка','Родитель.Представление','ФормироватьДокументыАвтоматически','РегламентноеЗадание','НастройкиКомпоновщика','ТипЦен','ТипЦен.Ссылка','ТипЦен.Представление','ВидОтраженияВУчете','ВидОтраженияВУчете.Ссылка','ВидОтраженияВУчете.Представление','ПорядокФормированияЦены','Комментарий','НастройкаРасчетаСебестоимости','НастройкаРасчетаСебестоимости.Ссылка','НастройкаРасчетаСебестоимости.Представление','СоздаватьНовыйДокумент',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/НастройкиРасчетаЦеныНоменклатуры/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.НастройкиРасчетаЦеныНоменклатуры.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.НастройкиРасчетаЦеныНоменклатуры.ФормаЭлемента',
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