﻿Ext.define('Справочники.РолиКонтактныхЛиц.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 321,width: 348,
	iconCls: 'bogus',
	title: 'Роли контактных лиц',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:332px;height:280px;',
			height: 280,width: 332,
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
			style: 'position:absolute;left:0px;top:0px;width:348px;height:25px;',
			items:
			[
			]
		},
	]
});