﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class УправлениеПланированием
	{
		//////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЕ ПРОЦЕДУРЫ
		// Данная процедура пополняет состав одной таблицы значений данными из другой.
		//
		// Аргументы:
		//	ТаблицаПриемник		- пополняемая таблица
		//	ТаблицаИсточник 	- таблица-источник данных. Если не указана - создается новая.
		//						Если не содержит колонок - создаются колонки как в источнике.
		//	СПозиции 			- номер строки пополняемой таблицы, с которой производится добавление
		//	НомерСтрокиИсточника - если указан номер строки таблимцы-источника
		//						- добавляется данные только из нее
		//
		//

		public void ДополнитьТаблицу(/*ТаблицаПриемник, ТаблицаИсточник, СПозиции = -1, НомерСтрокиИсточника = -1*/)
		{
			if(true/*ТипЗнч(ТаблицаПриемник) <> Тип("ТаблицаЗначений") И ТипЗнч(ТаблицаПриемник) <> Тип("КоллекцияСтрокДереваЗначений")*/)
			{
				//ТаблицаПриемник = Новый ТаблицаЗначений;
			}
			if(true/*ТипЗнч(ТаблицаПриемник) = Тип("ТаблицаЗначений")*/)
			{
				if(true/*ТаблицаПриемник.Колонки.Количество() = 0*/)
				{
					if(true/*НомерСтрокиИсточника < 0*/)
					{
						//ТаблицаПриемник = ТаблицаИсточник.Скопировать();
					}
				}
			}
			if(true/*НомерСтрокиИсточника < 0*/)
			{
			}
		}
		// ДополнитьТаблицу()
		// Данная функция определяет, возможна ли предполагаемая корректировка
		// плановых данны исходня из того, попадает ли корректировка в закрытые даты
		//
		// Аргументы:
		//	аргВидПланирования -
		//	аргПодразделение (необязательный) - .
		//				Значение по умолчанию - пустое подразделение.
		//	аргПроект (необязательный) -
		//				Значение по умолчанию - пустой проект.
		//	аргСценарий (необязательный) -
		//				Значение по умолчанию - пустой сценарий.
		//	аргДатаЛимита (необязательный) -
		//				Значение по умолчанию - пустая дата ('00010101000000').
		//
		//
		// Возвращаемое значение:
		//  Дата, являющаяся границей фиксации периодов
		//

		public object ПолучитьГраницуФиксацииПериодов(/*ВидПланирования, Подразделение = Неопределено, Проект = Неопределено, Сценарий = Неопределено, ДатаЛимита = '00010101'*/)
		{
			/*Запрос = Новый Запрос(
	"ВЫБРАТЬ ПЕРВЫЕ 1
	|	ГраницыПериодовПланирования.ГраницаФиксации КАК ГраницаФиксации
	|ИЗ
	|	РегистрСведений.ГраницыПериодовПланирования КАК ГраницыПериодовПланирования
	|ГДЕ
	|	ГраницыПериодовПланирования.ВидПланирования = &ВидПланирования
	|	И ГраницыПериодовПланирования.Подразделение В (&Подразделение, ЗНАЧЕНИЕ(Справочник.Подразделения.ПустаяСсылка))
	|	И ГраницыПериодовПланирования.Проект В (&Проект, ЗНАЧЕНИЕ(Справочник.Проекты.ПустаяСсылка))
	|	И ГраницыПериодовПланирования.Сценарий В (&Сценарий, ЗНАЧЕНИЕ(Справочник.СценарииПланирования.ПустаяСсылка))
	|	И ГраницыПериодовПланирования.ГраницаФиксации > &ДатаПланирования
	|
	|УПОРЯДОЧИТЬ ПО
	|	ГраницаФиксации УБЫВ");*/
			//Запрос.УстановитьПараметр("ВидПланирования", ВидПланирования);
			//Запрос.УстановитьПараметр("Подразделение", Подразделение);
			//Запрос.УстановитьПараметр("Проект", Проект);
			//Запрос.УстановитьПараметр("Сценарий", Сценарий);
			//Запрос.УстановитьПараметр("ДатаПланирования", ДатаЛимита);
			//Результат = Запрос.Выполнить();
			if(true/*Не Результат.Пустой()*/)
			{
				//Выборка = Результат.Выбрать();
				//Выборка.Следующий();
			}
			return null;
		}
		// ПолучитьГраницуФиксацииПериодов()
		//////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ РАБОТЫ С ПЕРИОДАМИ
		// Выравнивает дату по началу периода.
		//
		// Параметры:
		//  ДатаПланирования  - выравниваемая дата
		//  Периодичность     - тип интервала для выравнивания
		//  НазваниеДаты 	  - наименование вида даты для вывода сообщения
		//  ВыводитьСообщение - признак необходимости вывода сообщения о выравнивании
		//

		public void ВыровнятьДатуПоНачалуПериода(/*ДатаПланирования, Периодичность, НазваниеДаты = "Дата начала периода ", ВыводитьСообщение=Ложь*/)
		{
			//ДатаИзменена = Ложь;
			//ДатаНачПериода = ДатаПланирования;
			//ВыровнятьПериод(ДатаНачПериода,, Периодичность);
			if(true/*ДатаПланирования <> ДатаНачПериода*/)
			{
				//ДатаПланирования = ДатаНачПериода;
				//ДатаИзменена = Истина;
			}
			if(true/*ВыводитьСообщение и ДатаИзменена*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке(НазваниеДаты + "изменена в соответствии с установленной периодичностью.");
			}
		}
		// ВыровнятьДатуПоНачалуПериода()
		// Выравнивает дату по окончанию периода.
		//
		// Параметры:
		//  ДатаПланирования  - выравниваемая дата
		//  Периодичность     - тип интервала для выравнивания
		//  НазваниеДаты 	  - наименование вида даты для вывода сообщения
		//  ВыводитьСообщение - признак необходимости вывода сообщения о выравнивании
		//

		public void ВыровнятьДатуПоКонцуПериода(/*ДатаПланирования, Периодичность, НазваниеДаты = "Дата окончания периода ", ВыводитьСообщение = Ложь*/)
		{
			//ДатаИзменена = Ложь;
			//ДатаКонПериода = ДатаПланирования;
			//ВыровнятьПериод(, ДатаКонПериода, Периодичность);
			if(true/*ДатаПланирования <> ДатаКонПериода*/)
			{
				//ДатаПланирования = ДатаКонПериода;
				//ДатаИзменена = Истина;
			}
			if(true/*ВыводитьСообщение и ДатаИзменена*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке(НазваниеДаты + "изменена в соответствии с установленной периодичностью.");
			}
		}
		// ВыровнятьДатуПоКонцуПериода()
		// Процедура выравнивает начальнаю и конечную даты по границам указанной периодичности
		// 		ДатаНачПериода - дата, которую нужно выровнять по началу указанной периодичностью
		// 		ДатаКонПериода - дата, которую нужно выровнять по окончанию указанной периодичностью
		// 		Периодичность - периодичность, определяющая границы выравнивания
		//

		public void ВыровнятьПериод(/*ДатаНачПериода = Неопределено, ДатаКонПериода = Неопределено, Периодичность = Неопределено*/)
		{
			if(true/*ТипЗнч(Периодичность) <> Тип("ПеречислениеСсылка.Периодичность") ИЛИ Периодичность = Перечисления.Периодичность.ПустаяСсылка()*/)
			{
				//ТекущаяПериодичность = Перечисления.Периодичность.День;
			}
			/*Запрос = Новый Запрос(
	"ВЫБРАТЬ
	|	НАЧАЛОПЕРИОДА(&ДатаНач, " + Строка(ТекущаяПериодичность) + ") КАК ДатаНач,
	|	КОНЕЦПЕРИОДА(&ДатаКон, " + Строка(ТекущаяПериодичность) + ") КАК ДатаКон");*/
			//Запрос.УстановитьПараметр("ДатаНач", ?(ТипЗнч(ДатаНачПериода) <> Тип("Дата"), Дата('00010101'), ДатаНачПериода));
			//Запрос.УстановитьПараметр("ДатаКон", ?(ТипЗнч(ДатаКонПериода) <> Тип("Дата"), Дата('00010101'), ДатаКонПериода));
			//Выборка = Запрос.Выполнить().Выбрать();
			//Выборка.Следующий();
			//ДатаНачПериода = Выборка.ДатаНач;
			//ДатаКонПериода = Выборка.ДатаКон;
		}
		// ВыровнятьПериод()
		//////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ НОРМАТИВНОЙ СИСТЕМЫ
		// Функция определяет возможные аналоги для переданной таблицы номенклатуры.
		//

		public object ПолучитьАналогиНоменклатуры(/*Знач ТабНоменклатуры, ВозвращатьУзлы = Ложь*/)
		{
			//ПустаяНоменклатура 	 = Справочники.Номенклатура.ПустаяСсылка();
			//ПустаяХарактеристика = Справочники.ХарактеристикиНоменклатуры.ПустаяСсылка();
			//ПустаяСпецификация 	 = Справочники.СпецификацииНоменклатуры.ПустаяСсылка();
			//ТаблицаАналоги = Новый ТаблицаЗначений;
			//ТаблицаАналоги.Колонки.Добавить("Номенклатура");
			//ТаблицаАналоги.Колонки.Добавить("ХарактеристикаНоменклатуры");
			//ТаблицаАналоги.Колонки.Добавить("ЕдиницаИзмерения");
			//ТаблицаАналоги.Колонки.Добавить("Количество");
			//ТаблицаАналоги.Колонки.Добавить("Приоритет");
			//ТаблицаАналоги.Колонки.Добавить("Аналог");
			//ТаблицаАналоги.Колонки.Добавить("ХарактеристикаАналога");
			//ТаблицаАналоги.Колонки.Добавить("КоличествоАналога");
			//ТаблицаАналоги.Колонки.Добавить("ЕдиницаИзмеренияАналога");
			return null;
		}
		// ПолучитьАналогиНоменклатуры()

		public object КонтрольЗацикливанияПодчиненныхРабочихЦентров(/*РабочийЦентр, МассивРабочихЦентров = Неопределено*/)
		{
			if(true/*МассивРабочихЦентров = Неопределено*/)
			{
				//МассивРабочихЦентров = Новый Массив;
			}
			/*// Проверяемые рабочие центры заносим в отдельный массив
*/
			//МассивРодителей = Новый Массив;
			if(true/*ТипЗнч(РабочийЦентр) = Тип("СправочникСсылка.РабочиеЦентры")*/)
			{
				//МассивРодителей.Добавить(РабочийЦентр);
			}
			//Результат = Ложь;
			return null;
		}
		// КонтрольЗацикливанияПодчиненныхРабочихЦентров()
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ РАБОТЫ С ПЛАНАМИ
		// Процедура выполняет стандартные действия при начале выбора документа составного типа в формах документов.
		//
		// Параметры:
		//  ДокументОбъект       - объект редактируемого документа;
		//  ФормаДокумента       - форма редактируемого документа;
		//  ЭлементФормы         - элемент формы документа, который надо заполнить;
		//  СтандартнаяОбработка - булево, признак выполнения стандартной (системной) обработки события
		//                         начала выбора для данного элемента формы документа.
		//  СтруктураОтбора      - структура, содержащая имена и значения отборов в форме выбора.
		//  ИмяТабличнойЧасти    - имя табличной части.
		//  ДопПараметры         - структура с дополнительными параметрами.
		//

		public void НачалоВыбораДокументаПлан(/*ДокументОбъект, ФормаДокумента, ЭлементФормы, СтандартнаяОбработка, СтруктураОтбора = Неопределено, ИмяТабличнойЧасти, ДопПараметры = Неопределено, ИмяКолонки = Неопределено*/)
		{
			//СтандартнаяОбработка = Ложь;
			/*// Заполним возможный список типов документов, которые могут быть в этом реквизите.
*/
			//СписокТипов = Новый СписокЗначений;
			if(true/*ПустаяСтрока(ИмяТабличнойЧасти)*/)
			{
				/*// Шапка документа
*/
				//МассивТипов = ДокументОбъект.Метаданные().Реквизиты[ЭлементФормы.Данные].Тип.Типы();
			}
			//МассивТиповИсключений = Новый Массив;
			if(true/*Не ДопПараметры = Неопределено*/)
			{
				if(true/*ДопПараметры.Свойство("ИсключаемыеТипы")*/)
				{
					//МассивТиповИсключений = ДопПараметры["ИсключаемыеТипы"];
				}
			}
			if(true/*МассивТипов.Количество() = 0*/)
			{
				/*// Удалили все возможные типы
*/
				/*// Выбор невозможен
*/
			}
			if(true/*ТипЗнч(ЭлементФормы.Значение) <> Тип("ДокументСсылка." + ВыбранныйТип)*/)
			{
				//ЭлементФормы.Значение = Документы[ВыбранныйТип].ПустаяСсылка();
			}
			/*// В качестве владельца формы выбора устанавливаем данный элемент,
*/
			/*// чтобы выбранное значение было присвоено стандартно.
*/
			//ФормаВыбора = Документы[ВыбранныйТип].ПолучитьФормуВыбора(,ЭлементФормы,);
			if(true/*СтруктураОтбора <> Неопределено*/)
			{
				/*// Отфильтруем список документов.
*/
			}
			if(true/*ЗначениеЗаполнено(ЭлементФормы.Значение)*/)
			{
				//ФормаВыбора.ПараметрТекущаяСтрока = ЭлементФормы.Значение;
			}
			//ФормаВыбора.Открыть();
		}
		// НачалоВыбораДокументаПлан()
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ПРИВЕДЕНИЯ ЧИСЕЛ

		public object ПривестиКМинимальнойПартииКратности(/*Знач Значение, Знач МинимальнаяПартия, Знач Кратность, ВМеньшуюСторону = Ложь*/)
		{
			//Кратность = ?(Кратность < 0, -Кратность, Кратность);
			//МинимальнаяПартия = ?(МинимальнаяПартия < 0, -МинимальнаяПартия, МинимальнаяПартия);
			if(true/*ВМеньшуюСторону*/)
			{
				if(true/*Значение < МинимальнаяПартия*/)
				{
				}
			}
			return null;
		}
		// ПривестиКМинимальнойПартииКратности()

		public object ОкруглитьВБольшуюСторону(/*Значение, Разрядность*/)
		{
			//Множитель = Цел(Pow(10, Разрядность));
			/*// Если передано неверное (нецелое или < 0) значение разрядности, возвращается 0
*/
			if(true/*Множитель < 1*/)
			{
			}
			return null;
		}
		// ОкруглитьВБольшуюСторону()
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ РАБОТЫ С ДРОБЯМИ

		public object ПолучитьДробь(/*Знач Числитель, Знач Знаменатель, Сократить = Истина*/)
		{
			if(true/*Сократить*/)
			{
				//НаибольшийОбщийДелитель = ПолучитьНаибольшийОбщийДелитель(Числитель, Знаменатель);
				//Возврат Новый Структура("Числитель, Знаменатель, Значение", Числитель / НаибольшийОбщийДелитель, Знаменатель / НаибольшийОбщийДелитель, ?(Знаменатель = 0, 0, Числитель / Знаменатель));
			}
			return null;
		}
		// ПолучитьДробь()

		public object МинДробь(/*Дробь1, Дробь2*/)
		{
			if(true/*Дробь1.Числитель * Дробь2.Знаменатель < Дробь2.Числитель * Дробь1.Знаменатель*/)
			{
			}
			return null;
		}
		// МинДробь()

		public object МаксДробь(/*Дробь1, Дробь2*/)
		{
			if(true/*Дробь1.Числитель * Дробь2.Знаменатель > Дробь2.Числитель * Дробь1.Знаменатель*/)
			{
			}
			return null;
		}
		// МаксДробь()

		public object РазностьДробей(/*Дробь1, Дробь2*/)
		{
			return null;
		}
		//РазностьДробей()

		public object СуммаДробей(/*Дробь1, Дробь2*/)
		{
			return null;
		}
		//СуммаДробей()

		public object ПолучитьНаибольшийОбщийДелитель(/*Знач Числитель, Знач Знаменатель*/)
		{
			if(true/*Числитель = 0 ИЛИ Знаменатель = 0*/)
			{
			}
			while(true/*Знаменатель <> 0*/)
			{
				//ОстатокОтДеления = Числитель % Знаменатель;
				//Числитель = Знаменатель;
				//Знаменатель = ОстатокОтДеления;
			}
			return null;
		}
	}
}

