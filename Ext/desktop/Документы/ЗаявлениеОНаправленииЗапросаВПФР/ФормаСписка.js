﻿Ext.define('Документы.ЗаявлениеОНаправленииЗапросаВПФР.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 420,width: 780,
	iconCls: 'bogus',
	title: 'Заявления о направлении запроса в ПФР',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:57px;width:764px;height:355px;',
			height: 355,width: 764,
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
					text:'Организация',
				},
				{
					text:'Сотрудник',
				},
				{
					text:'Страхователь',
				},
				{
					text:'ВидПособия',
				},
				{
					text:'Ответственный',
				},
				{
					text:'Комментарий',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:780px;height:25px;',
			items:
			[
				{
					text:'Действие9',
				},
				{
					text:'Действие14',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие13',
				},
				{
					text:'Подменю',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие10',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие11',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие12',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Подменю3',
				},
				{
					text:'Действие6',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие2',
				},
				{
					text:'Печать',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие1',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие3',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие1',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Подменю3',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие5',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:764px;height:19px;',
			height: 19,width: 764,
			items:
			[
				{
					title:'Страница1',
				},
			]
		},
	]
});