﻿Ext.define('Справочники.БанковскиеСчета.ФормаВыбораСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код','Наименование','НомерСчета','Банк','Банк.Ссылка','Банк.Представление','БанкДляРасчетов','БанкДляРасчетов.Ссылка','БанкДляРасчетов.Представление','ТекстКорреспондента','ТекстНазначения','ВидСчета','ВалютаДенежныхСредств','ВалютаДенежныхСредств.Ссылка','ВалютаДенежныхСредств.Представление','НомерИДатаРазрешения','ДатаОткрытия','ДатаЗакрытия','МесяцПрописью','СуммаБезКопеек',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/БанковскиеСчета/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.БанковскиеСчета.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.БанковскиеСчета.ФормаЭлемента',
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