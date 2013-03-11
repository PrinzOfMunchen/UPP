﻿Ext.define('Справочники.КлассификаторЕдиницИзмерения.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	height: 136,width: 401,
	iconCls: 'bogus',
	title: 'Элемент Классификатор единиц измерения',
	
	items:
	[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Код',
			style: 'position:absolute;left:236px;top:57px;width:40px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:160px;top:33px;width:233px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'НаименованиеПолное',
			style: 'position:absolute;left:160px;top:84px;width:233px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:401px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:111px;width:401px;height:25px;',
			items:
			[
				{
					text:'Закрыть1',
				},
				{
					text:'ОК',
				},
				{
					text:'Записать',
				},
				{
					text:'Разделит��льОК',
				},
				{
					text:'РазделительЗакрыть',
				},
			]
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'МеждународноеСокращение',
			style: 'position:absolute;left:160px;top:57px;width:40px;height:19px;',
		},
	]
});