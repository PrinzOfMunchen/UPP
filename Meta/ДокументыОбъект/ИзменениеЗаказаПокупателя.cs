﻿
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	[ProtoContract]
	[DataContract]
	public partial class ИзменениеЗаказаПокупателя:ДокументОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		[DataMember]
		[ProtoMember(3)]
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(4)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public DateTime Дата {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public DateTime ПрефиксНомера {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*11*/ Номер {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public bool Проведен {get;set;}
		[DataMember]
		[ProtoMember(9)]
		public V82.ДокументыСсылка.ЗаказПокупателя ЗаказПокупателя {get;set;}//Заказ покупателя
		///<summary>
		///Любая дополнительная информация
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///Сумма в валюте документа, налоги включены согласно флагам
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public decimal/*(15.2)*/ СуммаДокумента {get;set;}//Сумма документа
		[DataMember]
		[ProtoMember(12)]
		public V82.СправочникиСсылка.ТипыЦенНоменклатуры ТипЦен {get;set;}//Тип цен
		[DataMember]
		[ProtoMember(13)]
		public bool УчитыватьНДС {get;set;}//Учитывать НДС
		[DataMember]
		[ProtoMember(14)]
		public bool СуммаВключаетНДС {get;set;}//Сумма включает НДС
		[DataMember]
		[ProtoMember(15)]
		public object СтруктурнаяЕдиница {get;set;}//Структурная единица
		///<summary>
		///Курс валюты взаиморасчетов по договору
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public decimal/*(10.4)*/ КурсВзаиморасчетов {get;set;}//Курс взаиморасчетов
		[DataMember]
		[ProtoMember(17)]
		public decimal/*(10)*/ КратностьВзаиморасчетов {get;set;}//Кратность взаиморасчетов
		[DataMember]
		[ProtoMember(18)]
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		[DataMember]
		[ProtoMember(19)]
		public decimal/*(15.2)*/ ИтогПлановаяСебестоимость {get;set;}//Итоговая плановая себестоимость в валюте управленческого учета
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(20)]
		public bool ИспользоватьПлановуюСебестоимость {get;set;}//Использовать плановую себестоимость
		[DataMember]
		[ProtoMember(21)]
		public V82.СправочникиСсылка.ИнформационныеКарты ДисконтнаяКарта {get;set;}//Дисконтная карта
		[DataMember]
		[ProtoMember(22)]
		public V82.СправочникиСсылка.Контрагенты Контрагент {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(23)]
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента {get;set;}//Договор контрагента
		[DataMember]
		[ProtoMember(24)]
		public V82.СправочникиСсылка.УсловияПродаж УсловиеПродаж {get;set;}//Условие продаж
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(25)]
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		///<summary>
		///(Упр)
		///</summary>
		[DataMember]
		[ProtoMember(26)]
		public V82.СправочникиСсылка.Подразделения Подразделение {get;set;}
		public void Записать()
		{
			//Установка блокировки элемента на горизантально масштабированный кластер.
			//Опционально введение тайм аута на запись одного и того же объекта, не чаще раза в 5-секунд. Защита от спама. упращение алгоритма блокировки.
			//Выделение сервиса для блокировки элемента и генерации кода
			//Выполнение операций контроля без обращений к sql-серверу.
			//Контроль конфликта блокировок.
			//Контроль загрузки булкинсертом гетерогенной коллекции.
			//Контроль уникальности кода для Документов.
			//Контроль уникальности номера для документов, в границах префикса.
			//Контроль владельца, он не может быть группой.
			//Контроль владельца он должен быть задан.
			//Контроль родителя он должен быть группой.
			//Контроль количества уровней, должен соотвествовать метаданным.
			//Контроль версии, объект не должен был быть записан перед чтением текущей записи, алгоритм версионника.
			//Контроль уникальности ссылки
			//Контроль зацикливания
			//Опционально контроль битых ссылок.
			//Соблюдейние транзакционности. ПередЗаписью. Открытие транзации. Валидации. ПриЗаписи. Фиксация транзакции. Информирование о записи элемента.
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Document19658(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Number
						,_Fld20055RRef
						,_Fld20056
						,_Fld20057
						,_Fld20058RRef
						,_Fld20059
						,_Fld20060
						,_Fld20062
						,_Fld20063
						,_Fld20064RRef
						,_Fld20065
						,_Fld20066
						,_Fld20067RRef
						,_Fld20068RRef
						,_Fld20069RRef
						,_Fld20070RRef
						,_Fld20071RRef
						,_Fld20072RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Номер
						,@ЗаказПокупателя
						,@Комментарий
						,@СуммаДокумента
						,@ТипЦен
						,@УчитыватьНДС
						,@СуммаВключаетНДС
						,@КурсВзаиморасчетов
						,@КратностьВзаиморасчетов
						,@Ответственный
						,@ИтогПлановаяСебестоимость
						,@ИспользоватьПлановуюСебестоимость
						,@ДисконтнаяКарта
						,@Контрагент
						,@ДоговорКонтрагента
						,@УсловиеПродаж
						,@Организация
						,@Подразделение)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Document19658
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_Number	= @Номер
						,_Fld20055RRef	= @ЗаказПокупателя
						,_Fld20056	= @Комментарий
						,_Fld20057	= @СуммаДокумента
						,_Fld20058RRef	= @ТипЦен
						,_Fld20059	= @УчитыватьНДС
						,_Fld20060	= @СуммаВключаетНДС
						,_Fld20062	= @КурсВзаиморасчетов
						,_Fld20063	= @КратностьВзаиморасчетов
						,_Fld20064RRef	= @Ответственный
						,_Fld20065	= @ИтогПлановаяСебестоимость
						,_Fld20066	= @ИспользоватьПлановуюСебестоимость
						,_Fld20067RRef	= @ДисконтнаяКарта
						,_Fld20068RRef	= @Контрагент
						,_Fld20069RRef	= @ДоговорКонтрагента
						,_Fld20070RRef	= @УсловиеПродаж
						,_Fld20071RRef	= @Организация
						,_Fld20072RRef	= @Подразделение
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Номер", Номер);
					Команда.Parameters.AddWithValue("ЗаказПокупателя", ЗаказПокупателя.Ссылка);
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("СуммаДокумента", СуммаДокумента);
					Команда.Parameters.AddWithValue("УчитыватьНДС", УчитыватьНДС);
					Команда.Parameters.AddWithValue("СуммаВключаетНДС", СуммаВключаетНДС);
					Команда.Parameters.AddWithValue("КурсВзаиморасчетов", КурсВзаиморасчетов);
					Команда.Parameters.AddWithValue("КратностьВзаиморасчетов", КратностьВзаиморасчетов);
					Команда.Parameters.AddWithValue("ИтогПлановаяСебестоимость", ИтогПлановаяСебестоимость);
					Команда.Parameters.AddWithValue("ИспользоватьПлановуюСебестоимость", ИспользоватьПлановуюСебестоимость);
					Команда.ExecuteNonQuery();
				}
			}
		}
		public void Удалить()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Delete _Document19658
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}