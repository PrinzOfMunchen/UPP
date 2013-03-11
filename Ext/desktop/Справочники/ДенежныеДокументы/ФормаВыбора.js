﻿Ext.define('Справочники.ДенежныеДокументы.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	height: 300,width: 690,
	iconCls: 'bogus',
	title: 'Денежные документы',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:674px;height:259px;',
			height: 259,width: 674,
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
					text:'ВидДокумента',
				},
				{
					text:'Стоимость',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:690px;height:25px;',
			items:
			[
				{
					text:'Разделитель6',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие16',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие14',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие13',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие6',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие13',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие1',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие12',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие12',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Действие10',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие7',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие15',
				},
				{
					text:'Действие2',
				},
			]
		},
	]
});