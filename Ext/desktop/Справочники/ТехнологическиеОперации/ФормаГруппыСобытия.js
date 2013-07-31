﻿Ext.define('Справочники.ТехнологическиеОперации.ФормаГруппыСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код','Наименование','Родитель','Родитель.Ссылка','Родитель.Представление','ОсновнаяСтатьяЗатратНаПроизводство','ОсновнаяСтатьяЗатратНаПроизводство.Ссылка','ОсновнаяСтатьяЗатратНаПроизводство.Представление','СпособОтраженияЗарплатыВБухучете','СпособОтраженияЗарплатыВБухучете.Ссылка','СпособОтраженияЗарплатыВБухучете.Представление','ОсновнойСпособРаспределенияЗатратНаВыпуск','ОсновнойСпособРаспределенияЗатратНаВыпуск.Ссылка','ОсновнойСпособРаспределенияЗатратНаВыпуск.Представление','ОсновнаяНоменклатурнаяГруппа','ОсновнаяНоменклатурнаяГруппа.Ссылка','ОсновнаяНоменклатурнаяГруппа.Представление','Расценка','БазоваяЕдиницаИзмерения','БазоваяЕдиницаИзмерения.Ссылка','БазоваяЕдиницаИзмерения.Представление','Валюта','Валюта.Ссылка','Валюта.Представление','НормаВремени','Коэффициент',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/ТехнологическиеОперации/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.ТехнологическиеОперации.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.ТехнологическиеОперации.ФормаЭлемента',
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