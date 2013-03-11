﻿Ext.define('Документы.ВводРаспределенияЗаработкаРаботников.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 321,width: 1000,
	iconCls: 'bogus',
	title: 'Ввод распределения заработка сотрудников',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:984px;height:280px;',
			height: 280,width: 984,
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
					text:'Период',
				},
				{
					text:'КраткийСоставДокумента',
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
			style: 'position:absolute;left:0px;top:0px;width:1000px;height:25px;',
			items:
			[
				{
					text:'Разделитель',
				},
				{
					text:'Действие13',
				},
				{
					text:'Разделитель',
				},
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие21',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие8',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Действие14',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие14',
				},
				{
					text:'Действие13',
				},
				{
					text:'Действие19',
				},
				{
					text:'Подменю4',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель11',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие10',
				},
				{
					text:'Разделитель',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Подменю',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие18',
				},
				{
					text:'Действие16',
				},
				{
					text:'Действие20',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Действие17',
				},
				{
					text:'Действие6',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'Разделитель8',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие4',
				},
				{
					text:'Подменю3',
				},
				{
					text:'Разделитель9',
				},
				{
					text:'Действие15',
				},
				{
					text:'Подменю5',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие3',
				},
				{
					text:'Разделитель10',
				},
				{
					text:'Действие2',
				},
			]
		},
	]
});