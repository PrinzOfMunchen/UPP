﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.СправочникиОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиОбъект
{
	public partial class ОтправкиФСС:СправочникОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		public Guid Ссылка;
		public long Версия;
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		public bool ПометкаУдаления;
		public bool Предопределенный;
		public Guid Владелец;
		public bool ЭтоГруппа;
		public Guid Родитель;
		public string/*9*/ Код;
		public string/*25*/ Наименование;
		public object ОтчетСсылка;//Ссылка на регламентированный отчет
		public string/*(100)*/ ИдентификаторОтправкиНаСервере;//Идентификатор отправки на сервере
		public ХранилищеЗначения ЗашифрованныйПакет;//Зашифрованный пакет выгрузки
		///<summary>
		///Имя файла зашифрованного пакета выгрузки
		///</summary>
		public string/*(100)*/ ИмяФайлаПакета;//Имя файла пакета
		public V82.Перечисления/*Ссылка*/.СтатусыОтправки СтатусОтправки;//Статус отправки
		///<summary>
		///Протокол обработки
		///</summary>
		public ХранилищеЗначения Протокол;//Протокол обработки
		public DateTime ДатаОтправки;//Дата отправки
		public DateTime ДатаПолученияРезультата;//Дата получения результата
		public V82.СправочникиСсылка.Организации Организация;
		public string/*(4)*/ КодОрганаФСС;//Код органа ФСС
		///<summary>
		///Квитанция успеха
		///</summary>
		public ХранилищеЗначения Квитанция;
		public void Записать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Reference184(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld3133
						,_Fld3134
						,_Fld3135
						,_Fld3136RRef
						,_Fld3137
						,_Fld3138
						,_Fld3139
						,_Fld3140RRef
						,_Fld3141
						,_Fld3142)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@ИдентификаторОтправкиНаСервере
						,@ЗашифрованныйПакет
						,@ИмяФайлаПакета
						,@СтатусОтправки
						,@Протокол
						,@ДатаОтправки
						,@ДатаПолученияРезультата
						,@Организация
						,@КодОрганаФСС
						,@Квитанция)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference184
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld3133	= @ИдентификаторОтправкиНаСервере
						,_Fld3134	= @ЗашифрованныйПакет
						,_Fld3135	= @ИмяФайлаПакета
						,_Fld3136RRef	= @СтатусОтправки
						,_Fld3137	= @Протокол
						,_Fld3138	= @ДатаОтправки
						,_Fld3139	= @ДатаПолученияРезультата
						,_Fld3140RRef	= @Организация
						,_Fld3141	= @КодОрганаФСС
						,_Fld3142	= @Квитанция
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("ИдентификаторОтправкиНаСервере", ИдентификаторОтправкиНаСервере);
					Команда.Parameters.AddWithValue("ИмяФайлаПакета", ИмяФайлаПакета);
					Команда.Parameters.AddWithValue("СтатусОтправки", СтатусОтправки.Ключ());
					Команда.Parameters.AddWithValue("ДатаОтправки", ДатаОтправки);
					Команда.Parameters.AddWithValue("ДатаПолученияРезультата", ДатаПолученияРезультата);
					Команда.Parameters.AddWithValue("Организация", Организация.Ссылка);
					Команда.Parameters.AddWithValue("КодОрганаФСС", КодОрганаФСС);
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
					Команда.CommandText = @"Delete _Reference184
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/

		public void ПриЗаписи(/**/)
		{
			//Оповестить("Изменение статуса отправки регламентированного отчета", СтатусОтправки, ОтчетСсылка);
		}
	}
}
