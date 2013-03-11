﻿Ext.define('Справочники.Проекты.ФормаВыбораГруппы',
	{
	extend: 'Ext.window.Window',
	height: 421,width: 308,
	iconCls: 'bogus',
	title: 'Группы проектов',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:292px;height:380px;',
			height: 380,width: 292,
			columns:
			[
				{
					text:'Наименование',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:308px;height:25px;',
			items:
			[
				{
					text:'Действие',
				},
				{
					text:'Разделитель',
				},
			]
		},
	]
});