﻿Ext.define('Справочники.Организации.ФормаВыбораСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код','Наименование','Префикс','ИНН','КПП','РегистрационныйНомерПФР','ГоловнаяОрганизация','ГоловнаяОрганизация.Ссылка','ГоловнаяОрганизация.Представление','НаименованиеПолное','КодПоОКПО','КодПоОКАТО','КодИМНС','РайонныйКоэффициент','ЮрФизЛицо','ЮрФизЛицо.Ссылка','ЮрФизЛицо.Представление','ТерриториальныеУсловияПФР','ТерриториальныеУсловияПФР.Ссылка','ТерриториальныеУсловияПФР.Представление','ОсновнойБанковскийСчет','ОсновнойБанковскийСчет.Ссылка','ОсновнойБанковскийСчет.Представление','ВидСтавокЕСНиПФР','ВидСтавокЕСНиПФР.Ссылка','ВидСтавокЕСНиПФР.Представление','НаименованиеПлательщикаПриПеречисленииНалогов','ИностраннаяОрганизация','ДатаРегистрации','КодОКОПФ','НаименованиеОКОПФ','КодОКФС','НаименованиеОКФС','СвидетельствоСерияНомер','СвидетельствоДатаВыдачи','СвидетельствоНаименованиеОргана','СвидетельствоКодОргана','СтранаРегистрации','СтранаРегистрации.Ссылка','СтранаРегистрации.Представление','СтранаПостоянногоМестонахождения','СтранаПостоянногоМестонахождения.Ссылка','СтранаПостоянногоМестонахождения.Представление','КодВСтранеРегистрации','ОГРН','НаименованиеИнострОрганизации','РегистрационныйНомерФСС','НаименованиеИМНС','КодОКВЭД','НаименованиеОКВЭД','КодОКОНХ','ИндивидуальныйПредприниматель','ИндивидуальныйПредприниматель.Ссылка','ИндивидуальныйПредприниматель.Представление','УдалитьОбменЗадействован','ОбменКодАбонента','ОбменКаталогОтправкиДанныхОтчетности','ОбменКаталогПрограммыЭлектроннойПочты','РайонныйКоэффициентРФ','ОтражатьВРегламентированномУчете','КодИФНСПолучателя','НаименованиеТерриториальногоОрганаПФР','НаименованиеСокращенное','ВидОбменаСКонтролирующимиОрганами','ВидОбменаСКонтролирующимиОрганами.Ссылка','ВидОбменаСКонтролирующимиОрганами.Представление','УчетнаяЗаписьОбмена','УчетнаяЗаписьОбмена.Ссылка','УчетнаяЗаписьОбмена.Представление','КодОрганаПФР','КодОрганаФСГС','ДополнительныйКодФСС','КодПодчиненностиФСС','ЦифровойИндексОбособленногоПодразделения','РегистрационныйНомерТФОМС','ИПРегистрационныйНомерПФР','ИПРегистрационныйНомерФСС','ИПКодПодчиненностиФСС','ИПРегистрационныйНомерТФОМС','НаименованиеТерриториальногоОрганаФСС',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/Организации/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.Организации.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.Организации.ФормаЭлемента',
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