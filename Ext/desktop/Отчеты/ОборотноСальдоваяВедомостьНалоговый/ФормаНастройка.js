﻿Ext.require(['Данные.Отчеты.ОборотноСальдоваяВедомостьНалоговый'], function () 
{
	Ext.define('Отчеты.ОборотноСальдоваяВедомостьНалоговый.ФормаНастройка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:428px;height:237px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Настройка: Оборотно-сальдовая ведомость',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			xtype: 'tabpanel',
			style: 'position:absolute;left:8px;top:8px;width:412px;height:204px;',
			height: 204,width: 412,
			items:
			[
				{
					title:'Общие',
					items:
					[
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			name: 'Организация.Представление',
			width: 219,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:84px;top:31px;width:219px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Отчеты.ОборотноСальдоваяВедомостьНалоговый.ФормаНастройкаСобытия'], function ()
					{
						var объект = Ext.create("Отчеты.ОборотноСальдоваяВедомостьНалоговый.ФормаНастройкаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Отчеты.ОборотноСальдоваяВедомостьНалоговый.ФормаНастройкаСобытия'], function ()
					{
						var объект = Ext.create("Отчеты.ОборотноСальдоваяВедомостьНалоговый.ФормаНастройкаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
		{
			xtype: 'label',
			name: 'Надпись5',
			text: 'Организация:',
			style: 'position:absolute;left:6px;top:31px;width:72px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Детализация по субсчетам и субконто',
			style: 'position:absolute;left:16px;top:128px;width:214px;height:15px;',
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
			style: 'position:absolute;left:84px;top:4px;width:80px;height:19px;',
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
			style: 'position:absolute;left:197px;top:4px;width:80px;height:19px;',
		},
		{
			xtype: 'label',
			name: 'Надпись6',
			text: 'Период с:',
			style: 'position:absolute;left:6px;top:4px;width:72px;height:19px;text-align:left;',
		},
		{
			xtype: 'label',
			name: 'Надпись7',
			text: 'по:',
			style: 'position:absolute;left:170px;top:4px;width:20px;height:19px;text-align:center;',
		},
		{
			xtype: 'fieldset',
			title: 'Выводить данные:',
			style: 'position:absolute;left:6px;top:90px;width:297px;height:16px;',
		},
		{
			xtype: 'button',
			name: 'КнопкаНастройкаПериода',
			text: '...',
			style: 'position:absolute;left:284px;top:4px;width:19px;height:19px;',
		},
		{
			xtype: 'checkbox',
			boxLabel: 'Развернутое сальдо',
			style: 'position:absolute;left:16px;top:110px;width:126px;height:15px;',
		},
		{
			xtype: 'label',
			name: 'Надпись1',
			text: 'Вид учета:',
			style: 'position:absolute;left:6px;top:57px;width:72px;height:19px;text-align:left;',
		},
		{
			xtype: 'trigger',
			hideLabel: true,
			disabled: false,
			trigger1Cls: 'x-form-select-trigger',
			trigger2Cls: 'x-form-clear-trigger',
			name: 'ВидУчета.Представление',
			width: 219,
			height: 19,
			Хранилище:'Ссылка',
			style: 'position:absolute;left:84px;top:57px;width:219px;height:19px;',
			onTriggerClick : function(ЭтотОбъект)
			{
				var СтрокаЗнч = ЭтотОбъект.target.className;
				var Элемент = this.up('window');
				var Окно = Ext.getCmp(Элемент.getId());
				var Ссылка = Окно.Хранилище;
				if (СтрокаЗнч.indexOf("-select-") != -1)
				{
					Ext.require(['Отчеты.ОборотноСальдоваяВедомостьНалоговый.ФормаНастройкаСобытия'], function ()
					{
						var объект = Ext.create("Отчеты.ОборотноСальдоваяВедомостьНалоговый.ФормаНастройкаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
				if (СтрокаЗнч.indexOf("-clear-") != -1)
				{
					alert('clear');
				};
				if (СтрокаЗнч.indexOf("-search-") != -1)
				{
					Ext.require(['Отчеты.ОборотноСальдоваяВедомостьНалоговый.ФормаНастройкаСобытия'], function ()
					{
						var объект = Ext.create("Отчеты.ОборотноСальдоваяВедомостьНалоговый.ФормаНастройкаСобытия");
						объект.ПередатьСсылку(Ссылка);
					});
				};
			},
		},
					]
				},
				{
					title:'Развернутое сальдо',
					items:
					[
		{
			id: 'ПравилаРазвернутогоСальдо',
			xtype: 'grid',
			style: 'position:absolute;left:4px;top:28px;width:400px;height:152px;',
			height: 152,width: 400,
			columns:
			[
				{
					text:'Счет',
					width:'100',
					dataIndex:'Счет',
					flex:1,
				},
				{
					text:'По субсчетам',
					width:'90',
					dataIndex:'Субсчета',
					flex:1,
				},
				{
					text:'По субконто',
					width:'200',
					dataIndex:'ПредставлениеРазворотПоСубконто',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ОборотноСальдоваяВедомостьНалоговый/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Счет',
					},
					{
						name:'Субсчета',
					},
					{
						name:'ПредставлениеРазворотПоСубконто',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('ПравилаРазвернутогоСальдо');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ОборотноСальдоваяВедомостьНалоговый.ФормаНастройкаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ОборотноСальдоваяВедомостьНалоговый.ФормаНастройкаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
					]
				},
				{
					title:'Детализация',
					items:
					[
		{
			id: 'ПравилаВыводаИтогов',
			xtype: 'grid',
			style: 'position:absolute;left:4px;top:28px;width:400px;height:152px;',
			height: 152,width: 400,
			columns:
			[
				{
					text:'Счет',
					width:'100',
					dataIndex:'Счет',
					flex:1,
				},
				{
					text:'По субсчетам',
					width:'90',
					dataIndex:'Субсчета',
					flex:1,
				},
				{
					text:'По субконто',
					width:'200',
					dataIndex:'ПредставлениеРазворотПоСубконто',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ОборотноСальдоваяВедомостьНалоговый/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Счет',
					},
					{
						name:'Субсчета',
					},
					{
						name:'ПредставлениеРазворотПоСубконто',
					},
				]
			},
			listeners:
			{
				dblclick:
				{
					element: 'body',
					fn: function ()
					{
						var грид = Ext.getCmp('ПравилаВыводаИтогов');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ОборотноСальдоваяВедомостьНалоговый.ФормаНастройкаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ОборотноСальдоваяВедомостьНалоговый.ФормаНастройкаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
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
			style: 'position:absolute;left:0px;top:212px;width:428px;height:25px;',
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
					text:'Закрыть',
					handler: function () {this.up('window').close();},
				},
				'-',
				{
					text:'Справка',
				},
			]
		},
	]
	});
});