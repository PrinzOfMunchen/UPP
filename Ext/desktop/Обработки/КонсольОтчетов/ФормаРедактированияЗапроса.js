﻿Ext.require(['Данные.Обработки.КонсольОтчетов'], function () 
{
	Ext.define('Обработки.КонсольОтчетов.ФормаРедактированияЗапроса',
	{
	extend: 'Ext.window.Window',
	id: 'ФормаРедактированияЗапроса',
	style: 'position:absolute;width:400px;height:309px;',
	iconCls: 'bogus',
	minimizable: true,
	maximizable: true,
	resizable: false,
	title: 'Редактирование запроса',
	
	layout: {type: "fit",align: "stretch"},
	items:
	[{
		xtype: 'form',
		ПервоеОткрытие: true,
		items:
		[
		{
			xtype: 'panel',
			id: 'Запрос',
			style: 'position:absolute;left:6px;top:6px;width:388px;height:270px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:270,
			Ширина:388,
			Верх:6,
			Лево:6,
			Групповой: true,
			height: 270,width: 388,
			items:
			[
				{
					id: 'Запрос',
					items:
					[
		{
			xtype: 'label',
			id: 'Надпись1',
			text: 'Имя:',
			style: 'position:absolute;left:6px;top:6px;width:29px;height:19px;text-align:right;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Надпись1', Граница: 'Левая', Номер: 4, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Надпись1', Граница: 'Верхняя', Номер: 4, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:29,
			Верх:6,
			Лево:6,
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			id: 'Имя',
			width: 322,
			height: 19,
			style: 'position:absolute;left:40px;top:6px;width:322px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Имя', Граница: 'Верхняя', Номер: 5, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:322,
			Верх:6,
			Лево:40,
		},
		{
			xtype: 'checkbox',
			id: 'АвтоЗаполнение',
			boxLabel: 'Автоматическое заполнение настроек',
			style: 'position:absolute;left:6px;top:241px;width:221px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'АвтоЗаполнение', Граница: 'Левая', Номер: 7, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 3, Координата: 0},
					Нижняя: { Элемент: 'АвтоЗаполнение', Граница: 'Верхняя', Номер: 7, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:221,
			Верх:241,
			Лево:6,
		},
		{
			xtype: 'toolbar',
			id: 'КоманднаяПанель2',
			style: 'position:absolute;left:234px;top:238px;width:128px;height:24px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 3, Координата: 0},
					Нижняя: { Элемент: 'КоманднаяПанель2', Граница: 'Верхняя', Номер: 12, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:24,
			Ширина:128,
			Верх:238,
			Лево:234,
			width: 128,
			height: 24,
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					id:'КонструкторЗапросов',
					text:'Конструктор',
					tooltip:'',
				},
				{
					id:'Проверить',
					text:'Проверить запрос',
					tooltip:'Проверить запрос',
				},
			]
		},
					]
				},
				{
					id: 'Параметры',
					items:
					[
		{
			xtype: 'toolbar',
			id: 'КоманднаяПанельПараметры',
			style: 'position:absolute;left:6px;top:6px;width:356px;height:24px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'КоманднаяПанельПараметры', Граница: 'Верхняя', Номер: 10, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:24,
			Ширина:356,
			Верх:6,
			Лево:6,
			width: 356,
			height: 24,
			items:
			[
				{
					id:'Действие1',
					text:'&Добавить',
					tooltip:'Добавить',
					iconCls:'x-copy',
				},
				{
					id:'Действие2',
					text:'&Изменить',
					tooltip:'Изменить текущий элемент',
					iconCls:'x-Change',
				},
				{
					id:'Действие3',
					text:'&Удалить',
					tooltip:'Удалить текущий',
				},
				{
					id:'Действие4',
					text:'Закончить редактирование',
					tooltip:'',
				},
				{
					id:'Действие5',
					text:'&Скопировать',
					tooltip:'',
				},
				{
					id:'Действие6',
					text:'&Переместить вверх',
					tooltip:'',
				},
				{
					id:'Действие7',
					text:'&Переместить вниз',
					tooltip:'',
				},
				{
					id:'Действие8',
					text:'Сортировать по возрастанию',
					tooltip:'Открыть конструктор настроек',
				},
				{
					id:'Действие9',
					text:'Сортировать по убыванию',
					tooltip:'',
				},
				'-',
				{
					id:'ЗаполнитьПараметры',
					text:'Заполнить',
					tooltip:'Заполнить параметры запроса',
				},
			]
		},
		{
			id: 'Параметры',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:34px;width:356px;height:228px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:228,
			Ширина:356,
			Верх:34,
			Лево:6,
			height: 228,width: 356,
			columns:
			[
				{
					text:'Имя параметра',
					width:'122',
					dataIndex:'ИмяПараметра',
					flex:1,
				},
				{
					text:'Тип',
					width:'52',
					dataIndex:'ЭтоВыражение',
					flex:1,
				},
				{
					text:'Значение параметра',
					width:'188',
					dataIndex:'ЗначениеПараметра',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/КонсольОтчетов/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'ИмяПараметра',
					},
					{
						name:'ЭтоВыражение',
					},
					{
						name:'ЗначениеПараметра',
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
						var грид = Ext.getCmp('Параметры');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.КонсольОтчетов.ФормаРедактированияЗапросаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.КонсольОтчетов.ФормаРедактированияЗапросаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
					]
				},
				{
					id: 'Представления',
					items:
					[
		{
			id: 'Представления',
			xtype: 'grid',
			style: 'position:absolute;left:6px;top:6px;width:356px;height:256px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Форма', Граница: 'Нижняя', Номер: 0, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:256,
			Ширина:356,
			Верх:6,
			Лево:6,
			height: 256,width: 356,
			columns:
			[
				{
					text:'Поле',
					width:'100',
					dataIndex:'Поле',
					flex:1,
				},
				{
					text:'Представление',
					width:'100',
					dataIndex:'Представление',
					flex:1,
				},
				{
					text:'Формат',
					width:'100',
					dataIndex:'Формат',
					flex:1,
				},
			],
			store:
			{
				autoLoad: true,
				pageSize: 50,
				restful: true,
				autoSync: false,
				proxy: {type: 'jsonp',url: 'https://localhost:1337/Справочники/КонсольОтчетов/ВыбратьПоСсылке/100', timeout: 200},
				fields:
				[
					{
						name:'Ссылка',
					},
					{
						name:'Поле',
					},
					{
						name:'Представление',
					},
					{
						name:'Формат',
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
						var грид = Ext.getCmp('Представления');
						var ссылка = грид.getView().getSelectionModel().getSelection()[0].data.Ссылка;
						var Хранилище = грид.store;
						var стрЗнач = Хранилище.findRecord('Ссылка', ссылка).data;
						Ext.require(['Справочники.КонсольОтчетов.ФормаРедактированияЗапросаСобытия'], function ()
						{
							var obj = Ext.create("Справочники.КонсольОтчетов.ФормаРедактированияЗапросаСобытия");
							obj.ПередатьСсылку(стрЗнач);
						});
					}
				}
			},
		},
					]
				},
				{
					id: 'ВыводОтчета',
					items:
					[
		{
			xtype: 'checkbox',
			id: 'ВыводВТаблицу',
			boxLabel: 'в таблицу',
			style: 'position:absolute;left:18px;top:28px;width:115px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'ВыводВТаблицу', Граница: 'Левая', Номер: 15, Координата: 0},
					Левая: { Элемент: '', Граница: 'Левая', Номер: 16, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Верхняя', Номер: 16, Координата: 0},
					Нижняя: { Элемент: 'ВыводВТаблицу', Граница: 'Верхняя', Номер: 15, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:115,
			Верх:28,
			Лево:18,
		},
		{
			xtype: 'fieldset',
			id: 'ВозможенВыводОтчета',
			title: 'Возможен вывод отчета',
			style: 'position:absolute;left:6px;top:6px;width:287px;height:120px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'ВозможенВыводОтчета', Граница: 'Левая', Номер: 16, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ВозможенВыводОтчета', Граница: 'Верхняя', Номер: 16, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:120,
			Ширина:287,
			Верх:6,
			Лево:6,
		},
		{
			xtype: 'checkbox',
			id: 'ВыводВДиаграмму',
			boxLabel: 'в диаграмму',
			style: 'position:absolute;left:18px;top:52px;width:115px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'ВыводВДиаграмму', Граница: 'Левая', Номер: 17, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ВыводВДиаграмму', Граница: 'Верхняя', Номер: 17, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:115,
			Верх:52,
			Лево:18,
		},
		{
			xtype: 'checkbox',
			id: 'ВыводВСводнуюТаблицу',
			boxLabel: 'в сводную таблицу',
			style: 'position:absolute;left:18px;top:76px;width:115px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'ВыводВСводнуюТаблицу', Граница: 'Левая', Номер: 18, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ВыводВСводнуюТаблицу', Граница: 'Верхняя', Номер: 18, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:115,
			Верх:76,
			Лево:18,
		},
		{
			xtype: 'label',
			id: 'Надпись2',
			text: 'По умолчанию выводить в:',
			style: 'position:absolute;left:6px;top:132px;width:137px;height:19px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Надпись2', Граница: 'Левая', Номер: 20, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Надпись2', Граница: 'Верхняя', Номер: 20, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:137,
			Верх:132,
			Лево:6,
		},
		{
			xtype: 'combobox',
			id: 'ПоУмолчаниюВыводитьВ',
			style: 'position:absolute;left:148px;top:132px;width:145px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:145,
			Верх:132,
			Лево:148,
			width: 145,
			height: 19,
		},
		{
			xtype: 'label',
			id: 'Надпись3',
			text: 'Отчет расшифровки:',
			style: 'position:absolute;left:6px;top:156px;width:137px;height:19px;text-align:left;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Надпись3', Граница: 'Левая', Номер: 22, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'Надпись3', Граница: 'Верхняя', Номер: 22, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:137,
			Верх:156,
			Лево:6,
		},
		{
			xtype: 'textfield',
			hideLabel: true,
			disabled: false,
			id: 'ОтчетРасшифровкиРедактор',
			width: 145,
			height: 19,
			style: 'position:absolute;left:148px;top:156px;width:145px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:145,
			Верх:156,
			Лево:148,
		},
		{
			xtype: 'checkbox',
			id: 'ВыводВСводДиаграмму',
			boxLabel: 'в сводную диаграмму',
			style: 'position:absolute;left:18px;top:100px;width:134px;height:19px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'ВыводВСводДиаграмму', Граница: 'Левая', Номер: 24, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: 'ВыводВСводДиаграмму', Граница: 'Верхняя', Номер: 24, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:19,
			Ширина:134,
			Верх:100,
			Лево:18,
		},
					]
				},
			]
		},
		{
			xtype: 'toolbar',
			id: 'КоманднаяПанель1',
			style: 'position:absolute;left:0px;top:285px;width:400px;height:24px;',
			Привязка:
			{
				Горизонтальная: false,
				Вертикальная: false,
				ОбъектПривязки: 
				{
					Правая: { Элемент: 'Форма', Граница: 'Правая', Номер: 0, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Нижняя', Номер: 8, Координата: 0},
					Нижняя: { Элемент: 'КоманднаяПанель1', Граница: 'Верхняя', Номер: 9, Координата: 0},
				},
				ОбъектПропорций: 
				{
					Правая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Левая: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Верхняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
					Нижняя: { Элемент: '', Граница: 'Пустая', Номер: -1, Координата: 0},
				},
			},
			Высота:24,
			Ширина:400,
			Верх:285,
			Лево:0,
			width: 400,
			height: 24,
			items:
			[
				{
					xtype: 'tbfill'
				},
				{
					id:'ОК',
					text:'ОК',
					tooltip:'ОК',
				},
				'-',
				{
					id:'Подменю',
					text:'Закрыть',
					tooltip:'Закрыть',
					iconCls:'x-Close',
					handler: function () {this.up('window').close();},
				},
				'-',
				{
					id:'Справка',
					text:'Справка',
					tooltip:'Открыть справку',
				},
			]
		},
		],
	}],
	dockedItems:
	[
	],
	listeners:
	{
		resize:
		{
			fn: function (win, width, height, opt)
			{
				var форма = win.down('form');
				if (!форма.ПервоеОткрытие)
				{
					форма.items.each(function (item)
					{
						//ПривязкаГраниц(item, item.ПозицияЭлемента);
						if (item.Групповой)
						{
							var элемент = Ext.getCmp(item.id).items.items[0].items.items;
							for (var i = 0; i < элемент.length; i++ ) 
							{
								var текЭлемент = элемент[i];
								//ПривязкаГраниц(текЭлемент, текЭлемент.ПозицияЭлемента);
							}
						}
					});
				}
				форма.ПервоеОткрытие = false;
			}
		}
	}
	});
});