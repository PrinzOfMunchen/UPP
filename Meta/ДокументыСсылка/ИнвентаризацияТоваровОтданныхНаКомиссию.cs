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
using V82.ДокументыСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыСсылка
{
	///<summary>
	///(Упр)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ИнвентаризацияТоваровОтданныхНаКомиссию:ДокументСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("8a78d3d5-a082-46ea-81e8-d3e8ec5e44a3");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20120928012007.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
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
		public DateTime Дата {get;set;}
		public DateTime ПрефиксНомера {get;set;}
		public string/*11*/ Номер {get;set;}
		public bool Проведен {get;set;}
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		public V82.СправочникиСсылка.Контрагенты Контрагент {get;set;}
		public V82.СправочникиСсылка.ДоговорыКонтрагентов ДоговорКонтрагента {get;set;}//Договор контрагента
		public V82.СправочникиСсылка.Подразделения Подразделение {get;set;}
		///<summary>
		///Любая дополнительная информация
		///</summary>
		public string/*(0)*/ Комментарий {get;set;}
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		public object Сделка {get;set;}
		
		public ИнвентаризацияТоваровОтданныхНаКомиссию()
		{
		}
		
		public ИнвентаризацияТоваровОтданныхНаКомиссию(byte[] УникальныйИдентификатор)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Number [Номер]
					,_Fld5180RRef [Организация]
					,_Fld5181RRef [Контрагент]
					,_Fld5182RRef [ДоговорКонтрагента]
					,_Fld5183RRef [Подразделение]
					,_Fld5184 [Комментарий]
					,_Fld5185RRef [Ответственный]
					,_Fld5186_TYPE [Сделка_Тип],_Fld5186_RRRef [Сделка],_Fld5186_RTRef [Сделка_Вид]
					From _Document291(NOLOCK)
					Where _IDRRef=@УникальныйИдентификатор";
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
							Номер = Читалка.GetString(3);
							Комментарий = Читалка.GetString(8);
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
		
		public V82.ДокументыОбъект.ИнвентаризацияТоваровОтданныхНаКомиссию  ПолучитьОбъект()
		{
			var Объект = new V82.ДокументыОбъект.ИнвентаризацияТоваровОтданныхНаКомиссию();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Номер = Номер;
			Объект.Организация = Организация;
			Объект.Контрагент = Контрагент;
			Объект.ДоговорКонтрагента = ДоговорКонтрагента;
			Объект.Подразделение = Подразделение;
			Объект.Комментарий = Комментарий;
			Объект.Ответственный = Ответственный;
			Объект.Сделка = Сделка;
			return Объект;
		}
		
		private static readonly Hashtable Кэш = new Hashtable(1000);
		
		public static V82.ДокументыСсылка.ИнвентаризацияТоваровОтданныхНаКомиссию ВзятьИзКэша(byte[] УникальныйИдентификатор)
		{
			var УИ = new Guid(УникальныйИдентификатор);
			if (Кэш.ContainsKey(УИ))
			{
				return (V82.ДокументыСсылка.ИнвентаризацияТоваровОтданныхНаКомиссию)Кэш[УИ];
			}
			var Ссылка = new V82.ДокументыСсылка.ИнвентаризацияТоваровОтданныхНаКомиссию(УникальныйИдентификатор);
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