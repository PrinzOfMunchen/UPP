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
	public partial class Вакансии:СправочникОбъект
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
		public string/*100*/ Наименование;
		public bool Закрыта;//Вакансия закрыта
		public V82.СправочникиСсылка.Должности Должность;
		public V82.СправочникиСсылка.Пользователи Заявитель;
		public string/*(0)*/ Обязанности;
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.Пользователи Ответственный;//Ответственный за вакансию
		public DateTime ПлановаяДатаЗакрытия;//Плановая дата закрытия
		public object Подразделение;
		public string/*(0)*/ Требования;
		public string/*(0)*/ Условия;
		public DateTime ДатаОткрытия;//Дата открытия
		public DateTime ДатаЗакрытия;//Дата закрытия
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
						Insert Into _Reference39(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Code
						,_Description
						,_Fld1872
						,_Fld1873RRef
						,_Fld1874RRef
						,_Fld1875
						,_Fld1876RRef
						,_Fld1877RRef
						,_Fld1878
						,_Fld1880
						,_Fld1881
						,_Fld1882
						,_Fld1883)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Код
						,@Наименование
						,@Закрыта
						,@Должность
						,@Заявитель
						,@Обязанности
						,@Организация
						,@Ответственный
						,@ПлановаяДатаЗакрытия
						,@Требования
						,@Условия
						,@ДатаОткрытия
						,@ДатаЗакрытия)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference39
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld1872	= @Закрыта
						,_Fld1873RRef	= @Должность
						,_Fld1874RRef	= @Заявитель
						,_Fld1875	= @Обязанности
						,_Fld1876RRef	= @Организация
						,_Fld1877RRef	= @Ответственный
						,_Fld1878	= @ПлановаяДатаЗакрытия
						,_Fld1880	= @Требования
						,_Fld1881	= @Условия
						,_Fld1882	= @ДатаОткрытия
						,_Fld1883	= @ДатаЗакрытия
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("Закрыта", Закрыта);
					Команда.Parameters.AddWithValue("Должность", Должность.Ссылка);
					Команда.Parameters.AddWithValue("Заявитель", Заявитель.Ссылка);
					Команда.Parameters.AddWithValue("Обязанности", Обязанности);
					Команда.Parameters.AddWithValue("Организация", Организация.Ссылка);
					Команда.Parameters.AddWithValue("Ответственный", Ответственный.Ссылка);
					Команда.Parameters.AddWithValue("ПлановаяДатаЗакрытия", ПлановаяДатаЗакрытия);
					Команда.Parameters.AddWithValue("Требования", Требования);
					Команда.Parameters.AddWithValue("Условия", Условия);
					Команда.Parameters.AddWithValue("ДатаОткрытия", ДатаОткрытия);
					Команда.Parameters.AddWithValue("ДатаЗакрытия", ДатаЗакрытия);
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
					Команда.CommandText = @"Delete _Reference39
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		///////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ - ОБРАБОТЧИКИ СОБЫТИЙ

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*ОбменДанными.Загрузка*/)
			{
			}
			/*// Заголовок для сообщений об ошибках записи.
*/
			/*Заголовок	= "Запись элемента справочника Вакансии"
				+ ?(ПустаяСтрока(Код), "", " с кодом " + Код)
				+ ?(ПустаяСтрока(Наименование), "", " и наименованием <" + Наименование + ">");*/
			if(true/*Должность.Пустая()*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("Не указана должность!", Отказ, Заголовок);
			}
			//ТекстСообщенияОбОшибке	= "";
			//ВакансииПереопределяемый.ПроверитьЗначенияРеквизитов(ЭтотОбъект, Отказ, ТекстСообщенияОбОшибке);
			if(true/*Отказ*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке(ТекстСообщенияОбОшибке, Отказ, Заголовок);
			}
		}
		////////////////////////////////////////////////////////////////////////////////
	}
}
