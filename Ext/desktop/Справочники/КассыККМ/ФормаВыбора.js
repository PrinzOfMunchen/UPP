﻿Ext.define('Справочники.КассыККМ.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	height: 321,width: 484,
	iconCls: 'bogus',
	title: 'Кассы ККМ',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:468px;height:280px;',
			height: 280,width: 468,
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
					text:'Владелец',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:484px;height:25px;',
			items:
			[
				{
					text:'Разделитель',
				},
				{
					text:'Действие',
				},
			]
		},
	]
});