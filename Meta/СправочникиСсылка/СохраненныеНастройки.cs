﻿
using System;
using System.Collections;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиСсылка
{
	[ProtoContract]
	[DataContract]
	public partial class СохраненныеНастройки:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("f9f2b5a1-8050-4cb5-bdaa-d5e15d3f3ca1");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928011955.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления {get;set;}
		public bool Предопределенный {get;set;}
		[DataMember(Name = "Представление")]//Проверить основное представление.
		[ProtoMember(3)]
		public string/*100*/ Наименование {get;set;}
		public V82.Перечисления/*Ссылка*/.ТипыНастроек ТипНастройки {get;set;}//Тип настройки
		public object НастраиваемыйОбъект {get;set;}//Настраиваемый объект
		public bool СохранятьАвтоматически {get;set;}//Сохранять автоматически
		public bool ИспользоватьПриОткрытии {get;set;}//Использовать при открытии
		public bool СохранятьПериод {get;set;}//Сохранять период
		public bool ОткрыватьПриЗапуске {get;set;}//Открывать при запуске
		public ХранилищеЗначения ХранилищеНастроек {get;set;}//Хранилище настроек
		public string/*(1000)*/ Описание {get;set;}
		public string/*(100)*/ КраткийСоставНастройки {get;set;}//Краткий состав настройки
		
		public СохраненныеНастройки()
		{
		}
		
		public СохраненныеНастройки(byte[] УникальныйИдентификатор)
			: this(УникальныйИдентификатор,0)
		{
		}
		
		public СохраненныеНастройки(byte[] УникальныйИдентификатор,int Глубина)
		{
			if (Глубина>3)
			{
				return;
			}
			if (new Guid(УникальныйИдентификатор) == Guid.Empty)
			{
				return;
			}
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Description [Наименование]
					,_Fld19877RRef [ТипНастройки]
					,_Fld19878_TYPE [НастраиваемыйОбъект_Тип],_Fld19878_RRRef [НастраиваемыйОбъект],_Fld19878_RTRef [НастраиваемыйОбъект_Вид]
					,_Fld19879 [СохранятьАвтоматически]
					,_Fld19880 [ИспользоватьПриОткрытии]
					,_Fld19881 [СохранятьПериод]
					,_Fld19882 [ОткрыватьПриЗапуске]
					,_Fld19883 [ХранилищеНастроек]
					,_Fld19884 [Описание]
					,_Fld26609 [КраткийСоставНастройки]
					From _Reference19651(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор  ";
					Команда.Parameters.AddWithValue("УникальныйИдентификатор", УникальныйИдентификатор);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							//ToDo: Читать нужно через GetValues()
							Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1;
							Наименование = Читалка.GetString(4);
								ТипНастройки = V82.Перечисления/*Ссылка*/.ТипыНастроек.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
								СохранятьАвтоматически = ((byte[])Читалка.GetValue(9))[0]==1;
								ИспользоватьПриОткрытии = ((byte[])Читалка.GetValue(10))[0]==1;
								СохранятьПериод = ((byte[])Читалка.GetValue(11))[0]==1;
								ОткрыватьПриЗапуске = ((byte[])Читалка.GetValue(12))[0]==1;
								Описание = Читалка.GetString(14);
								КраткийСоставНастройки = Читалка.GetString(15);
							//return Ссылка;
						}
						else
						{
							//return null;
						}
					}
				}
			}
		}
		
		public V82.СправочникиОбъект.СохраненныеНастройки  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.СохраненныеНастройки();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Наименование = Наименование;
			Объект.ТипНастройки = ТипНастройки;
			Объект.НастраиваемыйОбъект = НастраиваемыйОбъект;
			Объект.СохранятьАвтоматически = СохранятьАвтоматически;
			Объект.ИспользоватьПриОткрытии = ИспользоватьПриОткрытии;
			Объект.СохранятьПериод = СохранятьПериод;
			Объект.ОткрыватьПриЗапуске = ОткрыватьПриЗапуске;
			Объект.ХранилищеНастроек = ХранилищеНастроек;
			Объект.Описание = Описание;
			Объект.КраткийСоставНастройки = КраткийСоставНастройки;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.СправочникиСсылка.СохраненныеНастройки ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.СправочникиСсылка.СохраненныеНастройки)Кэш[УИ];
			}
			var Ссылка = new V82.СправочникиСсылка.СохраненныеНастройки(УникальныйИдентификатор);
			Кэш.Add(УИ, Ссылка);
			return Ссылка;
		}
		
		public void СериализацияProtoBuf(Stream Поток)
		{
			Serializer.Serialize(Поток,this);
		}
		
		public string СериализацияJson()
		{
			return this.ToJson();
		}
		
		public string СериализацияXml()
		{
			return this.ToXml();
		}
	}
}