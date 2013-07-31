﻿Ext.define('Справочники.СтатьиОборотовПоБюджетам.ФормаВыбораСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код','Наименование','Родитель','Родитель.Ссылка','Родитель.Представление','НаименованиеПолное','УчетПоКоличеству','УчетПоСумме','ИсточникДанныхДляЦены','ИсточникДанныхДляЦены.Ссылка','ИсточникДанныхДляЦены.Представление','ПоказательИсточникаДанныхДляЦены','ИсточникДанныхДляФакта','ИсточникДанныхДляФакта.Ссылка','ИсточникДанныхДляФакта.Представление','ПоказательИсточникаДанныхДляФактаСум','СпособОпределенияВалютыОборотаФакт','СпособОпределенияВалютыОборотаФакт.Ссылка','СпособОпределенияВалютыОборотаФакт.Представление','ПоказательИсточникаДанныхДляФактаКол','ЕдиницаИзмерения','ЕдиницаИзмерения.Ссылка','ЕдиницаИзмерения.Представление','РазделениеПоКонтрагентам','РазделениеПоНоменклатуре','ОсновнаяВалюта','ОсновнаяВалюта.Ссылка','ОсновнаяВалюта.Представление','ОсновноеЦФО','ОсновноеЦФО.Ссылка','ОсновноеЦФО.Представление','ОсновнойПроект','ОсновнойПроект.Ссылка','ОсновнойПроект.Представление','ОсновнойКонтрагент','ОсновнойКонтрагент.Ссылка','ОсновнойКонтрагент.Представление','ОсновнаяНоменклатура','Комментарий','КоэффициентДляФактаСум','КоэффициентДляФактаКол',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/СтатьиОборотовПоБюджетам/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.СтатьиОборотовПоБюджетам.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.СтатьиОборотовПоБюджетам.ФормаЭлемента',
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