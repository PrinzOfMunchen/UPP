﻿Ext.define('Справочники.Вакансии.ФормаЭлементаСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код','Наименование','Закрыта','Должность','Должность.Ссылка','Должность.Представление','Заявитель','Заявитель.Ссылка','Заявитель.Представление','Обязанности','Организация','Организация.Ссылка','Организация.Представление','Ответственный','Ответственный.Ссылка','Ответственный.Представление','ПлановаяДатаЗакрытия','Подразделение','Требования','Условия','ДатаОткрытия','ДатаЗакрытия',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/Вакансии/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.Вакансии.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.Вакансии.ФормаЭлемента',
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