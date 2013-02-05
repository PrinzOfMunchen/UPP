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
	public partial class НастройкиВыполненияОбмена:СправочникМенеджер
	{

		public static СправочникиСсылка.НастройкиВыполненияОбмена НайтиПоКоду(string Код)
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
					,_Fld2647 [ВыполнятьДействияПодПолнымиПравами]
					,_Fld2648 [ИспользоватьРегламентныеЗадания]
					,_Fld2649 [ДинамическиИзменятьИнтервалМеждуОбменами]
					,_Fld2650RRef [Ответственный]
					,_Fld2651 [КаждыйЗапускПрограммы]
					,_Fld2652 [КаждоеЗавершениеРаботыСПрограммой]
					,_Fld2653 [КаталогПроверкиДоступности]
					,_Fld2654 [ВыполнятьОбменПриПоявленииФайла]
					,_Fld2655 [КоличествоЭлементовВТранзакцииНаВыгрузкуДанных]
					,_Fld2656 [КоличествоЭлементовВТранзакцииНаЗагрузкуДанных]
					,_Fld2657RRef [УчетнаяЗаписьОтправкиСообщенияОбОшибке]
					,_Fld2658 [АдресДляОтправкиСообщенийОбОшибке]
					,_Fld2659 [Комментарий]
					,_Fld2660 [РегламентноеЗадание]
					From _Reference149(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиВыполненияОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ВыполнятьДействияПодПолнымиПравами = ((byte[])Читалка.GetValue(6))[0]==1?true:false;
							Ссылка.ИспользоватьРегламентныеЗадания = ((byte[])Читалка.GetValue(7))[0]==1?true:false;
							Ссылка.ДинамическиИзменятьИнтервалМеждуОбменами = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							//Ссылка.Ответственный = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(9));
							Ссылка.КаждыйЗапускПрограммы = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Ссылка.КаждоеЗавершениеРаботыСПрограммой = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Ссылка.КаталогПроверкиДоступности = Читалка.GetString(12);
							Ссылка.ВыполнятьОбменПриПоявленииФайла = Читалка.GetString(13);
							Ссылка.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = Читалка.GetDecimal(14);
							Ссылка.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = Читалка.GetDecimal(15);
							//Ссылка.УчетнаяЗаписьОтправкиСообщенияОбОшибке = new V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты((byte[])Читалка.GetValue(16));
							Ссылка.АдресДляОтправкиСообщенийОбОшибке = Читалка.GetString(17);
							Ссылка.Комментарий = Читалка.GetString(18);
							Ссылка.РегламентноеЗадание = Читалка.GetString(19);
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

		public static СправочникиВыборка.НастройкиВыполненияОбмена Выбрать()
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
					,_Fld2647 [ВыполнятьДействияПодПолнымиПравами]
					,_Fld2648 [ИспользоватьРегламентныеЗадания]
					,_Fld2649 [ДинамическиИзменятьИнтервалМеждуОбменами]
					,_Fld2650RRef [Ответственный]
					,_Fld2651 [КаждыйЗапускПрограммы]
					,_Fld2652 [КаждоеЗавершениеРаботыСПрограммой]
					,_Fld2653 [КаталогПроверкиДоступности]
					,_Fld2654 [ВыполнятьОбменПриПоявленииФайла]
					,_Fld2655 [КоличествоЭлементовВТранзакцииНаВыгрузкуДанных]
					,_Fld2656 [КоличествоЭлементовВТранзакцииНаЗагрузкуДанных]
					,_Fld2657RRef [УчетнаяЗаписьОтправкиСообщенияОбОшибке]
					,_Fld2658 [АдресДляОтправкиСообщенийОбОшибке]
					,_Fld2659 [Комментарий]
					,_Fld2660 [РегламентноеЗадание]
							From _Reference149(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиВыполненияОбмена();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиВыполненияОбмена();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ВыполнятьДействияПодПолнымиПравами = ((byte[])Читалка.GetValue(6))[0]==1?true:false;
							Ссылка.ИспользоватьРегламентныеЗадания = ((byte[])Читалка.GetValue(7))[0]==1?true:false;
							Ссылка.ДинамическиИзменятьИнтервалМеждуОбменами = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							//Ссылка.Ответственный = new V82.СправочникиСсылка.Пользователи((byte[])Читалка.GetValue(9));
							Ссылка.КаждыйЗапускПрограммы = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							Ссылка.КаждоеЗавершениеРаботыСПрограммой = ((byte[])Читалка.GetValue(11))[0]==1?true:false;
							Ссылка.КаталогПроверкиДоступности = Читалка.GetString(12);
							Ссылка.ВыполнятьОбменПриПоявленииФайла = Читалка.GetString(13);
							Ссылка.КоличествоЭлементовВТранзакцииНаВыгрузкуДанных = Читалка.GetDecimal(14);
							Ссылка.КоличествоЭлементовВТранзакцииНаЗагрузкуДанных = Читалка.GetDecimal(15);
							//Ссылка.УчетнаяЗаписьОтправкиСообщенияОбОшибке = new V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты((byte[])Читалка.GetValue(16));
							Ссылка.АдресДляОтправкиСообщенийОбОшибке = Читалка.GetString(17);
							Ссылка.Комментарий = Читалка.GetString(18);
							Ссылка.РегламентноеЗадание = Читалка.GetString(19);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.НастройкиВыполненияОбмена СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиВыполненияОбмена();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.КаталогПроверкиДоступности = "";
			Объект.ВыполнятьОбменПриПоявленииФайла = "";
			Объект.АдресДляОтправкиСообщенийОбОшибке = "";
			Объект.Комментарий = "";
			Объект.РегламентноеЗадание = "";
			Объект.Ответственный = new V82.СправочникиСсылка.Пользователи();
			Объект.УчетнаяЗаписьОтправкиСообщенияОбОшибке = new V82.СправочникиСсылка.УчетныеЗаписиЭлектроннойПочты();
			return Объект;
		}
	}
}
