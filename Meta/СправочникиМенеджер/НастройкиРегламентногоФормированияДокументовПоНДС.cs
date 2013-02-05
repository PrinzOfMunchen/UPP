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
	public partial class НастройкиРегламентногоФормированияДокументовПоНДС:СправочникМенеджер
	{

		public static СправочникиСсылка.НастройкиРегламентногоФормированияДокументовПоНДС НайтиПоКоду(string Код)
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
					,_Fld2845RRef [Организация]
					,_Fld2846 [РегламентноеЗадание]
					,_Fld2847 [Комментарий]
					,_Fld2848 [ФормироватьДокументыАвтоматически]
					From _Reference157(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиРегламентногоФормированияДокументовПоНДС();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(6));
							Ссылка.РегламентноеЗадание = Читалка.GetString(7);
							Ссылка.Комментарий = Читалка.GetString(8);
							Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
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

		public static СправочникиВыборка.НастройкиРегламентногоФормированияДокументовПоНДС Выбрать()
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
					,_Fld2845RRef [Организация]
					,_Fld2846 [РегламентноеЗадание]
					,_Fld2847 [Комментарий]
					,_Fld2848 [ФормироватьДокументыАвтоматически]
							From _Reference157(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.НастройкиРегламентногоФормированияДокументовПоНДС();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.НастройкиРегламентногоФормированияДокументовПоНДС();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Организация = new V82.СправочникиСсылка.Организации((byte[])Читалка.GetValue(6));
							Ссылка.РегламентноеЗадание = Читалка.GetString(7);
							Ссылка.Комментарий = Читалка.GetString(8);
							Ссылка.ФормироватьДокументыАвтоматически = ((byte[])Читалка.GetValue(9))[0]==1?true:false;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.НастройкиРегламентногоФормированияДокументовПоНДС СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.НастройкиРегламентногоФормированияДокументовПоНДС();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.РегламентноеЗадание = "";
			Объект.Комментарий = "";
			Объект.Организация = new V82.СправочникиСсылка.Организации();
			return Объект;
		}
	}
}
