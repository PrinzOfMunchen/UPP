﻿Ext.define('Документы.ПриходныйКассовыйОрдер.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 420,width: 780,
	iconCls: 'bogus',
	title: 'Приходные кассовые ордера',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:32px;width:764px;height:380px;',
			height: 380,width: 764,
			columns:
			[
				{
					text:'Картинка',
				},
				{
					text:'ОтражатьВУправленческомУчете',
				},
				{
					text:'ОтражатьВБухгалтерскомУчете',
				},
				{
					text:'ОтражатьВНалоговомУчете',
				},
				{
					text:'Оплачено',
				},
				{
					text:'Дата',
				},
				{
					text:'Номер',
				},
				{
					text:'ВидОперации',
				},
				{
					text:'СуммаДокумента',
				},
				{
					text:'ВалютаДокумента',
				},
				{
					text:'Касса',
				},
				{
					text:'Контрагент',
				},
				{
					text:'Организация',
				},
				{
					text:'Подразделение',
				},
				{
					text:'Ответственный',
				},
				{
					text:'Основание',
				},
				{
					text:'Приложение',
				},
				{
					text:'Комментарий',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:780px;height:25px;',
			items:
			[
				{
					text:'ДействиеПечать',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'ПроводкиДтКтНУ',
				},
				{
					text:'ПечатьКассовогоЧека',
				},
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
				{
					text:'Разделитель15',
				},
				{
					text:'Подменю3',
				},
				{
					text:'ПроводкиДтКт',
				},
				{
					text:'Разделитель',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Разделитель8',
				},
			]
		},
	]
});