﻿Ext.require(['Данные.Отчеты.АнализВходящегоНДС'], function () 
{
	Ext.define('Отчеты.АнализВходящегоНДС.ФормаНастройка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:312px;height:158px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Обработка  Анализ входящего НДС',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'Организация.Представление',
			width: 220,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:84px;top:35px;width:220px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Отчеты.АнализВходящегоНДС.ФормаНастройкаСобытия'], function ()
					{
						var объект = Ext.create("Отчеты.АнализВходящегоНДС.ФормаНастройкаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Отчеты.АнализВходящегоНДС.ФормаНастройкаСобытия'], function ()
					{
						var объект = Ext.create("Отчеты.АнализВходящегоНДС.ФормаНастройкаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'label',
			name: 'Надпись5',
			text: 'Организация:',
			style: 'position:absolute;left:8px;top:35px;width:76px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаНач',
			width: 80,
			height: 19,
			style: 'position:absolute;left:84px;top:8px;width:80px;height:19px;',
		},
		{
			xtype: 'datefield',
			hideLabel: true,
			disabled: false,
			value: 0,
			format: 'd.m.Y',
			name: 'ДатаКон',
			width: 80,
			height: 19,
			style: 'position:absolute;left:184px;top:8px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись6',
			text: 'Период с:',
			style: 'position:absolute;left:8px;top:8px;width:76px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'Надпись7',
			text: 'по:',
			style: 'position:absolute;left:166px;top:8px;width:16px;height:19px;text-align:center;',
		},
		{
			xtype: 'button',
			name: 'КнопкаНастройкаПериода',
			text: '...',
			style: 'position:absolute;left:266px;top:8px;width:20px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Сравнить суммы НДС, включенные в стоимость',
			style: 'position:absolute;left:8px;top:106px;width:296px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Сравнить суммы НДС, предъявленные к вычету',
			style: 'position:absolute;left:8px;top:86px;width:296px;height:15px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Сравнить суммы НДС, предъявленные поставщиком',
			style: 'position:absolute;left:8px;top:66px;width:296px;height:15px;',
		},
		],
	}],
	dockedItems:
	[
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:133px;width:312px;height:25px;',
			dock: 'bottom',
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					text:'ОК',
				},
				'-',
				{
					text:'Отмена',
				},
			]
		},
	]
	});
});