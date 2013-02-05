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
	///<summary>
	///(Упр)
	///</summary>
	public partial class ТипыСкидокНаценок:СправочникМенеджер
	{

		public static СправочникиСсылка.ТипыСкидокНаценок НайтиПоКоду(string Код)
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
					,_Fld3946RRef [Валюта]
					,_Fld3947 [ДляВсейНоменклатуры]
					,_Fld3948 [ПроцентСкидкиНаценки]
					,_Fld3949_TYPE [ЗначениеУсловия_Тип],_Fld3949_RRRef [ЗначениеУсловия],_Fld3949_RTRef [ЗначениеУсловия_Вид]
					,_Fld3950 [ОбщееВремяНачала]
					,_Fld3951 [ОбщееВремяОкончания]
					,_Fld3952 [ОграничениеСкидкиНаценки]
					,_Fld3953RRef [Условие]
					,_Fld3954RRef [Качество]
					,_Fld3955 [ДляВсехПолучателей]
					,_Fld3956 [ПоДнямНедели]
					,_Fld3957RRef [ВидСкидки]
					From _Reference268(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыСкидокНаценок();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Валюта = new V82.СправочникиСсылка.Валюты((byte[])Читалка.GetValue(6));
							Ссылка.ДляВсейНоменклатуры = ((byte[])Читалка.GetValue(7))[0]==1?true:false;
							Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(8);
							Ссылка.ОбщееВремяНачала = Читалка.GetDateTime(12);
							Ссылка.ОбщееВремяОкончания = Читалка.GetDateTime(13);
							Ссылка.ОграничениеСкидкиНаценки = Читалка.GetDecimal(14);
							Ссылка.Условие = V82.Перечисления/*Ссылка*/.УсловияСкидкиНаценки.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							//Ссылка.Качество = new V82.СправочникиСсылка.Качество((byte[])Читалка.GetValue(16));
							Ссылка.ДляВсехПолучателей = ((byte[])Читалка.GetValue(17))[0]==1?true:false;
							Ссылка.ПоДнямНедели = ((byte[])Читалка.GetValue(18))[0]==1?true:false;
							Ссылка.ВидСкидки = V82.Перечисления/*Ссылка*/.ВидыСкидок.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
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

		public static СправочникиВыборка.ТипыСкидокНаценок Выбрать()
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
					,_Fld3946RRef [Валюта]
					,_Fld3947 [ДляВсейНоменклатуры]
					,_Fld3948 [ПроцентСкидкиНаценки]
					,_Fld3949_TYPE [ЗначениеУсловия_Тип],_Fld3949_RRRef [ЗначениеУсловия],_Fld3949_RTRef [ЗначениеУсловия_Вид]
					,_Fld3950 [ОбщееВремяНачала]
					,_Fld3951 [ОбщееВремяОкончания]
					,_Fld3952 [ОграничениеСкидкиНаценки]
					,_Fld3953RRef [Условие]
					,_Fld3954RRef [Качество]
					,_Fld3955 [ДляВсехПолучателей]
					,_Fld3956 [ПоДнямНедели]
					,_Fld3957RRef [ВидСкидки]
							From _Reference268(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ТипыСкидокНаценок();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ТипыСкидокНаценок();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							//Ссылка.Валюта = new V82.СправочникиСсылка.Валюты((byte[])Читалка.GetValue(6));
							Ссылка.ДляВсейНоменклатуры = ((byte[])Читалка.GetValue(7))[0]==1?true:false;
							Ссылка.ПроцентСкидкиНаценки = Читалка.GetDecimal(8);
							Ссылка.ОбщееВремяНачала = Читалка.GetDateTime(12);
							Ссылка.ОбщееВремяОкончания = Читалка.GetDateTime(13);
							Ссылка.ОграничениеСкидкиНаценки = Читалка.GetDecimal(14);
							Ссылка.Условие = V82.Перечисления/*Ссылка*/.УсловияСкидкиНаценки.ПустаяСсылка.Получить((byte[])Читалка.GetValue(15));
							//Ссылка.Качество = new V82.СправочникиСсылка.Качество((byte[])Читалка.GetValue(16));
							Ссылка.ДляВсехПолучателей = ((byte[])Читалка.GetValue(17))[0]==1?true:false;
							Ссылка.ПоДнямНедели = ((byte[])Читалка.GetValue(18))[0]==1?true:false;
							Ссылка.ВидСкидки = V82.Перечисления/*Ссылка*/.ВидыСкидок.ПустаяСсылка.Получить((byte[])Читалка.GetValue(19));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.ТипыСкидокНаценок СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ТипыСкидокНаценок();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Валюта = new V82.СправочникиСсылка.Валюты();
			Объект.Условие = V82.Перечисления/*Ссылка*/.УсловияСкидкиНаценки.ПустаяСсылка;
			Объект.Качество = new V82.СправочникиСсылка.Качество();
			Объект.ВидСкидки = V82.Перечисления/*Ссылка*/.ВидыСкидок.ПустаяСсылка;
			return Объект;
		}
	}
}
