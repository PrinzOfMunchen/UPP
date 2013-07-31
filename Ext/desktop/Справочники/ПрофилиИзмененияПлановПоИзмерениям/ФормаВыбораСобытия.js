﻿Ext.define('Справочники.ПрофилиИзмененияПлановПоИзмерениям.ФормаВыбораСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код','Наименование','Родитель','Родитель.Ссылка','Родитель.Представление','ВидРаспределения','ВидРаспределения.Ссылка','ВидРаспределения.Представление','ИзмерениеБюджетирования','ИзмерениеБюджетирования.Ссылка','ИзмерениеБюджетирования.Представление','ИсточникДанных','ИсточникДанных.Ссылка','ИсточникДанных.Представление','ПоказательИсточника','ПоВсемЭлементам',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/ПрофилиИзмененияПлановПоИзмерениям/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.ПрофилиИзмененияПлановПоИзмерениям.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.ПрофилиИзмененияПлановПоИзмерениям.ФормаЭлемента',
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