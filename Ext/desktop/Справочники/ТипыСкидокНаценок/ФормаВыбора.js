﻿Ext.define('Справочники.ТипыСкидокНаценок.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	height: 300,width: 493,
	iconCls: 'bogus',
	title: 'Типы скидок и наценок',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:477px;height:259px;',
			height: 259,width: 477,
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
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:493px;height:25px;',
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