﻿Ext.define('Справочники.ИнформационныеКарты.ФормаЭлементаСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код','Наименование','Родитель','Родитель.Ссылка','Родитель.Представление','КодКарты','ВладелецКарты','ВидКарты','ВидКарты.Ссылка','ВидКарты.Представление','ТипКарты','ТипКарты.Ссылка','ТипКарты.Представление','ТипШтрихКода','ТипШтрихКода.Ссылка','ТипШтрихКода.Представление','ВидДисконтнойКарты','ВидДисконтнойКарты.Ссылка','ВидДисконтнойКарты.Представление',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/ИнформационныеКарты/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.ИнформационныеКарты.ФормаЭлемента'], function ()
				{
					var количество = хранилище.getCount();
					if (количество == 0)
					{
						var массивЗначений = строкаЗначений;
					}
					else
					{
						var массивЗначений = хранилище.data.items[0].data;
					};
					var окно = Ext.create('Справочники.ИнформационныеКарты.ФормаЭлемента',
					{
						Хранилище: массивЗначений.Родитель,
					});
					var форма = окно.down('form');
					форма.getForm().setValues(массивЗначений);
					if (окно)
					{
						окно.show();
						return окно;
					}
				});
			},
			scope: this
		});
	}
});