﻿Ext.define('Документы.ГрафикОтпусковОрганизаций.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 421,width: 1000,
	iconCls: 'bogus',
	title: 'График отпусков организации',
	
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
					text:'Подменю5',
				},
				{
					text:'Действие7',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Подменю3',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие16',
				},
				{
					text:'Действие14',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие22',
				},
				{
					text:'Разделитель9',
				},
				{
					text:'Действие15',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие13',
				},
				{
					text:'Действие14',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Подменю4',
				},
				{
					text:'Разделитель8',
				},
				{
					text:'Действие13',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие20',
				},
				{
					text:'Действие17',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие19',
				},
				{
					text:'Разделитель14',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'ДействиеПечать',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие18',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Действие6',
				},
				{
					text:'Разделитель10',
				},
				{
					text:'Разделитель11',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие4',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие2',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие21',
				},
				{
					text:'Разделитель',
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