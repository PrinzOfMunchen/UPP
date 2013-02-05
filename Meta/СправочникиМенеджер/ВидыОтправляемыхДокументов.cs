﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	public partial class ВидыОтправляемыхДокументов:СправочникМенеджер
	{

		public static СправочникиСсылка.ВидыОтправляемыхДокументов НайтиПоКоду(string Код)
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
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1960 [Описание]
					,_Fld1961 [Источник]
					,_Fld1962RRef [ТипПолучателя]
					,_Fld1963RRef [ТипДокумента]
					From _Reference60(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВидыОтправляемыхДокументов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Описание = Читалка.GetString(6);
							Ссылка.Источник = Читалка.GetString(7);
							Ссылка.ТипПолучателя = V82.Перечисления/*Ссылка*/.ТипыКонтролирующихОрганов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ТипДокумента = V82.Перечисления/*Ссылка*/.ТипыОтправляемыхДокументов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}

		public static СправочникиВыборка.ВидыОтправляемыхДокументов Выбрать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld1960 [Описание]
					,_Fld1961 [Источник]
					,_Fld1962RRef [ТипПолучателя]
					,_Fld1963RRef [ТипДокумента]
							From _Reference60(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ВидыОтправляемыхДокументов();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВидыОтправляемыхДокументов();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Описание = Читалка.GetString(6);
							Ссылка.Источник = Читалка.GetString(7);
							Ссылка.ТипПолучателя = V82.Перечисления/*Ссылка*/.ТипыКонтролирующихОрганов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.ТипДокумента = V82.Перечисления/*Ссылка*/.ТипыОтправляемыхДокументов.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.ВидыОтправляемыхДокументов СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ВидыОтправляемыхДокументов();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Описание = "";
			Объект.Источник = "";
			Объект.ТипПолучателя = V82.Перечисления/*Ссылка*/.ТипыКонтролирующихОрганов.ПустаяСсылка;
			Объект.ТипДокумента = V82.Перечисления/*Ссылка*/.ТипыОтправляемыхДокументов.ПустаяСсылка;
			return Объект;
		}
	}
}
