﻿Ext.define('Справочники.СертификатыЭЦП.ФормаЭлементаСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Наименование','ДолжностьПоСертификату','ЗапомнитьПарольКСертификату','Назначение','ОграничитьДоступКСертификату','Организация','Организация.Ссылка','Организация.Представление','Отозван','Отпечаток','ПарольПользователя','Пользователь','Пользователь.Ссылка','Пользователь.Представление','ПроверятьСоставИсполнителей','ФайлСертификата',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/СертификатыЭЦП/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.СертификатыЭЦП.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.СертификатыЭЦП.ФормаЭлемента',
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