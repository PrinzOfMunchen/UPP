﻿Ext.define('Документы.РеестрДСВ3.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 421,width: 1000,
	iconCls: 'bogus',
	title: 'Реестры застрахованных лиц (по форме ДСВ-3)',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:57px;width:984px;height:356px;',
			height: 356,width: 984,
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
					text:'КраткийСоставДокумента',
				},
				{
					text:'КолонкаЗаголовок',
				},
				{
					text:'НомерПлатежногоПоручения',
				},
				{
					text:'ДатаПлатежногоПоручения',
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
					text:'Разделитель11',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие22',
				},
				{
					text:'Действие14',
				},
				{
					text:'Действие5',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие6',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Действие3',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие16',
				},
				{
					text:'Разделитель13',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие12',
				},
				{
					text:'Подменю6',
				},
				{
					text:'Действие7',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Разделитель',
				},
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
				{
					text:'Действие15',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Разделитель14',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Подменю3',
				},
				{
					text:'Действие',
				},
				{
					text:'Подменю5',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие17',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие19',
				},
				{
					text:'Подменю',
				},
				{
					text:'Разделитель8',
				},
				{
					text:'Подменю7',
				},
				{
					text:'Действие13',
				},
				{
					text:'Разделитель10',
				},
				{
					text:'Действие11',
				},
				{
					text:'Разделитель12',
				},
				{
					text:'Действие13',
				},
				{
					text:'Действие20',
				},
				{
					text:'Действие21',
				},
				{
					text:'Действие14',
				},
				{
					text:'Разделитель9',
				},
				{
					text:'Действие12',
				},
				{
					text:'Подменю4',
				},
				{
					text:'Действие18',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие2',
				},
				{
					text:'ДействиеПечать',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие10',
				},
				{
					text:'Разделитель4',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:984px;height:19px;',
			height: 19,width: 984,
			items:
			[
				{
					title:'Страница1',
				},
			]
		},
	]
});