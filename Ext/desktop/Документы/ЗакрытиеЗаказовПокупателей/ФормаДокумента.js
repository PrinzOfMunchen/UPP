﻿Ext.define('Документы.ЗакрытиеЗаказовПокупателей.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	height: 401,width: 650,
	iconCls: 'bogus',
	title: 'Закрытие заказов покупателей',
	
	items:
	[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номер',
			style: 'position:absolute;left:84px;top:33px;width:90px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата',
			style: 'position:absolute;left:194px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:94px;top:349px;width:548px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:650px;height:25px;',
			items:
			[
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
				{
					text:'Подменю2',
				},
				{
					text:'ДействиеОткрытьКатегории',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'ПодменюВидаОперации',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Разделитель9',
				},
				{
					text:'ДействиеОткрытьСвойства',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответственный',
			style: 'position:absolute;left:422px;top:325px;width:220px;height:19px;',
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:125px;width:634px;height:195px;',
			height: 195,width: 634,
			columns:
			[
				{
					text:'НомерСтроки',
				},
				{
					text:'ОбособленныйУчет',
				},
				{
					text:'ЗаказПокупателя',
				},
				{
					text:'КонтрагентЗаказа',
				},
				{
					text:'СуммаЗаказа',
				},
				{
					text:'ВалютаЗаказа',
				},
				{
					text:'ОтветственныйЗаЗаказ',
				},
				{
					text:'ПричинаЗакрытияЗаказа',
				},
				{
					text:'ОрганизацияЗаказа',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:101px;width:634px;height:24px;',
			items:
			[
				{
					text:'Разделитель',
				},
				{
					text:'ДействиеЗаполнить',
				},
				{
					text:'ПодменюЗаполнить',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПодразделениеКомпании',
			style: 'position:absolute;left:94px;top:325px;width:220px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:376px;width:650px;height:25px;',
			items:
			[
				{
					text:'Разделитель1',
				},
				{
					text:'Записать',
				},
				{
					text:'Печать',
				},
				{
					text:'РазделительЗакрыть',
				},
				{
					text:'ОК',
				},
				{
					text:'Закрыть1',
				},
				{
					text:'РазделительОК',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:84px;top:56px;width:230px;height:19px;',
		},
	]
});