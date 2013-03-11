﻿Ext.define('Справочники.КлассификаторИспользованияРабочегоВремени.ФормаЭлемента',
	{
	extend: 'Ext.window.Window',
	height: 194,width: 466,
	iconCls: 'bogus',
	title: 'Классификатор использования рабочего времени',
	
	items:
	[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Наименование',
			style: 'position:absolute;left:130px;top:33px;width:220px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'БуквенныйКод',
			style: 'position:absolute;left:69px;top:142px;width:28px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ЦифровойКод',
			style: 'position:absolute;left:189px;top:142px;width:25px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПолноеНаименование',
			style: 'position:absolute;left:130px;top:57px;width:220px;height:45px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:466px;height:25px;',
			items:
			[
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:169px;width:466px;height:25px;',
			items:
			[
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'ОсновныеДействияФормыЗакрыть',
				},
				{
					text:'ОсновныеДействияФормыСохранить',
				},
				{
					text:'ОсновныеДействияФормыОК',
				},
			]
		},
	]
});