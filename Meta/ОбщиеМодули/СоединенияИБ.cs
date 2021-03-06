﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class СоединенияИБ
	{
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ДЛЯ БЛОКИРОВКИ И ЗАВЕРШЕНИЯ СОЕДИНЕНИЙ С ИБ
		// Устанавливает блокировку соединений ИБ.
		//
		// Параметры
		//  ТекстСообщения  – Строка – текст, который будет частью сообщения об ошибке
		//                             при попытке установки соединения с заблокированной
		//                             информационной базой.
		//
		//  КодРазрешения - Строка -   строка, которая должна быть добавлена к параметру
		//                             командной строки "/uc" или к параметру строки
		//                             соединения "uc", чтобы установить соединение с
		//                             информационной базой несмотря на блокировку.
		//
		// Возвращаемое значение:
		//   Булево   – Истина, если блокировка установлена успешно.
		//              Ложь, если для выполнения блокировки недостаточно прав.
		//

		public object УстановитьБлокировкуСоединений(/*Знач ТекстСообщения = "",
                                       Знач КодРазрешения = "КодРазрешения"*/)
		{
			if(true/*НЕ ПравоДоступа("Администрирование", Метаданные)*/)
			{
			}
			//Блокировка = Новый БлокировкаСеансов;
			//Блокировка.Установлена = Истина;
			//Блокировка.Начало = ТекущаяДатаСеанса();
			//Блокировка.КодРазрешения = КодРазрешения;
			//Блокировка.Сообщение = СформироватьСообщениеБлокировки(ТекстСообщения, КодРазрешения);
			//УстановитьБлокировкуСеансов(Блокировка);
			return null;
		}
		// Определяет, установлена ли блокировка соединений при пакетном
		// обновлении конфигурации информационной базы
		//

		public object УстановленаБлокировкаСоединений(/**/)
		{
			//ТекущийРежим = ПолучитьБлокировкуСеансов();
			return null;
		}
		// Возвращает параметры блокировки соединений ИБ.
		//
		// Параметры:
		//  ПолучитьКоличествоСеансов - Булево - если Истина, то в возвращаемой структуре
		//                                       заполняется поле КоличествоСеансов.
		//

		public object ПараметрыБлокировкиСеансов(/*Знач ПолучитьКоличествоСеансов = Ложь*/)
		{
			//УстановитьПривилегированныйРежим(Истина);
			//ТекущийРежим = ПолучитьБлокировкуСеансов();
			/*// 5 минут; интервал ожидания завершения пользователей после установки
*/
			/*// блокировки информационной базы (в секундах).
*/
			/*?(ПолучитьКоличествоСеансов, КоличествоСеансовИнформационнойБазы(), 0),
		ТекущаяДатаСеанса()
	);*/
			return null;
		}
		// Снять блокировку информационной базы.
		//
		// Возвращаемое значение:
		//   Булево   – Истина, если операция выполнена успешно.
		//              Ложь, если для выполнения операции недостаточно прав.
		//

		public object РазрешитьРаботуПользователей(/**/)
		{
			if(true/*НЕ ПравоДоступа("Администрирование", Метаданные)*/)
			{
			}
			//ТекущийРежим = ПолучитьБлокировкуСеансов();
			if(true/*ТекущийРежим.Установлена*/)
			{
				//НовыйРежим = Новый БлокировкаСеансов;
				//НовыйРежим.Установлена = Ложь;
				//УстановитьБлокировкуСеансов(НовыйРежим);
			}
			return null;
		}
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ПРИНУДИТЕЛЬНОГО ОТКЛЮЧЕНИЯ СЕАНСОВ ИБ
		// Отключает сеанс по номеру сеанса
		//
		// Параметры
		//  ПараметрыАдминистрированияИБ  – Структура – параметры администрирования ИБ
		//  НомерСеанса - Число - номер сеанса для отключения
		//
		// Возвращаемое значение:
		//  Булево – результат отключения сеанса.
		//

		public object ОтключитьСеанс(/*НомерСеанса, Сообщение*/)
		{
			return null;
		}
		// Отключить все активные соединения ИБ (кроме текущего сеанса).
		//
		// Параметры
		//  ПараметрыАдминистрированияИБ  – Структура – параметры администрирования ИБ.
		//
		// Возвращаемое значение:
		//   Булево   – результат отключения соединений.
		//

		public object ОтключитьСоединенияИБ(/*ПараметрыАдминистрированияИБ*/)
		{
			return null;
		}
		// Осуществляет попытку подключиться к кластеру серверов и получить список
		// активных соединений к ИБ и использованием указанных параметров администрирования.
		//
		// Параметры
		//  ПараметрыАдминистрированияИБ  – Структура – параметры администрирования ИБ
		//  ВыдаватьСообщения             – Булево    – разрешить вывод интерактивных сообщений.
		//
		// Возвращаемое значение:
		//   Булево   – Истина, если проверка завершена успешно.
		//

		public void ПроверитьПараметрыАдминистрированияИБ(/*ПараметрыАдминистрированияИБ,
	Знач ПодробноеСообщениеОбОшибке = Ложь*/)
		{
			/*СоединенияИБКлиентСервер.ПроверитьПараметрыАдминистрированияИБ(ПараметрыАдминистрированияИБ,
		ПодробноеСообщениеОбОшибке);*/
		}
		////////////////////////////////////////////////////////////////////////////////
		// СЕРВИСНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		//
		// Возвращает текст сообщения блокировки сеансов.
		//
		// Возвращаемое значение:
		//   Строка
		//

		public object СформироватьСообщениеБлокировки(/*Знач Сообщение, Знач КодРазрешения*/)
		{
			//ПараметрыАдминистрированияИБ = СоединенияИБПовтИсп.ПолучитьПараметрыАдминистрированияИБ();
			//ПризнакФайловогоРежима = Ложь;
			/*ПутьКИБ = СоединенияИБКлиентСервер.ПутьКИнформационнойБазе(ПризнакФайловогоРежима, 
		?(ПараметрыАдминистрированияИБ.Свойство("ПортКластераСерверов"), ПараметрыАдминистрированияИБ.ПортКластераСерверов, 0));*/
			//СтрокаПутиКИнформационнойБазе = ?(ПризнакФайловогоРежима = Истина, "/F", "/S") + ПутьКИБ;
			//ТекстСообщения = "";
			if(true/*НЕ ПустаяСтрока(Сообщение)*/)
			{
				//ТекстСообщения = Сообщение + Символы.ПС + Символы.ПС;
			}
			/*ТекстСообщения = ТекстСообщения +
	    НСтр("ru = '%1
	               |Для того чтобы принудительно разблокировать информационную базу, воспользуйтесь консолью кластера серверов или запустите ""1С:Предприятие"" с параметрами:
	               |ENTERPRISE %2 /CРазрешитьРаботуПользователей /UC%3'");*/
			/*ТекстСообщения = СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(ТекстСообщения,
		СоединенияИБКлиентСервер.ТекстДляАдминистратора(), СтрокаПутиКИнформационнойБазе, НСтр("ru = '<код разрешения>'"));*/
			return null;
		}
		// Возвращает текстовую строку со списком активных соединений ИБ.
		// Названия соединений разделены символом переноса строки.
		//
		// Возвращаемое значение:
		//   Строка
		//

		public object ПолучитьНазванияСоединенийИБ(/*Знач Сообщение*/)
		{
			//Результат = Сообщение;
			return null;
		}
		// Получить сохраненные параметры администрирования кластера серверов.
		//
		// Возвращаемое значение:
		//   Структура – с полями, возвращаемыми функцией НовыеПараметрыАдминистрированияИБ.
		//

		public object ПолучитьПараметрыАдминистрированияИБ(/**/)
		{
			//Результат = СоединенияИБКлиентСервер.НовыеПараметрыАдминистрированияИБ();
			//СтруктураНастроек = Константы.ПараметрыАдминистрированияИБ.Получить().Получить();
			if(true/*ТипЗнч(СтруктураНастроек) = Тип("Структура")*/)
			{
				//ЗаполнитьЗначенияСвойств(Результат, СтруктураНастроек);
			}
			return null;
		}
		// Сохранить параметры администрирования кластера серверов в ИБ.
		//
		// Параметры:
		//		Параметры - структура с полями, возвращаемыми функцией НовыеПараметрыАдминистрированияИБ.
		//

		public void ЗаписатьПараметрыАдминистрированияИБ(/*Параметры*/)
		{
			//Константы.ПараметрыАдминистрированияИБ.Установить(Новый ХранилищеЗначения(Параметры));
			//ОбновитьПовторноИспользуемыеЗначения();
		}
		// Получить число активных сеансов ИБ.
		//
		// Параметры:
		//   УчитыватьКонсоль               - Булево - если Ложь, то исключить сеансы консоли кластера серверов.
		//                                             сеансы консоли кластера серверов не препятствуют выполнению
		//                                             административных операций (установке монопольного режима и т.п.).
		//   СообщенияДляЖурналаРегистрации - СписокЗначений - пакета сообщения для журнала регистрации
		//                                                     сформированных на клиенте.
		//
		// Возвращаемое значение:
		//   Число   – количество активных сеансов ИБ.
		//

		public object КоличествоСеансовИнформационнойБазы(/*УчитыватьКонсоль = Истина, 
	СообщенияДляЖурналаРегистрации = Неопределено*/)
		{
			//ОбщегоНазначения.ЗаписатьСобытияВЖурналРегистрации(СообщенияДляЖурналаРегистрации);
			//СеансыИБ = ПолучитьСеансыИнформационнойБазы();
			if(true/*УчитыватьКонсоль*/)
			{
			}
			//Результат = 0;
			return null;
		}
		// Возвращает строковую константу для формирования сообщений журнала регистрации.
		//
		// Возвращаемое значение:
		//   Строка
		//

		public object СобытиеЖурналаРегистрации(/**/)
		{
			//Возврат НСтр("ru = 'Завершение работы пользователей'");
			return null;
		}
		// Записать в журнал регистрации список сеансов ИБ.
		//
		// Параметры:
		//   ТекстСообщения - Строка - опциональный текст с пояснениями.
		//

		public void ЗаписатьНазванияСоединенийИБ(/*Знач ТекстСообщения*/)
		{
			//Сообщение = ПолучитьНазванияСоединенийИБ(ТекстНеУдалосьЗавершитьРаботуПользователей(ТекстСообщения));
			/*ЗаписьЖурналаРегистрации(СобытиеЖурналаРегистрации(), 
		УровеньЖурналаРегистрации.Предупреждение, , , Сообщение);*/
		}

		public object ТекстНеУдалосьЗавершитьРаботуПользователей(/*Знач Сообщение*/)
		{
			if(true/*Не ПустаяСтрока(Сообщение)*/)
			{
				/*ТекстСообщения = СтроковыеФункцииКлиентСервер.ПодставитьПараметрыВСтроку(
			НСтр("ru = 'Не удалось завершить работу пользователей (%1):'"),
			Сообщение);*/
			}
			return null;
		}
	}
}
