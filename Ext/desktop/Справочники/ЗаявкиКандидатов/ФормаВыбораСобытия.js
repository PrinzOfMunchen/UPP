﻿Ext.define('Справочники.ЗаявкиКандидатов.ФормаВыбораСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код','Наименование','ФизЛицо','ФизЛицо.Ссылка','ФизЛицо.Представление','Состояние','Состояние.Ссылка','Состояние.Представление','Важность','Важность.Ссылка','Важность.Представление','Комментарий','Закрыта','РезультатЗакрытия','ГруппаЗаявок','ГруппаЗаявок.Ссылка','ГруппаЗаявок.Представление','ДатаОткрытия','ИсточникИнформации','ИсточникИнформации.Ссылка','ИсточникИнформации.Представление','Вакансия','Вакансия.Ссылка','Вакансия.Представление','Подразделение','Должность','Должность.Ссылка','Должность.Представление','Организация','Организация.Ссылка','Организация.Представление','Ответственный','Ответственный.Ссылка','Ответственный.Представление',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/ЗаявкиКандидатов/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.ЗаявкиКандидатов.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.ЗаявкиКандидатов.ФормаЭлемента',
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