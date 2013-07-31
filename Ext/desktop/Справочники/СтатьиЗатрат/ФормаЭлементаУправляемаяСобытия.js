﻿Ext.define('Справочники.СтатьиЗатрат.ФормаЭлементаУправляемаяСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код','Наименование','Родитель','Родитель.Ссылка','Родитель.Представление','ВидЗатрат','ВидЗатрат.Ссылка','ВидЗатрат.Представление','СтатусМатериальныхЗатрат','СтатусМатериальныхЗатрат.Ссылка','СтатусМатериальныхЗатрат.Представление','ХарактерЗатрат','ХарактерЗатрат.Ссылка','ХарактерЗатрат.Представление','ВидРасходовНУ','ВидРасходовНУ.Ссылка','ВидРасходовНУ.Представление',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/СтатьиЗатрат/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.СтатьиЗатрат.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.СтатьиЗатрат.ФормаЭлемента',
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