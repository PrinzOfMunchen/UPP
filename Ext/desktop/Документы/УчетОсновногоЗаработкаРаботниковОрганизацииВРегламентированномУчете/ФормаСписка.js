﻿Ext.define('Документы.УчетОсновногоЗаработкаРаботниковОрганизацииВРегламентированномУчете.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 301,width: 1000,
	iconCls: 'bogus',
	title: 'Учет основного заработка сотрудников организации в регламентированном учете',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:57px;width:984px;height:236px;',
			height: 236,width: 984,
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
					text:'ОтражаемыйДокумент',
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
					text:'Действие16',
				},
				{
					text:'Действие17',
				},
				{
					text:'Действие24',
				},
				{
					text:'Разделитель9',
				},
				{
					text:'Действие27',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Разделитель9',
				},
				{
					text:'Действие15',
				},
				{
					text:'Разделитель8',
				},
				{
					text:'Подменю3',
				},
				{
					text:'Действие18',
				},
				{
					text:'Действие25',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Разделитель11',
				},
				{
					text:'Действие29',
				},
				{
					text:'Действие21',
				},
				{
					text:'Действие28',
				},
				{
					text:'Разделитель11',
				},
				{
					text:'Действие20',
				},
				{
					text:'Действие23',
				},
				{
					text:'Разделитель10',
				},
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
				{
					text:'Подменю5',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие1',
				},
				{
					text:'Подменю5',
				},
				{
					text:'Действие13',
				},
				{
					text:'Действие16',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие19',
				},
				{
					text:'Действие14',
				},
				{
					text:'Подменю3',
				},
				{
					text:'Разделитель8',
				},
				{
					text:'Действие19',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Действие22',
				},
				{
					text:'Действие20',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие18',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Разделитель10',
				},
				{
					text:'Подменю4',
				},
				{
					text:'Подменю4',
				},
				{
					text:'Действие17',
				},
				{
					text:'Действие15',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'Действие26',
				},
				{
					text:'Действие21',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'Действие2',
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