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
	///<summary>
	///(Упр)
	///</summary>
	public partial class СчетаБюджета:СправочникОбъект
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
		public decimal/*(1)*/ Знак;
		public object СтатьяБаланса;//Статья баланса
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
						Insert Into _Reference256(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld3872
						,_Fld3873RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Родитель
						,@ЭтоГруппа
						,@Код
						,@Наименование
						,@Знак
						,@СтатьяБаланса)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference256
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld3872	= @Знак
						,_Fld3873RRef	= @СтатьяБаланса
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Предопределенный", Предопределенный);
					Команда.Parameters.AddWithValue("Родитель", Родитель);
					Команда.Parameters.AddWithValue("ЭтоГруппа", ЭтоГруппа?new byte[]{0}:new byte[]{1});
					Команда.Parameters.AddWithValue("Код", Код);
					Команда.Parameters.AddWithValue("Наименование", Наименование);
					Команда.Parameters.AddWithValue("Знак", Знак);
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
					Команда.CommandText = @"Delete _Reference256
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		// Процедура генерирует код перемещаемого элемента (группы) справочника,
		// а также код расположенного рядом элемента при интерактивном перемещении
		// элемента в форме списка справочника.
		// Записывает переставляемые элементы с измененными кодами.
		// В случае сдвига группы элементов также изменяет коды вложенных в группу
		// элементов.
		//
		// Параметры
		//  Направление  – число – направление сдвига элемента,
		//                 принимает значения:
		//                      1 - при сдвиге вниз;
		//                     -1 - при сдвиге вверх.
		//

		public void ИзменитьКод(/*Направление*/)
		{
			//ТекущийКод    = Код;
			//СписокКодов   = Новый СписокЗначений;
			//СчетаБюджета  = Справочники.СчетаБюджета;
			//ВыборкаСтроки = СчетаБюджета.Выбрать(Родитель, Владелец, , "Код Убыв");
			while(true/*ВыборкаСтроки.Следующий()*/)
			{
				//СписокКодов.Добавить(ВыборкаСтроки.Код);
			}
			if(true/*СписокКодов.Количество() < 2*/)
			{
				/*// На данном уровне имеется только один элемент или группа справочника.
*/
				/*// Игнорируем действие пользователя.
*/
			}
			//ПорядковыйНомер = СписокКодов.Индекс(СписокКодов.НайтиПоЗначению(ТекущийКод));
			if(true/*(ПорядковыйНомер = 0) И (Направление < 0)*/)
			{
				/*// Попытка перемещения первого по порядку элемента вверх.
*/
				//ИндексЭлементаЗамены = СписокКодов.Количество() - 1;
			}
			//КодЭлементаЗамены     = СписокКодов.Получить(ИндексЭлементаЗамены).Значение;
			//ЭлементЗаменыСсылка   = СчетаБюджета.НайтиПоКоду(КодЭлементаЗамены,,Родитель, Владелец);
			if(true/*ЭлементЗаменыСсылка <> СчетаБюджета.ПустаяСсылка()*/)
			{
			}
		}
	}
}
