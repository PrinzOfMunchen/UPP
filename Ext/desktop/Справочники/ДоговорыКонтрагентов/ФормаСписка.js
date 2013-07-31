﻿Ext.require(['Данные.Справочники.ДоговорыКонтрагентов'], function () 
{
	Ext.define('Справочники.ДоговорыКонтрагентов.ФормаСписка',
	{
	extend: 'Ext.window.Window',
	style: 'position:absolute;width:780px;height:320px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	title: 'Договоры контрагентов',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		items:
		[
		{
			id: 'СправочникСписок',
			xtype: 'grid',
			style: 'position:absolute;left:174px;top:32px;width:598px;height:280px;',
			height: 280,width: 598,
			columns:
			[
				{
					text:'',
					width:'32',
					dataIndex:'Картинка',
					flex:1,
				},
				{
					text:'Код',
					width:'40',
					dataIndex:'Код',
					flex:1,
				},
				{
					text:'Наименование',
					width:'220',
					dataIndex:'Наименование',
					flex:1,
				},
				{
					text:'Валюта',
					width:'60',
					dataIndex:'ВалютаВзаиморасчетов.Представление',
					flex:1,
				},
				{
					text:'Контрагент',
					width:'120',
					dataIndex:'Владелец',
					flex:1,
				},
				{
					text:'Организация',
					width:'120',
					dataIndex:'Организация.Представление',
					flex:1,
				},
				{
					text:'Вид договора',
					width:'120',
					dataIndex:'ВидДоговора.Представление',
					flex:1,
				},
				{
					text:'Номер',
					width:'80',
					dataIndex:'Номер',
					flex:1,
				},
				{
					text:'Дата',
					width:'80',
					dataIndex:'Дата',
					flex:1,
				},
				{
					text:'Ведение взаиморасчетов',
					width:'120',
					dataIndex:'ВедениеВзаиморасчетов.Представление',
					flex:1,
				},
				{
					text:'Вид взаиморасчетов',
					width:'120',
					dataIndex:'ВидВзаиморасчетов.Представление',
					flex:1,
				},
				{
					text:'Вид условий договора',
					width:'120',
					dataIndex:'ВидУсловийДоговора.Представление',
					flex:1,
				},
				{
					text:'Держать резерв без оплаты ограниченное время',
					width:'120',
					dataIndex:'ДержатьРезервБезОплатыОграниченноеВремя',
					flex:1,
				},
				{
					text:'Допустимая сумма дебиторской задолженности',
					width:'120',
					dataIndex:'ДопустимаяСуммаЗадолженности',
					flex:1,
				},
				{
					text:'Допустимое число дней дебиторской задолженности',
					width:'120',
					dataIndex:'ДопустимоеЧислоДнейЗадолженности',
					flex:1,
				},
				{
					text:'Комментарий',
					width:'100',
					dataIndex:'Комментарий',
					flex:1,
				},
				{
					text:'Контролировать сумму дебиторской задолженности',
					width:'60',
					dataIndex:'КонтролироватьСуммуЗадолженности',
					flex:1,
				},
				{
					text:'Контролировать число дней дебиторской задолженности',
					width:'60',
					dataIndex:'КонтролироватьЧислоДнейЗадолженности',
					flex:1,
				},
				{
					text:'Обособленный учет Товаров по заказам покупателей',
					width:'60',
					dataIndex:'ОбособленныйУчетТоваровПоЗаказамПокупателей',
					flex:1,
				},
				{
					text:'Процент комиссионного вознаграждения',
					width:'80',
					dataIndex:'ПроцентКомиссионногоВознаграждения',
					flex:1,
				},
				{
					text:'Процент предоплаты',
					width:'80',
					dataIndex:'ПроцентПредоплаты',
					flex:1,
				},
				{
					text:'Способ расчета комиссионного вознаграждения',
					width:'120',
					dataIndex:'СпособРасчетаКомиссионногоВознаграждения.Представление',
					flex:1,
				},
				{
					text:'Тип цен',
					width:'129',
					dataIndex:'ТипЦен',
					flex:1,
				},
				{
					text:'Число дней резерва без оплаты',
					width:'70',
					dataIndex:'ЧислоДнейРезерваБезОплаты',
					flex:1,
				},
				{
					text:'Учет агентского НДС',
					width:'70',
					dataIndex:'УчетАгентскогоНДС',
					flex:1,
				},
				{
					text:'Вид агентского договора',
					width:'100',
					dataIndex:'ВидАгентскогоДоговора.Представление',
					flex:1,
				},
				{
					text:'Контролировать денежные средства комитента',
					width:'70',
					dataIndex:'КонтролироватьДенежныеСредстваКомитента',
					flex:1,
				},
				{
					text:'Расчеты в условных единицах',
					width:'70',
					dataIndex:'РасчетыВУсловныхЕдиницах',
					flex:1,
				},
				{
					text:'По документам расчетов с контрагентом',
					width:'70',
					dataIndex:'ВестиПоДокументамРасчетовСКонтрагентом',
					flex:1,
				},
				{
					text:'Основной проект',
					width:'225',
					dataIndex:'ОсновнойПроект',
					flex:1,
				},
				{
					text:'Реализация на экспорт',
					width:'70',
					dataIndex:'РеализацияНаЭкспорт',
					flex:1,
				},
				{
					text:'Основная статья движения денежных средств',
					width:'350',
					dataIndex:'ОсновнаяСтатьяДвиженияДенежныхСредств.Представление',
					flex:1,
				},
				{
					text:'Срок действия договора',
					width:'84',
					dataIndex:'СрокДействия',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.ДоговорыКонтрагентов").data,
					fields: ['Картинка','Код','Наименование','ВалютаВзаиморасчетов.Представление','Владелец','Организация.Представление','ВидДоговора.Представление','Номер','Дата','ВедениеВзаиморасчетов.Представление','ВидВзаиморасчетов.Представление','ВидУсловийДоговора.Представление','ДержатьРезервБезОплатыОграниченноеВремя','ДопустимаяСуммаЗадолженности','ДопустимоеЧислоДнейЗадолженности','Комментарий','КонтролироватьСуммуЗадолженности','КонтролироватьЧислоДнейЗадолженности','ОбособленныйУчетТоваровПоЗаказамПокупателей','ПроцентКомиссионногоВознаграждения','ПроцентПредоплаты','СпособРасчетаКомиссионногоВознаграждения.Представление','ТипЦен','ЧислоДнейРезерваБезОплаты','УчетАгентскогоНДС','ВидАгентскогоДоговора.Представление','КонтролироватьДенежныеСредстваКомитента','РасчетыВУсловныхЕдиницах','ВестиПоДокументамРасчетовСКонтрагентом','ОсновнойПроект','РеализацияНаЭкспорт','ОсновнаяСтатьяДвиженияДенежныхСредств.Представление','СрокДействия',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ДоговорыКонтрагентов/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Картинка',
					},
					{
						name:'Код',
					},
					{
						name:'Наименование',
					},
					{
						name:'ВалютаВзаиморасчетов',
					},
					{
						name:'Владелец',
					},
					{
						name:'Организация',
					},
					{
						name:'ВидДоговора',
					},
					{
						name:'Номер',
					},
					{
						name:'Дата',
					},
					{
						name:'ВедениеВзаиморасчетов',
					},
					{
						name:'ВидВзаиморасчетов',
					},
					{
						name:'ВидУсловийДоговора',
					},
					{
						name:'ДержатьРезервБезОплатыОграниченноеВремя',
					},
					{
						name:'ДопустимаяСуммаЗадолженности',
					},
					{
						name:'ДопустимоеЧислоДнейЗадолженности',
					},
					{
						name:'Комментарий',
					},
					{
						name:'КонтролироватьСуммуЗадолженности',
					},
					{
						name:'КонтролироватьЧислоДнейЗадолженности',
					},
					{
						name:'ОбособленныйУчетТоваровПоЗаказамПокупателей',
					},
					{
						name:'ПроцентКомиссионногоВознаграждения',
					},
					{
						name:'ПроцентПредоплаты',
					},
					{
						name:'СпособРасчетаКомиссионногоВознаграждения',
					},
					{
						name:'ТипЦен',
					},
					{
						name:'ЧислоДнейРезерваБезОплаты',
					},
					{
						name:'УчетАгентскогоНДС',
					},
					{
						name:'ВидАгентскогоДоговора',
					},
					{
						name:'КонтролироватьДенежныеСредстваКомитента',
					},
					{
						name:'РасчетыВУсловныхЕдиницах',
					},
					{
						name:'ВестиПоДокументамРасчетовСКонтрагентом',
					},
					{
						name:'ОсновнойПроект',
					},
					{
						name:'РеализацияНаЭкспорт',
					},
					{
						name:'ОсновнаяСтатьяДвиженияДенежныхСредств',
					},
					{
						name:'СрокДействия',
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
						var грид = Ext.getCmp('СправочникСписок');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ДоговорыКонтрагентов.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ДоговорыКонтрагентов.ФормаСпискаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			id: 'СправочникДерево',
			xtype: 'grid',
			style: 'position:absolute;left:8px;top:32px;width:160px;height:280px;',
			height: 280,width: 160,
			columns:
			[
				{
					text:'Наименование',
					width:'220',
					dataIndex:'Наименование',
					flex:1,
				},
			],
			store:
			{
				data: Ext.create("Ext.data.Store",
				{
					data: Ext.create("Данные.Справочники.ДоговорыКонтрагентов").data,
					fields: ['Наименование',]
				}).data.items,
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/ДоговорыКонтрагентов/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Наименование',
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
						var грид = Ext.getCmp('СправочникДерево');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data;
						Ext.require(['Справочники.ДоговорыКонтрагентов.ФормаСпискаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.ДоговорыКонтрагентов.ФормаСпискаСобытия");
							obj.ПередатьСсылку(ссылка);
						});
					}
				}
			},
		},
		{
			xtype: 'toolbar',
			style: 'position:absolute;left:0px;top:0px;width:780px;height:25px;',
			items:
			[
				{
					xtype: 'splitbutton',
					text:'Действия',
					menu: [
				{
					text:'Файлы',
				},
					]
				},
				'-',
				{
					text:'Свойства',
				},
				{
					text:'Категории',
				},
				'-',
				{
					text:'Файлы',
				},
			]
		},
		],
	}],
	dockedItems:
	[
	]
	});
});