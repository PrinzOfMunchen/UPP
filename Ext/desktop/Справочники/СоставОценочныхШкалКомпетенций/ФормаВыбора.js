﻿Ext.define('Справочники.СоставОценочныхШкалКомпетенций.ФормаВыбора',
	{
	extend: 'Ext.window.Window',
	height: 300,width: 452,
	iconCls: 'bogus',
	title: 'Состав оценочных шкал компетенций',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:436px;height:259px;',
			height: 259,width: 436,
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
			style: 'position:absolute;left:0px;top:0px;width:452px;height:25px;',
			items:
			[
				{
					text:'Действие5',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие12',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие1',
				},
				{
					text:'РедактироватьКодНомер',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие11',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие8',
				},
				{
					text:'ДействияФормыВыбрать',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие8',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие5',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие9',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие4',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие1',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие7',
				},
			]
		},
	]
});