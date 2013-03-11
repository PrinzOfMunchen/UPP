﻿Ext.define('Документы.ЗарплатаКВыплатеОрганизаций.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	height: 421,width: 780,
	iconCls: 'bogus',
	title: 'Зарплаты к выплате организации',
	
	items:
	[
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:57px;width:764px;height:356px;',
			height: 356,width: 764,
			columns:
			[
				{
					text:'Картинка',
				},
				{
					text:'Оплачена',
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
					text:'ПодразделениеОрганизации',
				},
				{
					text:'ПериодРегистрации',
				},
				{
					text:'ХарактерВыплаты',
				},
				{
					text:'ДокументОснование',
				},
				{
					text:'КраткийСоставДокумента',
				},
				{
					text:'Сумма',
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
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:780px;height:25px;',
			items:
			[
				{
					text:'Действие8',
				},
				{
					text:'Действие10',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие11',
				},
				{
					text:'Действие7',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие4',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Разделитель8',
				},
				{
					text:'Действие1',
				},
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
				{
					text:'Действие13',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие3',
				},
				{
					text:'Подменю3',
				},
				{
					text:'Выплатить',
				},
				{
					text:'Действие9',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'Выплатить',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие10',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие6',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Действие4',
				},
				{
					text:'Подменю',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие7',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'ПодменюДействия',
				},
				{
					text:'Действие14',
				},
				{
					text:'ПодменюПерейти',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Печать',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие6',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие5',
				},
			]
		},
	]
});