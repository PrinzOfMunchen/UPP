﻿Ext.define('Справочники.СоставОценочныхШкалКомпетенций.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 321,width: 451,
	iconCls: 'bogus',
	title: 'Состав оценочных шкал компетенций',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:435px;height:280px;',
			height: 280,width: 435,
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
			style: 'position:absolute;left:0px;top:0px;width:451px;height:25px;',
			items:
			[
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие12',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие11',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие5',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие8',
				},
				{
					text:'РедактироватьКодНомер',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие5',
				},
				{
					text:'Подменю',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие7',
				},
			]
		},
	]
});