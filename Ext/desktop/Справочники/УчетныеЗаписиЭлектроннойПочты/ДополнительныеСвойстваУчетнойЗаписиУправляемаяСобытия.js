﻿Ext.define('Справочники.УчетныеЗаписиЭлектроннойПочты.ДополнительныеСвойстваУчетнойЗаписиУправляемаяСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код','Наименование','SMTPСервер','POP3Сервер','ПортSMTP','ПортPOP3','Логин','Пароль','ТребуетсяSMTPАутентификация','ЛогинSMTP','ПарольSMTP','ВремяОжиданияСервера','ОставлятьКопииСообщенийНаСервере','УдалятьПисьмаССервераЧерез','КоличествоДнейУдаленияПисемССервера','АдресЭлектроннойПочты','ГруппаВходящие','ГруппаВходящие.Ссылка','ГруппаВходящие.Представление','ГруппаИсходящие','ГруппаИсходящие.Ссылка','ГруппаИсходящие.Представление','ГруппаУдаленные','ГруппаУдаленные.Ссылка','ГруппаУдаленные.Представление','ГруппаЧерновики','ГруппаЧерновики.Ссылка','ГруппаЧерновики.Представление','ГруппаНежелательные','ГруппаНежелательные.Ссылка','ГруппаНежелательные.Представление','ФорматТекстаПисьмаПоУмолчанию','ФорматТекстаПисьмаПоУмолчанию.Ссылка','ФорматТекстаПисьмаПоУмолчанию.Представление','ТекстПодписи','ДобавлятьПодписьКИсходящимПисьмам','ДобавлятьПодписьКОтветамИПересылкам','АвтоПолучениеОтправкаСообщений','ИнтервалАвтоПолученияОтправкиСообщений','ОтветственныйЗаАвтоПолучениеОтправкуСообщений','ОтветственныйЗаАвтоПолучениеОтправкуСообщений.Ссылка','ОтветственныйЗаАвтоПолучениеОтправкуСообщений.Представление','ПомещатьОтветыИПереадресацииВТужеГруппу','ДействиеАвтополученияОтправкиСообщений','ДействиеАвтополученияОтправкиСообщений.Ссылка','ДействиеАвтополученияОтправкиСообщений.Представление','АвтоматическаяУстановкаПометкиРассмотрено','ИнтервалАвтоматическойУстановкиОтметкиРассмотрено','АвтоматическаяУстановкаПометкиРассмотреноПриОтвете','АвтоматическаяУстановкаПометкиРассмотреноПриПолученииОтвета','ИспользоватьКлассификациюПисемПоПредметам','ЗаполнятьПустойПредметДляНовыхПисемИзТемыПисьма','ДляВходящихОтветовИПереадресацийИскатьПисьмаОснованияИЗаполнятьПредмет','ДляВходящихОтветовИПереадресацийИскатьПисьмаОснованияИЗаполнятьОснованиеНовогоПисьма','ДляВходящихОтветовИПереадресацийИскатьПисьмаОснованияИЗаполнятьГруппуПисемНовогоПисьма','АвтосохранениеПисем','ИнтервалАвтосохраненияПисем','ФорматПисьмаДляОтветовИПереадресацийБратьИзИсходного','КодировкаПисемПоУмолчанию','КодировкуПисьмаДляОтветовБратьИзИсходного','ЗаполнятьОбъектыИзАдресовПервогоПисьма','НазначениеУчетнойЗаписи','НазначениеУчетнойЗаписи.Ссылка','НазначениеУчетнойЗаписи.Представление','ИспользоватьДляОтправки','ИспользоватьДляПолучения',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/УчетныеЗаписиЭлектроннойПочты/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.УчетныеЗаписиЭлектроннойПочты.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.УчетныеЗаписиЭлектроннойПочты.ФормаЭлемента',
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