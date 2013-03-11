﻿Ext.define('Справочники.УчетныеЗаписиЭлектроннойПочты.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	height: 361,width: 566,
	iconCls: 'bogus',
	title: 'Справочник Учетные записи электронной почты',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:550px;height:320px;',
			height: 320,width: 550,
			columns:
			[
				{
					text:'Картинка',
				},
				{
					text:'Код',
				},
				{
					text:'Наименование',
				},
				{
					text:'SMTPСервер',
				},
				{
					text:'POP3Сервер',
				},
				{
					text:'ПортSMTP',
				},
				{
					text:'ПортPOP3',
				},
				{
					text:'Логин',
				},
				{
					text:'Пароль',
				},
				{
					text:'ТребуетсяSMTPАутентификация',
				},
				{
					text:'ЛогинSMTP',
				},
				{
					text:'ПарольSMTP',
				},
				{
					text:'ВремяОжиданияСервера',
				},
				{
					text:'ОставлятьКопииСообщенийНаСервере',
				},
				{
					text:'УдалятьПисьмаССервераЧерез',
				},
				{
					text:'КоличествоДнейУдаленияПисемССервера',
				},
				{
					text:'АдресЭлектроннойПочты',
				},
				{
					text:'ГруппаВходящие',
				},
				{
					text:'ГруппаИсходящие',
				},
				{
					text:'ГруппаУдаленные',
				},
				{
					text:'ГруппаЧерновики',
				},
				{
					text:'ФорматТекстаПисьмаПоУмолчанию',
				},
				{
					text:'ТекстПодписи',
				},
				{
					text:'ДобавлятьПодписьКИсходящимПисьмам',
				},
				{
					text:'ДобавлятьПодписьКОтветамИПересылкам',
				},
				{
					text:'АвтоПолучениеОтправкаСообщений',
				},
				{
					text:'ИнтервалАвтоПолученияОтправкиСообщений',
				},
				{
					text:'ОтветственныйЗаАвтоПолучениеОтправкуСообщений',
				},
				{
					text:'ПомещатьОтветыИПереадресацииВТужеГруппу',
				},
				{
					text:'ДействиеАвтополученияОтправкиСообщений',
				},
				{
					text:'АвтоматическаяУстановкаПометкиРассмотрено',
				},
				{
					text:'ИнтервалАвтоматическойУстановкиОтметкиРассмотрено',
				},
				{
					text:'ИспользоватьКлассификациюПисемПоПредметам',
				},
				{
					text:'ЗаполнятьПустойПредметДляНовыхПисемИзТемыПисьма',
				},
				{
					text:'ДляВходящихОтветовИПереадресацийИскатьПисьмаОснованияИЗаполнятьПредмет',
				},
				{
					text:'ДляВходящихОтветовИПереадресацийИскатьПисьмаОснованияИЗаполнятьОснованиеНовогоПисьма',
				},
				{
					text:'АвтосохранениеПисем',
				},
				{
					text:'ИнтервалАвтосохраненияПисем',
				},
				{
					text:'ФорматПисьмаДляОтветовИПереадресацийБратьИзИсходного',
				},
				{
					text:'АвтоматическаяУстановкаПометкиРассмотреноПриОтвете',
				},
				{
					text:'АвтоматическаяУстановкаПометкиРассмотреноПриПолученииОтвета',
				},
				{
					text:'ДляВходящихОтветовИПереадресацийИскатьПисьмаОснованияИЗаполнятьГруппуПисемНовогоПисьма',
				},
				{
					text:'КодировкаПисемПоУмолчанию',
				},
				{
					text:'КодировкуПисьмаДляОтветовБратьИзИсходного',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:566px;height:25px;',
			items:
			[
				{
					text:'Разделитель',
				},
				{
					text:'Действие',
				},
			]
		},
	]
});