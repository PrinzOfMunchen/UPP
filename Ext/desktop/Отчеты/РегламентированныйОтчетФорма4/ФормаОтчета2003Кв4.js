﻿Ext.require(['Данные.Отчеты.РегламентированныйОтчетФорма4'], function () 
{
	Ext.define('Отчеты.РегламентированныйОтчетФорма4.ФормаОтчета2003Кв4',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:720px;height:482px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Форма №4',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:457px;width:720px;height:25px;',
			items:
			[
				{
					xtype: 'tbfill'
				},
			]
		},
		{
			xtype: 'label',
			name: '_ИндикаторВнешнегоОтчета',
			text: 'Внешний отчет',
			style: 'position:absolute;left:634px;top:5px;width:78px;height:15px;',
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:74px;width:704px;height:48px;',
			height: 48,width: 704,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'combobox',
			style: 'position:absolute;left:82px;top:0px;width:120px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ПолеВводаТочностьЕдиницыИзмерения',
			style: 'position:absolute;left:258px;top:0px;width:32px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ПолеВводаДатаСдачи',
			width: 80,
			height: 19,
			style: 'position:absolute;left:82px;top:23px;width:80px;height:19px;',
		},
		{
			xtype: 'combobox',
			style: 'position:absolute;left:174px;top:23px;width:116px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'НомерКорректировки',
			style: 'position:absolute;left:305px;top:23px;width:49px;height:19px;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:428px;width:704px;height:22px;',
			height: 22,width: 704,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'КомментарийОбщий',
			width: 441,
			height: 19,
			style: 'position:absolute;left:263px;top:3px;width:441px;height:19px;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'Статус.Представление',
			width: 119,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:47px;top:3px;width:119px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Отчеты.РегламентированныйОтчетФорма4.ФормаОтчета2003Кв4События'], function ()
					{
						var объект = Ext.create("Отчеты.РегламентированныйОтчетФорма4.ФормаОтчета2003Кв4События");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Отчеты.РегламентированныйОтчетФорма4.ФормаОтчета2003Кв4События'], function ()
					{
						var объект = Ext.create("Отчеты.РегламентированныйОтчетФорма4.ФормаОтчета2003Кв4События");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:122px;width:704px;height:306px;',
			height: 306,width: 704,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'combobox',
			style: 'position:absolute;left:0px;top:261px;width:232px;height:19px;',
		},
		{
			xtype: 'numberfield',
			hideLabel: true,
			hideTrigger: true,
			disabled: false,
			value: 0,
			name: 'ПолеВводаЗначениеКорректировкиФормаОтчета',
			style: 'position:absolute;left:238px;top:261px;width:117px;height:19px;',
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			name: 'ПолеВводаКомментарийФормаОтчета',
			width: 342,
			height: 19,
			style: 'position:absolute;left:362px;top:261px;width:342px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаДобавитьДопСтрокиФормаОтчета',
			text: 'Добавить',
			style: 'position:absolute;left:138px;top:285px;width:80px;height:19px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаУдалитьДопСтрокиФормаОтчета',
			text: 'Удалить',
			style: 'position:absolute;left:224px;top:285px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'НадписьДополнительныеСтроки',
			text: 'Дополнительные строки:',
			style: 'position:absolute;left:0px;top:285px;width:132px;height:19px;text-align:left;',
		},
					]
				},
			]
		},
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:33px;width:704px;height:37px;',
			height: 37,width: 704,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:2px;top:0px;width:702px;height:35px;',
			height: 35,width: 702,
			tabBar:{hidden:true},
			items:
			[
				{
					title:'Страница1',
					items:
					[
					]
				},
			]
		},
					]
				},
			]
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:720px;height:25px;',
			dock: 'top',
			items:
			[
				{
					text:'Проверить в Интернете',
				},
				{
					text:'Отправить',
				},
				'-',
				{
					text:'Подготовить к отправке и подписать',
				},
				{
					text:'Подготовить к отправке',
				},
				'-',
				{
					text:'Показать отправки',
				},
			]
		},
	]
	});
});