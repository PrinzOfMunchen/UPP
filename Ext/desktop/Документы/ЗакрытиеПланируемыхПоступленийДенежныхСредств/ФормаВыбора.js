﻿Ext.define('Документы.ЗакрытиеПланируемыхПоступленийДенежныхСредств.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	height: 421,width: 780,
	iconCls: 'bogus',
	title: 'Закрытие планируемых поступлений денежных средств',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:764px;height:380px;',
			height: 380,width: 764,
			columns:
			[
				{
					text:'Картинка',
				},
				{
					text:'Дата',
				},
				{
					text:'Номер',
				},
				{
					text:'Ответственный',
				},
				{
					text:'Состояние',
				},
				{
					text:'ЦФО',
				},
				{
					text:'Контрагент',
				},
				{
					text:'ОтветственныйПоступление',
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
					text:'Подменю2',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
			]
		},
	]
});