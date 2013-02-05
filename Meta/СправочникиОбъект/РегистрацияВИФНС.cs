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
	public partial class РегистрацияВИФНС:СправочникОбъект
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
		public string/*4*/ Код;
		public string/*50*/ Наименование;
		///<summary>
		///Код причины постановки
		///</summary>
		public string/*(9)*/ КПП;
		public string/*(254)*/ НаименованиеИФНС;//Наименование ИФНС
		///<summary>
		///Представитель в территориальном органе ФНС
		///</summary>
		public object Представитель;
		///<summary>
		///Название документа, подтверждающего полномочия представителя
		///</summary>
		public string/*(1000)*/ ДокументПредставителя;//Документ представителя
		public string/*(0)*/ УполномоченноеЛицоПредставителя;//Уполномоченное лицо представителя
		///<summary>
		///Доверенность налогоплательщика на представителя
		///</summary>
		public V82.СправочникиСсылка.ДоверенностиНалогоплательщика Доверенность;
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
						Insert Into _Reference219(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld3366
						,_Fld3367
						,_Fld3369
						,_Fld3370
						,_Fld3371RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@КПП
						,@НаименованиеИФНС
						,@ДокументПредставителя
						,@УполномоченноеЛицоПредставителя
						,@Доверенность)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference219
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld3366	= @КПП
						,_Fld3367	= @НаименованиеИФНС
						,_Fld3369	= @ДокументПредставителя
						,_Fld3370	= @УполномоченноеЛицоПредставителя
						,_Fld3371RRef	= @Доверенность
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("КПП", КПП);
					Команда.Parameters.AddWithValue("НаименованиеИФНС", НаименованиеИФНС);
					Команда.Parameters.AddWithValue("ДокументПредставителя", ДокументПредставителя);
					Команда.Parameters.AddWithValue("УполномоченноеЛицоПредставителя", УполномоченноеЛицоПредставителя);
					Команда.Parameters.AddWithValue("Доверенность", Доверенность.Ссылка);
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
					Команда.CommandText = @"Delete _Reference219
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*ОбменДанными.Загрузка*/)
			{
			}
			//флЭтоПБОЮЛ = РегламентированнаяОтчетность.ЭтоПБОЮЛ(Владелец);
			if(true/*ПустаяСтрока(Код)*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("Не задан код налогового органа.", Отказ);
			}
			if(true/*НЕ флЭтоПБОЮЛ*/)
			{
				if(true/*ПустаяСтрока(КПП)*/)
				{
					//ОбщегоНазначения.СообщитьОбОшибке("Не заполнен КПП.", Отказ);
				}
			}
			//СуществующаяЗапись = РегламентированнаяОтчетность.ПолучитьПоКодамРегистрациюВИФНС(Владелец, Код, КПП);
			if(true/*СуществующаяЗапись <> Неопределено И СуществующаяЗапись <> Ссылка*/)
			{
				/*ОбщегоНазначения.СообщитьОбОшибке("Для данной организации уже существует запись с указанными кодом налогового органа" 
		+ ?(флЭтоПБОЮЛ, ".", " и КПП."), Отказ);*/
			}
			if(true/*ПустаяСтрока(НаименованиеИФНС)*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("Не заполнено полное наименование налогового органа.", Отказ);
			}
			if(true/*ЗначениеЗаполнено(Представитель) И ПустаяСтрока(ДокументПредставителя)*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("Не задан документ, подтверждающий полномочия представителя.", Отказ);
			}
			if(true/*НЕ Отказ*/)
			{
				if(true/*ПустаяСтрока(Наименование)*/)
				{
					//Наименование = НаименованиеИФНС;
				}
				if(true/*НЕ ЗначениеЗаполнено(Представитель)*/)
				{
					//ДокументПредставителя = "";
					//УполномоченноеЛицоПредставителя = "";
				}
			}
		}
	}
}
