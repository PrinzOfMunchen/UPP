﻿Ext.define('Документы.Увольнение.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 421,width: 1000,
	iconCls: 'bogus',
	title: 'Увольнения',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:984px;height:380px;',
			height: 380,width: 984,
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
					text:'Разделитель1',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие9',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие7',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Действие3',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие3',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие8',
				},
				{
					text:'Подменю2',
				},
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
				{
					text:'Действие9',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие',
				},
				{
					text:'Подменю',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие14',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие4',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Подменю3',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие13',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие8',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'УвольнениеИзОрганизацийВводНаОсновании',
				},
				{
					text:'Действие5',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Подменю3',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие',
				},
			]
		},
	]
});