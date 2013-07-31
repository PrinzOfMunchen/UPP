﻿Ext.define('Справочники.ДоговорыКонтрагентов.ФормаСпискаУправляемаяСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код','Наименование','Родитель','Родитель.Ссылка','Родитель.Представление','ВалютаВзаиморасчетов','ВалютаВзаиморасчетов.Ссылка','ВалютаВзаиморасчетов.Представление','ВедениеВзаиморасчетов','ВедениеВзаиморасчетов.Ссылка','ВедениеВзаиморасчетов.Представление','Комментарий','ВидУсловийДоговора','ВидУсловийДоговора.Ссылка','ВидУсловийДоговора.Представление','ДержатьРезервБезОплатыОграниченноеВремя','ДопустимаяСуммаЗадолженности','ДопустимоеЧислоДнейЗадолженности','Организация','Организация.Ссылка','Организация.Представление','КонтролироватьСуммуЗадолженности','КонтролироватьЧислоДнейЗадолженности','ОбособленныйУчетТоваровПоЗаказамПокупателей','ПроцентКомиссионногоВознаграждения','СпособРасчетаКомиссионногоВознаграждения','СпособРасчетаКомиссионногоВознаграждения.Ссылка','СпособРасчетаКомиссионногоВознаграждения.Представление','ПроцентПредоплаты','ТипЦен','ВидДоговора','ВидДоговора.Ссылка','ВидДоговора.Представление','ЧислоДнейРезерваБезОплаты','УчетАгентскогоНДС','ВидАгентскогоДоговора','ВидАгентскогоДоговора.Ссылка','ВидАгентскогоДоговора.Представление','РасчетыВУсловныхЕдиницах','КонтролироватьДенежныеСредстваКомитента','РеализацияНаЭкспорт','Дата','Номер','ВидВзаиморасчетов','ВидВзаиморасчетов.Ссылка','ВидВзаиморасчетов.Представление','ВестиПоДокументамРасчетовСКонтрагентом','ОсновнойПроект','ОсновнаяСтатьяДвиженияДенежныхСредств','ОсновнаяСтатьяДвиженияДенежныхСредств.Ссылка','ОсновнаяСтатьяДвиженияДенежныхСредств.Представление','СрокДействия','НаименованиеДляСчетаФактурыНаАванс','НаименованиеДляСчетаФактурыНаАванс.Ссылка','НаименованиеДляСчетаФактурыНаАванс.Представление','ПорядокРегистрацииСчетовФактурНаАвансПоДоговору','ПорядокРегистрацииСчетовФактурНаАвансПоДоговору.Ссылка','ПорядокРегистрацииСчетовФактурНаАвансПоДоговору.Представление','НалоговыйАгентПоОплате','УстановленСрокОплатыДляРезервовПоСомнительнымДолгам','СрокОплатыДляРезервовПоСомнительнымДолгам',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/ДоговорыКонтрагентов/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.ДоговорыКонтрагентов.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.ДоговорыКонтрагентов.ФормаЭлемента',
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