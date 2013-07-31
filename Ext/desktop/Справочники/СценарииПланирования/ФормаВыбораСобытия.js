﻿Ext.define('Справочники.СценарииПланирования.ФормаВыбораСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код','Наименование','Родитель','Родитель.Ссылка','Родитель.Представление','Периодичность','Периодичность.Ссылка','Периодичность.Представление','ДетализацияПланирования','ДетализацияПланирования.Ссылка','ДетализацияПланирования.Представление','УчетПоСуммам','УчетПоКоличеству','Валюта','Валюта.Ссылка','Валюта.Представление','СпособПланирования','СпособПланирования.Ссылка','СпособПланирования.Представление','ПродолжительностьЦикла','НачалоПлана','КонецПлана','НормаДоходности','ИспользоватьКурсыСценария',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/СценарииПланирования/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.СценарииПланирования.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.СценарииПланирования.ФормаЭлемента',
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