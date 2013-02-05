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
	public partial class ПоказателиСхемМотивации:СправочникМенеджер
	{


		public static СправочникиВыборка.ПоказателиСхемМотивации Выбрать()
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
					,_Description [Наименование]
					,_Fld3222RRef [ТипПоказателя]
					,_Fld3223RRef [ВозможностьИзменения]
					,_Fld3224RRef [ВидПоказателя]
					,_Fld3225 [ПоказательЭффективности]
					,_Fld3226 [Идентификатор]
					,_Fld3227 [ТарифнаяСтавка]
					,_Fld3228RRef [ФактическийПоказатель]
					,_Fld3229RRef [СпособРасчетаСуммы]
					,_Fld3230RRef [СуммируемыйПоказатель]
					,_Fld3231RRef [Валюта]
					,_Fld3232RRef [ВидСтажа]
							From _Reference194(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.ПоказателиСхемМотивации();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.ПоказателиСхемМотивации();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Наименование = Читалка.GetString(4);
							Ссылка.ТипПоказателя = V82.Перечисления/*Ссылка*/.ТипыПоказателейСхемМотивации.ПустаяСсылка.Получить((byte[])Читалка.GetValue(5));
							Ссылка.ВозможностьИзменения = V82.Перечисления/*Ссылка*/.ИзменениеПоказателейСхемМотивации.ПустаяСсылка.Получить((byte[])Читалка.GetValue(6));
							Ссылка.ВидПоказателя = V82.Перечисления/*Ссылка*/.ВидыПоказателейСхемМотивации.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.ПоказательЭффективности = ((byte[])Читалка.GetValue(8))[0]==1?true:false;
							Ссылка.Идентификатор = Читалка.GetString(9);
							Ссылка.ТарифнаяСтавка = ((byte[])Читалка.GetValue(10))[0]==1?true:false;
							//Ссылка.ФактическийПоказатель = new V82.СправочникиСсылка.ПоказателиСхемМотивации((byte[])Читалка.GetValue(11));
							Ссылка.СпособРасчетаСуммы = V82.Перечисления/*Ссылка*/.СпособыРасчетаСуммыПоказателей.ПустаяСсылка.Получить((byte[])Читалка.GetValue(12));
							//Ссылка.СуммируемыйПоказатель = new V82.СправочникиСсылка.ПоказателиСхемМотивации((byte[])Читалка.GetValue(13));
							//Ссылка.Валюта = new V82.СправочникиСсылка.Валюты((byte[])Читалка.GetValue(14));
							//Ссылка.ВидСтажа = new V82.СправочникиСсылка.ВидыСтажа((byte[])Читалка.GetValue(15));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.ПоказателиСхемМотивации СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.ПоказателиСхемМотивации();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Идентификатор = "";
			Объект.ТипПоказателя = V82.Перечисления/*Ссылка*/.ТипыПоказателейСхемМотивации.ПустаяСсылка;
			Объект.ВозможностьИзменения = V82.Перечисления/*Ссылка*/.ИзменениеПоказателейСхемМотивации.ПустаяСсылка;
			Объект.ВидПоказателя = V82.Перечисления/*Ссылка*/.ВидыПоказателейСхемМотивации.ПустаяСсылка;
			Объект.ФактическийПоказатель = new V82.СправочникиСсылка.ПоказателиСхемМотивации();
			Объект.СпособРасчетаСуммы = V82.Перечисления/*Ссылка*/.СпособыРасчетаСуммыПоказателей.ПустаяСсылка;
			Объект.СуммируемыйПоказатель = new V82.СправочникиСсылка.ПоказателиСхемМотивации();
			Объект.Валюта = new V82.СправочникиСсылка.Валюты();
			Объект.ВидСтажа = new V82.СправочникиСсылка.ВидыСтажа();
			return Объект;
		}
	}
}
