﻿Ext.define('Справочники.СпецификацииНоменклатуры.ФормаСписокСпецификацийНоменклатурыУправляемаяСобытия',
{
	ПередатьСсылку: function (строкаЗначений)
	{
		var ссылка = строкаЗначений.Ссылка;
		var хранилище = Ext.create('Ext.data.Store',
		{
			autoLoad: true,
			fields: ['Код','Наименование','Родитель','Родитель.Ссылка','Родитель.Представление','Состояние','Состояние.Ссылка','Состояние.Представление','ДатаУтверждения','ВидСпецификации','ВидСпецификации.Ссылка','ВидСпецификации.Представление','Активная','КодВерсии','Комментарий','Ответственный','Ответственный.Ссылка','Ответственный.Представление','ИспользоватьВозвратныеОтходы','ИспользоватьПараметрыВыпускаПродукции','ИспользоватьДокументацию','ИспользоватьВидНорматива','ИспользоватьВидВоспроизводства','ИспользоватьУказаниеНорматива','ИспользоватьФормулы','ИспользоватьУправлениеСписанием','Назначение','Назначение.Ссылка','Назначение.Представление',],
			proxy: new Ext.data.ScriptTagProxy({ url: 'https://as-msk-n7077:1337/Справочники/СпецификацииНоменклатуры/НайтиПоСсылке/' + ссылка, timeout:200}),
		});
		хранилище.load(
		{
			callback: function (records, operation, success)
			{
				Ext.require(['Справочники.СпецификацииНоменклатуры.ФормаЭлемента'], function ()
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
					var окно = Ext.create('Справочники.СпецификацииНоменклатуры.ФормаЭлемента',
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