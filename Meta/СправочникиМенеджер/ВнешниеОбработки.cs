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
	public partial class ВнешниеОбработки:СправочникМенеджер
	{

		public static СправочникиСсылка.ВнешниеОбработки НайтиПоКоду(string Код)
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
					,_Fld1994 [ХранилищеВнешнейОбработки]
					,_Fld1995RRef [ВидОбработки]
					,_Fld1996 [Комментарий]
					,_Fld1997 [КомментарийКФайлуИсточнику]
					From _Reference68(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВнешниеОбработки();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ВидОбработки = V82.Перечисления/*Ссылка*/.ВидыДополнительныхВнешнихОбработок.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.Комментарий = Читалка.GetString(8);
							Ссылка.КомментарийКФайлуИсточнику = Читалка.GetString(9);
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

		public static СправочникиВыборка.ВнешниеОбработки Выбрать()
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
					,_Fld1994 [ХранилищеВнешнейОбработки]
					,_Fld1995RRef [ВидОбработки]
					,_Fld1996 [Комментарий]
					,_Fld1997 [КомментарийКФайлуИсточнику]
							From _Reference68(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ВнешниеОбработки();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ВнешниеОбработки();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.ВидОбработки = V82.Перечисления/*Ссылка*/.ВидыДополнительныхВнешнихОбработок.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.Комментарий = Читалка.GetString(8);
							Ссылка.КомментарийКФайлуИсточнику = Читалка.GetString(9);
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.ВнешниеОбработки СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ВнешниеОбработки();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Комментарий = "";
			Объект.КомментарийКФайлуИсточнику = "";
			Объект.ВидОбработки = V82.Перечисления/*Ссылка*/.ВидыДополнительныхВнешнихОбработок.ПустаяСсылка;
			return Объект;
		}
	}
}
