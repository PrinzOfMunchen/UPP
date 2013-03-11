﻿Ext.define('Справочники.ПоказателиАнализовНоменклатуры.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 360,width: 550,
	iconCls: 'bogus',
	title: 'Справочник Показатели анализов номенклатуры',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:159px;top:33px;width:383px;height:319px;',
			height: 319,width: 383,
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
					text:'ВидРезультатаАнализа',
				},
				{
					text:'МинЗначение',
				},
				{
					text:'МаксЗначение',
				},
				{
					text:'ЕдиницаИзмерения',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:145px;height:319px;',
			height: 319,width: 145,
			columns:
			[
				{
					text:'Наименование',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:550px;height:25px;',
			items:
			[
			]
		},
	]
});