﻿Ext.define('Документы.ПередачаСЗВ4вПФР.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	height: 554,width: 891,
	iconCls: 'bogus',
	title: 'Опись сведений, передаваемых страхователем в ПФР',
	
	items:
	[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:96px;top:502px;width:670px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:891px;height:25px;',
			items:
			[
				{
					text:'СтруктураПодчиненностиДокумента1',
				},
				{
					text:'Разделитель8',
				},
				{
					text:'Подменю3',
				},
				{
					text:'Подменю3',
				},
				{
					text:'РедактироватьКодНомер',
				},
				{
					text:'Действие11',
				},
				{
					text:'Разделитель8',
				},
				{
					text:'Действие10',
				},
				{
					text:'Действие1',
				},
				{
					text:'Подменю',
				},
				{
					text:'Действие14',
				},
				{
					text:'Разделитель9',
				},
				{
					text:'Действие10',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'Действие8',
				},
				{
					text:'ДвиженияДокументаПоРегистрам1',
				},
				{
					text:'Действие7',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие13',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Разделитель9',
				},
				{
					text:'ДействиеОткрытьСвойства',
				},
				{
					text:'Действие9',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие12',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'Действие15',
				},
				{
					text:'Подменю2',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'ДействиеОткрытьКатегории1',
				},
				{
					text:'Разделитель10',
				},
				{
					text:'Действие8',
				},
				{
					text:'Действие12',
				},
				{
					text:'Действие11',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель11',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:529px;width:891px;height:25px;',
			items:
			[
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'ВсеФайлы',
				},
				{
					text:'Файл',
				},
				{
					text:'Закрыть',
				},
				{
					text:'АДВ11',
				},
				{
					text:'ВсеФайлы',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'СЗВ4',
				},
				{
					text:'ПроверитьВCheckXML',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'АДВ11',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'НаДискетку',
				},
				{
					text:'ОК',
				},
				{
					text:'СЗВ4',
				},
				{
					text:'Записать',
				},
				{
					text:'Разделитель',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:149px;width:875px;height:347px;',
			height: 347,width: 875,
			items:
			[
				{
					title:'АДВ11',
				},
				{
					title:'Страница2010',
				},
				{
					title:'Страница2009',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:875px;height:41px;',
			height: 41,width: 875,
			items:
			[
				{
					title:'Страница1',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:74px;width:875px;height:75px;',
			height: 75,width: 875,
			items:
			[
				{
					title:'Страница1',
				},
			]
		},
	]
});