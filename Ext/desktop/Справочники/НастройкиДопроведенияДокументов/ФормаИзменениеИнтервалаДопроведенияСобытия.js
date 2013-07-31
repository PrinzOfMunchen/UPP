﻿Ext.define('Справочники.НастройкиДопроведенияДокументов.ФормаИзменениеИнтервалаДопроведенияСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Наименование','ФормироватьДокументыАвтоматически','РегламентноеЗадание','Комментарий','ДопроводитьВсеДокументы','НомерДняКонецЗапуска','НомерДняНачалоЗапуска','НачалоИнтервалаДопроведения','КонецИнтервалаДопроведения','КоличествоПериодовОтставанияКонецИнтервала','КоличествоПериодовОтставанияНачалоИнтервала','ПериодичностьОтставанияКонецИнтервала','ПериодичностьОтставанияКонецИнтервала.Ссылка','ПериодичностьОтставанияКонецИнтервала.Представление','ПериодичностьОтставанияНачалоИнтервала','ПериодичностьОтставанияНачалоИнтервала.Ссылка','ПериодичностьОтставанияНачалоИнтервала.Представление','РассчитыватьКонецИнтервала','РассчитыватьНачалоИнтервала',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/НастройкиДопроведенияДокументов/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.НастройкиДопроведенияДокументов.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.НастройкиДопроведенияДокументов.ФормаЭлемента',
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