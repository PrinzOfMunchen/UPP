﻿Ext.define('Справочники.Контрагенты.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 321,width: 694,
	iconCls: 'bogus',
	title: 'Контрагенты',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:174px;top:57px;width:512px;height:256px;',
			height: 256,width: 512,
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
					text:'ИНН',
				},
				{
					text:'НаименованиеПолное',
				},
				{
					text:'Комментарий',
				},
				{
					text:'ОсновнойМенеджерПокупателя',
				},
				{
					text:'ГоловнойКонтрагент',
				},
				{
					text:'ДокументУдостоверяющийЛичность',
				},
				{
					text:'ДополнительноеОписание',
				},
				{
					text:'ИсточникИнформацииПриОбращении',
				},
				{
					text:'КодПоОКПО',
				},
				{
					text:'КПП',
				},
				{
					text:'НеЯвляетсяРезидентом',
				},
				{
					text:'ОКОПФ',
				},
				{
					text:'ОсновноеКонтактноеЛицо',
				},
				{
					text:'ОсновнойБанковскийСчет',
				},
				{
					text:'ОсновнойВидДеятельности',
				},
				{
					text:'ОсновнойДоговорКонтрагента',
				},
				{
					text:'Покупатель',
				},
				{
					text:'Поставщик',
				},
				{
					text:'РасписаниеРаботыСтрокой',
				},
				{
					text:'Регион',
				},
				{
					text:'СрокВыполненияЗаказаПоставщиком',
				},
				{
					text:'ЮрФизЛицо',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:57px;width:160px;height:256px;',
			height: 256,width: 160,
			columns:
			[
				{
					text:'Наименование',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:694px;height:25px;',
			items:
			[
				{
					text:'Разделитель7',
				},
				{
					text:'Прочее',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'ЭлектронноеПисьмо',
				},
				{
					text:'ЗаказыПоставщикам',
				},
				{
					text:'Отчет',
				},
				{
					text:'НовыйЗаказПокупателя',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Продажи',
				},
				{
					text:'ЭлектронноеПисьмо',
				},
				{
					text:'ТелефонныйЗвонок',
				},
				{
					text:'ЛичнаяВстреча',
				},
				{
					text:'ЭлектронныеПисьма',
				},
				{
					text:'НовыйЗаказПокупателя',
				},
				{
					text:'ДействиеСвойства',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель10',
				},
				{
					text:'Создать',
				},
				{
					text:'ЭлектронныеПисьмаПлюсКонтактныеЛица',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Файлы',
				},
				{
					text:'НовыйЗаказПоставщику',
				},
				{
					text:'ПомощникВвода',
				},
				{
					text:'ЛичнаяВстреча',
				},
				{
					text:'ПочтовоеПисьмо',
				},
				{
					text:'Создать',
				},
				{
					text:'ДействиеКатегории',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Прочее',
				},
				{
					text:'Разделитель9',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'НаписатьПисьмо',
				},
				{
					text:'ЗаказыПокупателей',
				},
				{
					text:'ПочтовоеПисьмо',
				},
				{
					text:'Файлы',
				},
				{
					text:'Отчеты',
				},
				{
					text:'НовыйЗаказПоставщику',
				},
				{
					text:'Разделитель8',
				},
				{
					text:'СписокСобытий',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'ТелефонныйЗвонок',
				},
				{
					text:'ВедомостьВзаиморасчетов',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'РазделительПрава',
				},
				{
					text:'Отчет',
				},
				{
					text:'Подменю',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ЗначениеОтбораСпискаКонтрагентов',
			style: 'position:absolute;left:235px;top:33px;width:451px;height:19px;',
		},
	]
});