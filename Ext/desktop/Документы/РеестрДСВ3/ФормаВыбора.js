﻿Ext.define('Документы.РеестрДСВ3.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	height: 421,width: 620,
	iconCls: 'bogus',
	title: 'Реестры застрахованных лиц (по форме ДСВ-3)',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:604px;height:380px;',
			height: 380,width: 604,
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
					text:'Организация',
				},
				{
					text:'Ответственный',
				},
				{
					text:'Комментарий',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:620px;height:25px;',
			items:
			[
				{
					text:'Подменю2',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'Разделитель',
				},
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
				{
					text:'ДействиеПечать',
				},
				{
					text:'Действие',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Разделитель',
				},
			]
		},
	]
});