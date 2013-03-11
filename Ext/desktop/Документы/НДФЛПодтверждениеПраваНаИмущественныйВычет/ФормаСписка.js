﻿Ext.define('Документы.НДФЛПодтверждениеПраваНаИмущественныйВычет.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 300,width: 1000,
	iconCls: 'bogus',
	title: 'Подтверждение права на имущественный вычет',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:57px;width:984px;height:235px;',
			height: 235,width: 984,
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
					text:'НалоговыйПериод',
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
					text:'Разделитель2',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие9',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие4',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие5',
				},
				{
					text:'Разделитель',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие14',
				},
				{
					text:'Действие7',
				},
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие10',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие11',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие3',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие10',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие6',
				},
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
					text:'Действие8',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие13',
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