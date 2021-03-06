﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.ДокументыСсылка;
using V82.Документы;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Документы//Менеджер
{
	public partial class ВосстановлениеНДСпоОбъектамНедвижимости:ДокументМенеджер
	{
		
		public static ДокументыСсылка.ВосстановлениеНДСпоОбъектамНедвижимости НайтиПоСсылке(Guid _Ссылка)
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
					,_Fld18534RRef [Организация]
					,_Fld18535RRef [Ответственный]
					,_Fld18536 [Комментарий]
					,_Fld18537 [ОтражатьВосстановлениеВКнигеПродаж]
					,_Fld18538 [ОтражатьВНалоговомУчете]
					,_Fld18539RRef [СчетСписанияНДС]
					,_Fld18540RRef [СубконтоСписанияНДС1]
					,_Fld18541RRef [СубконтоСписанияНДС2]
					,_Fld18542RRef [СубконтоСписанияНДС3]
					,_Fld18543RRef [СчетСписанияНДСНУ]
					,_Fld18544RRef [СубконтоСписанияНДСНУ1]
					,_Fld18545RRef [СубконтоСписанияНДСНУ2]
					,_Fld18546RRef [СубконтоСписанияНДСНУ3]
					From _Document18532(NOLOCK)
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", _Ссылка);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВосстановлениеНДСпоОбъектамНедвижимости();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.ОтражатьВосстановлениеВКнигеПродаж = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
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
		
		public static ДокументыСсылка.ВосстановлениеНДСпоОбъектамНедвижимости НайтиПоНомеру(string Номер)
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
					,_Fld18534RRef [Организация]
					,_Fld18535RRef [Ответственный]
					,_Fld18536 [Комментарий]
					,_Fld18537 [ОтражатьВосстановлениеВКнигеПродаж]
					,_Fld18538 [ОтражатьВНалоговомУчете]
					,_Fld18539RRef [СчетСписанияНДС]
					,_Fld18540RRef [СубконтоСписанияНДС1]
					,_Fld18541RRef [СубконтоСписанияНДС2]
					,_Fld18542RRef [СубконтоСписанияНДС3]
					,_Fld18543RRef [СчетСписанияНДСНУ]
					,_Fld18544RRef [СубконтоСписанияНДСНУ1]
					,_Fld18545RRef [СубконтоСписанияНДСНУ2]
					,_Fld18546RRef [СубконтоСписанияНДСНУ3]
					From _Document18532(NOLOCK)
					Where _Number = @Номер";
					Команда.Parameters.AddWithValue("Номер", Номер);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВосстановлениеНДСпоОбъектамНедвижимости();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.ОтражатьВосстановлениеВКнигеПродаж = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
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
		
		public static ДокументыВыборка.ВосстановлениеНДСпоОбъектамНедвижимости Выбрать()
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
					,_Fld18534RRef [Организация]
					,_Fld18535RRef [Ответственный]
					,_Fld18536 [Комментарий]
					,_Fld18537 [ОтражатьВосстановлениеВКнигеПродаж]
					,_Fld18538 [ОтражатьВНалоговомУчете]
					,_Fld18539RRef [СчетСписанияНДС]
					,_Fld18540RRef [СубконтоСписанияНДС1]
					,_Fld18541RRef [СубконтоСписанияНДС2]
					,_Fld18542RRef [СубконтоСписанияНДС3]
					,_Fld18543RRef [СчетСписанияНДСНУ]
					,_Fld18544RRef [СубконтоСписанияНДСНУ1]
					,_Fld18545RRef [СубконтоСписанияНДСНУ2]
					,_Fld18546RRef [СубконтоСписанияНДСНУ3]
					From _Document18532(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ВосстановлениеНДСпоОбъектамНедвижимости();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВосстановлениеНДСпоОбъектамНедвижимости();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.ОтражатьВосстановлениеВКнигеПродаж = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ВосстановлениеНДСпоОбъектамНедвижимости ВыбратьПоСсылке(int Первые,Guid Мин,Guid Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld18534RRef [Организация]
					,_Fld18535RRef [Ответственный]
					,_Fld18536 [Комментарий]
					,_Fld18537 [ОтражатьВосстановлениеВКнигеПродаж]
					,_Fld18538 [ОтражатьВНалоговомУчете]
					,_Fld18539RRef [СчетСписанияНДС]
					,_Fld18540RRef [СубконтоСписанияНДС1]
					,_Fld18541RRef [СубконтоСписанияНДС2]
					,_Fld18542RRef [СубконтоСписанияНДС3]
					,_Fld18543RRef [СчетСписанияНДСНУ]
					,_Fld18544RRef [СубконтоСписанияНДСНУ1]
					,_Fld18545RRef [СубконтоСписанияНДСНУ2]
					,_Fld18546RRef [СубконтоСписанияНДСНУ3]
					From _Document18532(NOLOCK)
					Where _IDRRef between @Мин and @Макс
					Order by _IDRRef", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ВосстановлениеНДСпоОбъектамНедвижимости();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВосстановлениеНДСпоОбъектамНедвижимости();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.ОтражатьВосстановлениеВКнигеПродаж = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ВосстановлениеНДСпоОбъектамНедвижимости ВыбратьПоНомеру(int Первые,string Мин,string Макс)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = string.Format(@"Select top {0} 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_Fld18534RRef [Организация]
					,_Fld18535RRef [Ответственный]
					,_Fld18536 [Комментарий]
					,_Fld18537 [ОтражатьВосстановлениеВКнигеПродаж]
					,_Fld18538 [ОтражатьВНалоговомУчете]
					,_Fld18539RRef [СчетСписанияНДС]
					,_Fld18540RRef [СубконтоСписанияНДС1]
					,_Fld18541RRef [СубконтоСписанияНДС2]
					,_Fld18542RRef [СубконтоСписанияНДС3]
					,_Fld18543RRef [СчетСписанияНДСНУ]
					,_Fld18544RRef [СубконтоСписанияНДСНУ1]
					,_Fld18545RRef [СубконтоСписанияНДСНУ2]
					,_Fld18546RRef [СубконтоСписанияНДСНУ3]
					From _Document18532(NOLOCK)
					Where _Code between @Мин and @Макс
					Order by _Code", Первые);
					Команда.Parameters.AddWithValue("Мин", Мин);
					Команда.Parameters.AddWithValue("Макс", Макс);
					var Выборка = new V82.ДокументыВыборка.ВосстановлениеНДСпоОбъектамНедвижимости();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВосстановлениеНДСпоОбъектамНедвижимости();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.ОтражатьВосстановлениеВКнигеПродаж = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ВосстановлениеНДСпоОбъектамНедвижимости СтраницаПоСсылке(int Размер,int Номер)
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
					,_Fld18534RRef [Организация]
					,_Fld18535RRef [Ответственный]
					,_Fld18536 [Комментарий]
					,_Fld18537 [ОтражатьВосстановлениеВКнигеПродаж]
					,_Fld18538 [ОтражатьВНалоговомУчете]
					,_Fld18539RRef [СчетСписанияНДС]
					,_Fld18540RRef [СубконтоСписанияНДС1]
					,_Fld18541RRef [СубконтоСписанияНДС2]
					,_Fld18542RRef [СубконтоСписанияНДС3]
					,_Fld18543RRef [СчетСписанияНДСНУ]
					,_Fld18544RRef [СубконтоСписанияНДСНУ1]
					,_Fld18545RRef [СубконтоСписанияНДСНУ2]
					,_Fld18546RRef [СубконтоСписанияНДСНУ3]
					From _Document18532(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ВосстановлениеНДСпоОбъектамНедвижимости();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВосстановлениеНДСпоОбъектамНедвижимости();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.ОтражатьВосстановлениеВКнигеПродаж = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static ДокументыВыборка.ВосстановлениеНДСпоОбъектамНедвижимости СтраницаПоНомеру(int Размер,int Номер)
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
					,_Fld18534RRef [Организация]
					,_Fld18535RRef [Ответственный]
					,_Fld18536 [Комментарий]
					,_Fld18537 [ОтражатьВосстановлениеВКнигеПродаж]
					,_Fld18538 [ОтражатьВНалоговомУчете]
					,_Fld18539RRef [СчетСписанияНДС]
					,_Fld18540RRef [СубконтоСписанияНДС1]
					,_Fld18541RRef [СубконтоСписанияНДС2]
					,_Fld18542RRef [СубконтоСписанияНДС3]
					,_Fld18543RRef [СчетСписанияНДСНУ]
					,_Fld18544RRef [СубконтоСписанияНДСНУ1]
					,_Fld18545RRef [СубконтоСписанияНДСНУ2]
					,_Fld18546RRef [СубконтоСписанияНДСНУ3]
					From _Document18532(NOLOCK)";
					var Выборка = new V82.ДокументыВыборка.ВосстановлениеНДСпоОбъектамНедвижимости();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new ДокументыСсылка.ВосстановлениеНДСпоОбъектамНедвижимости();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ВерсияДанных =  Convert.ToBase64String(ПотокВерсии);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1;
							Ссылка.Комментарий = Читалка.GetString(5);
							Ссылка.ОтражатьВосстановлениеВКнигеПродаж = ((byte[])Читалка.GetValue(6))[0]==1;
							Ссылка.ОтражатьВНалоговомУчете = ((byte[])Читалка.GetValue(7))[0]==1;
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}
		
		public static V82.ДокументыОбъект.ВосстановлениеНДСпоОбъектамНедвижимости СоздатьЭлемент()
		{
			var Объект = new V82.ДокументыОбъект.ВосстановлениеНДСпоОбъектамНедвижимости();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.Комментарий = "";
			return Объект;
		}
	}
}