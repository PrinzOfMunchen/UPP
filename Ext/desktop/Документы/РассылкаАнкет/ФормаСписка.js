﻿Ext.define('Документы.РассылкаАнкет.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 430,width: 800,
	iconCls: 'bogus',
	title: 'Рассылки анкет',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:33px;width:784px;height:389px;',
			height: 389,width: 784,
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
					text:'Анкета',
				},
				{
					text:'ПервичнаяРассылка',
				},
				{
					text:'ТекстПисьма',
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
			style: 'position:absolute;left:0px;top:0px;width:800px;height:25px;',
			items:
			[
				{
					text:'Действие7',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие3',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие5',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие1',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Подменю',
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
					text:'Действие6',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Подменю3',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие9',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие5',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель16',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие12',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие4',
				},
				{
					text:'ДействиеПечать',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие10',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие1',
				},
				{
					text:'Действие8',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Действие11',
				},
				{
					text:'Подменю2',
				},
			]
		},
	]
});