﻿Ext.define('Документы.ИнвентаризацияТоваровОтданныхНаКомиссию.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	height: 421,width: 500,
	iconCls: 'bogus',
	title: 'Инвентаризации товаров отданных на комиссию',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:484px;height:380px;',
			height: 380,width: 484,
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
					text:'Контрагент',
				},
				{
					text:'ДоговорКонтрагента',
				},
				{
					text:'Организация',
				},
				{
					text:'Комментарий',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:500px;height:25px;',
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