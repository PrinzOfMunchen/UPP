﻿Ext.define('Документы.ВводИндивидуальныхГрафиковРаботыОрганизации.ФормаДокумента',
	{
	extend: 'Ext.window.Window',
	height: 486,width: 1000,
	iconCls: 'bogus',
	title: 'Ввод индивидуальных графиков работы организации',
	
	items:
	[
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Номер',
			style: 'position:absolute;left:48px;top:33px;width:78px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Дата',
			style: 'position:absolute;left:159px;top:33px;width:120px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Организация',
			style: 'position:absolute;left:379px;top:33px;width:169px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'ПодразделениеОрганизации',
			style: 'position:absolute;left:379px;top:57px;width:169px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Ответственный',
			style: 'position:absolute;left:96px;top:57px;width:183px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			name: 'Комментарий',
			style: 'position:absolute;left:85px;top:434px;width:907px;height:19px;',
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:1000px;height:25px;',
			items:
			[
				{
					text:'Действие5',
				},
				{
					text:'СтруктураПодчиненностиДокумента',
				},
				{
					text:'Действие4',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Разделитель',
				},
				{
					text:'ДействиеОткрытьКатегории1',
				},
				{
					text:'Действие',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие2',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие',
				},
				{
					text:'ДвиженияДокументаПоРегистрам',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие',
				},
				{
					text:'Разделитель7',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие7',
				},
				{
					text:'Подменю1',
				},
				{
					text:'ГрафикиРаботыПоВидамВремени',
				},
				{
					text:'Разделитель6',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель5',
				},
				{
					text:'РедактироватьКодНомер',
				},
				{
					text:'Действие3',
				},
				{
					text:'Подменю1',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'Действие5',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие6',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действия',
				},
				{
					text:'Подменю',
				},
				{
					text:'ДействиеОткрытьСвойства1',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:461px;width:1000px;height:25px;',
			items:
			[
				{
					text:'Разделитель1',
				},
				{
					text:'ОсновныеДействияФормыСохранить',
				},
				{
					text:'ОсновныеДействияФормыОК',
				},
				{
					text:'Разделитель',
				},
				{
					text:'ОсновныеДействияФормыЗакрыть',
				},
			]
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:8px;top:196px;width:984px;height:24px;',
			items:
			[
				{
					text:'Действие8',
				},
				{
					text:'Разделитель1',
				},
				{
					text:'ПодменюЗаполнить',
				},
				{
					text:'Разделитель2',
				},
				{
					text:'ДействиеВечерние',
				},
				{
					text:'Разделитель',
				},
				{
					text:'ДействиеНочные',
				},
				{
					text:'Действие3',
				},
				{
					text:'Действие4',
				},
				{
					text:'Действие1',
				},
				{
					text:'Разделитель3',
				},
				{
					text:'Действие5',
				},
				{
					text:'Подбор',
				},
				{
					text:'СписокРаботников',
				},
				{
					text:'Разделитель4',
				},
				{
					text:'ДействиеЗаполнить',
				},
				{
					text:'Разделитель',
				},
				{
					text:'Действие6',
				},
				{
					text:'Действие2',
				},
				{
					text:'Действие9',
				},
				{
					text:'Действие7',
				},
			]
		},
		{
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:220px;width:984px;height:208px;',
			height: 208,width: 984,
			columns:
			[
				{
					text:'НомерСтроки',
				},
				{
					text:'ТабельныйНомерСтрока',
				},
				{
					text:'Сотрудник',
				},
				{
					text:'ЗаголовокИтогоДнейЧасов',
				},
				{
					text:'ИтогоРасчетДней',
				},
				{
					text:'ИтогоРасчетЧасов',
				},
				{
					text:'ИтогоРасчетВечерних',
				},
				{
					text:'ИтогоРасчетНочных',
				},
				{
					text:'ЧасовЗаДень',
				},
				{
					text:'ИзНихВечерних',
				},
				{
					text:'ИзНихНочных',
				},
				{
					text:'Часов1',
				},
				{
					text:'ЧасовВечерних1',
				},
				{
					text:'ЧасовНочных1',
				},
				{
					text:'Часов2',
				},
				{
					text:'ЧасовВечерних2',
				},
				{
					text:'ЧасовНочных2',
				},
				{
					text:'Часов3',
				},
				{
					text:'ЧасовВечерних3',
				},
				{
					text:'ЧасовНочных3',
				},
				{
					text:'Часов4',
				},
				{
					text:'ЧасовВечерних4',
				},
				{
					text:'ЧасовНочных4',
				},
				{
					text:'Часов5',
				},
				{
					text:'ЧасовВечерних5',
				},
				{
					text:'ЧасовНочных5',
				},
				{
					text:'Часов6',
				},
				{
					text:'ЧасовВечерних6',
				},
				{
					text:'ЧасовНочных6',
				},
				{
					text:'Часов7',
				},
				{
					text:'ЧасовВечерних7',
				},
				{
					text:'ЧасовНочных7',
				},
				{
					text:'Часов8',
				},
				{
					text:'ЧасовВечерних8',
				},
				{
					text:'ЧасовНочных8',
				},
				{
					text:'Часов9',
				},
				{
					text:'ЧасовВечерних9',
				},
				{
					text:'ЧасовНочных9',
				},
				{
					text:'Часов10',
				},
				{
					text:'ЧасовВечерних10',
				},
				{
					text:'ЧасовНочных10',
				},
				{
					text:'Часов11',
				},
				{
					text:'ЧасовВечерних11',
				},
				{
					text:'ЧасовНочных11',
				},
				{
					text:'Часов12',
				},
				{
					text:'ЧасовВечерних12',
				},
				{
					text:'ЧасовНочных12',
				},
				{
					text:'Часов13',
				},
				{
					text:'ЧасовВечерних13',
				},
				{
					text:'ЧасовНочных13',
				},
				{
					text:'Часов14',
				},
				{
					text:'ЧасовВечерних14',
				},
				{
					text:'ЧасовНочных14',
				},
				{
					text:'Часов15',
				},
				{
					text:'ЧасовВечерних15',
				},
				{
					text:'ЧасовНочных15',
				},
				{
					text:'Часов16',
				},
				{
					text:'ЧасовВечерних16',
				},
				{
					text:'ЧасовНочных16',
				},
				{
					text:'Часов17',
				},
				{
					text:'ЧасовВечерних17',
				},
				{
					text:'ЧасовНочных17',
				},
				{
					text:'Часов18',
				},
				{
					text:'ЧасовВечерних18',
				},
				{
					text:'ЧасовНочных18',
				},
				{
					text:'Часов19',
				},
				{
					text:'ЧасовВечерних19',
				},
				{
					text:'ЧасовНочных19',
				},
				{
					text:'Часов20',
				},
				{
					text:'ЧасовВечерних20',
				},
				{
					text:'ЧасовНочных20',
				},
				{
					text:'Часов21',
				},
				{
					text:'ЧасовВечерних21',
				},
				{
					text:'ЧасовНочных21',
				},
				{
					text:'Часов22',
				},
				{
					text:'ЧасовВечерних22',
				},
				{
					text:'ЧасовНочных22',
				},
				{
					text:'Часов23',
				},
				{
					text:'ЧасовВечерних23',
				},
				{
					text:'ЧасовНочных23',
				},
				{
					text:'Часов24',
				},
				{
					text:'ЧасовВечерних24',
				},
				{
					text:'ЧасовНочных24',
				},
				{
					text:'Часов25',
				},
				{
					text:'ЧасовВечерних25',
				},
				{
					text:'ЧасовНочных25',
				},
				{
					text:'Часов26',
				},
				{
					text:'ЧасовВечерних26',
				},
				{
					text:'ЧасовНочных26',
				},
				{
					text:'Часов27',
				},
				{
					text:'ЧасовВечерних27',
				},
				{
					text:'ЧасовНочных27',
				},
				{
					text:'Часов28',
				},
				{
					text:'ЧасовВечерних28',
				},
				{
					text:'ЧасовНочных28',
				},
				{
					text:'Часов29',
				},
				{
					text:'ЧасовВечерних29',
				},
				{
					text:'ЧасовНочных29',
				},
				{
					text:'Часов30',
				},
				{
					text:'ЧасовВечерних30',
				},
				{
					text:'ЧасовНочных30',
				},
				{
					text:'Часов31',
				},
				{
					text:'ЧасовВечерних31',
				},
				{
					text:'ЧасовНочных31',
				},
				{
					text:'ВсегоДней',
				},
				{
					text:'ВсегоЧасов',
				},
				{
					text:'ВсегоЧасовВечерних',
				},
				{
					text:'ВсегоЧасовНочных',
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:92px;width:984px;height:82px;',
			height: 82,width: 984,
			items:
			[
				{
					title:'Страница1',
				},
			]
		},
	]
});