﻿Ext.define('Справочники.МедицинскиеСтраховыеПолисы.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 300,width: 901,
	iconCls: 'bogus',
	title: 'Медицинские страховые полисы',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:885px;height:259px;',
			height: 259,width: 885,
			columns:
			[
				{
					text:'Картинка',
				},
				{
					text:'Физлицо',
				},
				{
					text:'Организация',
				},
				{
					text:'Код',
				},
				{
					text:'Наименование',
				},
				{
					text:'ВидСтрахования',
				},
				{
					text:'ДатаОкончанияПолиса',
				},
				{
					text:'ПрограммаСтрахования',
				},
				{
					text:'Родственник',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:901px;height:25px;',
			items:
			[
				{
					text:'Разделитель6',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие17',
				},
				{
					text:'Действие16',
				},
				{
					text:'Действие15',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие6',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие3',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие13',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие10',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Подменю3',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие5',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие11',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Действие14',
				},
			]
		},
	]
});