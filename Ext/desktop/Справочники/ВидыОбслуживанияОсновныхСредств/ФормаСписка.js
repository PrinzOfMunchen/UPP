﻿Ext.define('Справочники.ВидыОбслуживанияОсновныхСредств.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 361,width: 416,
	iconCls: 'bogus',
	title: 'Виды обслуживания основных средств',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:400px;height:320px;',
			height: 320,width: 400,
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
			style: 'position:absolute;left:0px;top:0px;width:416px;height:25px;',
			items:
			[
			]
		},
	]
});