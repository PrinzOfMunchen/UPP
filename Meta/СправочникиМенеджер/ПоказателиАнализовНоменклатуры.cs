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
	public partial class ПоказателиАнализовНоменклатуры:СправочникМенеджер
	{

		public static СправочникиСсылка.ПоказателиАнализовНоменклатуры НайтиПоКоду(string Код)
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
					,_Fld3214RRef [ВидРезультатаАнализа]
					,_Fld3215 [МинЗначение]
					,_Fld3216 [МаксЗначение]
					,_Fld3217RRef [ЕдиницаИзмерения]
					From _Reference193(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ПоказателиАнализовНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.МинЗначение = Читалка.GetDecimal(7);
							Ссылка.МаксЗначение = Читалка.GetDecimal(8);
							//Ссылка.ЕдиницаИзмерения = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения((byte[])Читалка.GetValue(9));
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

		public static СправочникиВыборка.ПоказателиАнализовНоменклатуры Выбрать()
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
					,_Fld3214RRef [ВидРезультатаАнализа]
					,_Fld3215 [МинЗначение]
					,_Fld3216 [МаксЗначение]
					,_Fld3217RRef [ЕдиницаИзмерения]
							From _Reference193(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ПоказателиАнализовНоменклатуры();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ПоказателиАнализовНоменклатуры();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.МинЗначение = Читалка.GetDecimal(7);
							Ссылка.МаксЗначение = Читалка.GetDecimal(8);
							//Ссылка.ЕдиницаИзмерения = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения((byte[])Читалка.GetValue(9));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.ПоказателиАнализовНоменклатуры СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ПоказателиАнализовНоменклатуры();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.ЕдиницаИзмерения = new V82.СправочникиСсылка.КлассификаторЕдиницИзмерения();
			return Объект;
		}
	}
}
