﻿Ext.define('Справочники.Контрагенты.ФормаВыбораГруппыУправляемаяСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код','Наименование','Родитель','Родитель.Ссылка','Родитель.Представление','НаименованиеПолное','Комментарий','ДополнительноеОписание','ГоловнойКонтрагент','ГоловнойКонтрагент.Ссылка','ГоловнойКонтрагент.Представление','ИсточникИнформацииПриОбращении','ИсточникИнформацииПриОбращении.Ссылка','ИсточникИнформацииПриОбращении.Представление','КодПоОКПО','ИНН','КПП','ЮрФизЛицо','ЮрФизЛицо.Ссылка','ЮрФизЛицо.Представление','ОсновнойБанковскийСчет','ОсновнойБанковскийСчет.Ссылка','ОсновнойБанковскийСчет.Представление','ОсновнойДоговорКонтрагента','ОсновнойДоговорКонтрагента.Ссылка','ОсновнойДоговорКонтрагента.Представление','ОсновнойВидДеятельности','ОсновнойВидДеятельности.Ссылка','ОсновнойВидДеятельности.Представление','ДокументУдостоверяющийЛичность','ОсновнойМенеджерПокупателя','ОсновнойМенеджерПокупателя.Ссылка','ОсновнойМенеджерПокупателя.Представление','Покупатель','Поставщик','РасписаниеРаботыСтрокой','СрокВыполненияЗаказаПоставщиком','ОсновноеКонтактноеЛицо','ОсновноеКонтактноеЛицо.Ссылка','ОсновноеКонтактноеЛицо.Представление','НеЯвляетсяРезидентом','ОКОПФ','ОКОПФ.Ссылка','ОКОПФ.Представление','Регион','Регион.Ссылка','Регион.Представление','ГруппаДоступаКонтрагента','ГруппаДоступаКонтрагента.Ссылка','ГруппаДоступаКонтрагента.Представление',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/Контрагенты/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.Контрагенты.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.Контрагенты.ФормаЭлемента',
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