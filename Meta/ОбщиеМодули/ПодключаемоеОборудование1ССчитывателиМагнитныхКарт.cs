﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПодключаемоеОборудование1ССчитывателиМагнитныхКарт
	{
		///////////////////////////////////////////////////////////////////////////////
		// ПРОГРАММНЫЙ ИНТЕРФЕЙС
		// Функция осуществляет подключение устройства.
		//
		// Параметры:
		//  ОбъектДрайвера   - <*>
		//           - ОбъектДрайвера драйвера торгового оборудования.
		//
		// Возвращаемое значение:
		//  <Булево> - Результат работы функции.
		//

		public object ПодключитьУстройство(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат  = Истина;
			/*// Обязательные выходные
*/
			if(true/*ТипЗнч(ВыходныеПараметры) <> Тип("Массив")*/)
			{
				//ВыходныеПараметры = Новый Массив();
			}
			/*// Проверка настроенных параметров
*/
			//Порт             = Неопределено;
			//Скорость         = Неопределено;
			//СтопБит          = Неопределено;
			//БитДанных        = Неопределено;
			//ПараметрыДорожек = Неопределено;
			//Параметры.Свойство("Порт",             Порт);
			//Параметры.Свойство("Скорость",         Скорость);
			//Параметры.Свойство("СтопБит",          СтопБит);
			//Параметры.Свойство("БитДанных",        БитДанных);
			//Параметры.Свойство("ПараметрыДорожек", ПараметрыДорожек);
			if(true/*Порт             = Неопределено
	 Или Скорость         = Неопределено
	 Или СтопБит          = Неопределено
	 Или БитДанных        = Неопределено
	 Или ПараметрыДорожек = Неопределено*/)
			{
				//ВыходныеПараметры.Добавить(999);
				/*ВыходныеПараметры.Добавить(НСтр("ru='Не настроены параметры устройства.
		|Для корректной работы устройства необходимо задать параметры его работы.
		|Сделать это можно при помощи формы ""Настройка параметров"" модели
		|подключаемого оборудования в форме ""Подключение и настройка оборудования"".'"));*/
				//Результат = Ложь;
			}
			if(true/*Результат*/)
			{
				//ВыходныеПараметры.Добавить("СчитывательМагнитныхКарт");
				//ВыходныеПараметры.Добавить(Новый Массив());
				//ВыходныеПараметры[1].Добавить("ПолученКодКарты");
				//Результат = (ОбъектДрайвера.Подсоединить(ВыходныеПараметры[0]) = 0);
				if(true/*НЕ Результат*/)
				{
					//ВыходныеПараметры.Очистить();
					//ВыходныеПараметры.Добавить(999);
					/*ВыходныеПараметры.Добавить(НСтр("ru='Ошибка при подключении устройства.
			|Проверьте настройки порта.'"));*/
				}
				if(true/*Результат = Истина*/)
				{
					//ОбъектДрайвера.БитДанных  = Параметры.БитДанных;
					//ОбъектДрайвера.Порт       = Параметры.Порт;
					//ОбъектДрайвера.Скорость   = Параметры.Скорость;
					//ОбъектДрайвера.ИмяСобытия = ВыходныеПараметры[1][0];
					//Результат = (ОбъектДрайвера.Занять(1) = 0);
					if(true/*Результат*/)
					{
						//ОбъектДрайвера.УстройствоВключено = 1;
						//ОбъектДрайвера.ПосылкаДанных      = 1;
						//ОбъектДрайвера.ОчиститьВход();
						//ОбъектДрайвера.ОчиститьВыход();
						//Результат = (ОбъектДрайвера.УстройствоВключено = 1);
						if(true/*НЕ Результат*/)
						{
							//ОтключитьУстройство(ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры);
							//ВыходныеПараметры.Очистить();
							//ВыходныеПараметры.Добавить(999);
							/*ВыходныеПараметры.Добавить(НСтр("ru='Ошибка при подключении устройства.
					|Проверьте настройки порта.'"));*/
						}
					}
				}
			}
			return null;
		}
		// Функция осуществляет отключение устройства.
		//
		// Параметры:
		//  ОбъектДрайвера - <*>
		//         - ОбъектДрайвера драйвера торгового оборудования.
		//
		// Возвращаемое значение:
		//  <Булево> - Результат работы функции.
		//

		public object ОтключитьУстройство(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			/*// Обязательные выходные
*/
			if(true/*ТипЗнч(ВыходныеПараметры) <> Тип("Массив")*/)
			{
				//ВыходныеПараметры = Новый Массив();
			}
			//ОбъектДрайвера.УстройствоВключено = 0;
			//ОбъектДрайвера.Освободить();
			//ОбъектДрайвера.Отсоединить();
			return null;
		}
		// Функция получает, обрабатывает и перенаправляет на исполнение команду к драйверу
		//

		public object ВыполнитьКоманду(/*Команда, ВходныеПараметры = Неопределено, ВыходныеПараметры = Неопределено,
                         ОбъектДрайвера, Параметры, ПараметрыПодключения*/)
		{
			//Результат = Истина;
			/*// Обязательные выходные
*/
			if(true/*ТипЗнч(ВыходныеПараметры) <> Тип("Массив")*/)
			{
				//ВыходныеПараметры = Новый Массив();
			}
			/*// Обработка события от устройства
*/
			if(true/*Команда = "ОбработатьСобытие"*/)
			{
				//Событие = ВходныеПараметры[0];
				//Данные  = ВходныеПараметры[1];
				//Результат = ОбработатьСобытие(ОбъектДрайвера, Параметры, ПараметрыПодключения, Событие, Данные, ВыходныеПараметры);
				/*// Завершение обработки события от устройства
*/
			}
			return null;
		}
		///////////////////////////////////////////////////////////////////////////////
		// СЛУЖЕБНЫЕ ПРОЦЕДУРЫ И ФУНКЦИИ
		// Возвращает версию компоненты расположенной в макете.
		//

		public object ПолучитьВерсиюВнешнейКомпоненты(/**/)
		{
			return null;
		}
		// Функция осуществляет обработку внешних событий торгового оборудования.
		//

		public object ОбработатьСобытие(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, Событие, Данные, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//КодКарты  = Данные;
			//ОбъектДрайвера.ПосылкаДанных = 0;
			//ПозицияПрефикса = 0;
			//ПозицияСуффикса = 0;
			//времКодКарты    = "";
			//ДанныеКарты = "";
			//ПозицияДляЧтения = 1;
			//ДанныеДорожек = Новый Массив();
			//КодКарты = времКодКарты;
			//ВыходныеПараметры.Добавить("TracksData");
			//ВыходныеПараметры.Добавить(Новый Массив());
			//ВыходныеПараметры[1].Добавить(КодКарты);
			//ВыходныеПараметры[1].Добавить(Новый Массив);
			//ВыходныеПараметры[1][1].Добавить(Сред(Данные,2));
			//ВыходныеПараметры[1][1].Добавить(ДанныеДорожек);
			//ВыходныеПараметры[1][1].Добавить(0);
			//ВыходныеПараметры[1][1].Добавить(МенеджерОборудованияСервер.РасшифроватьКодМагнитнойКарты(ДанныеДорожек, Параметры.ПараметрыДорожек));
			return null;
		}
		// Процедура вызывается, когда система готова принять следующее событие от устройства.

		public object ЗавершитьОбработкуСобытия(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//ОбъектДрайвера.ПосылкаДанных = 1;
			return null;
		}
		// Осуществляется открытие формы проверки параметров драйвера

		public object ТестУстройства(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//ОбъектДрайвера.Порт      = Параметры.Порт;
			//ОбъектДрайвера.Скорость  = Параметры.Скорость;
			//ОбъектДрайвера.БитДанных = Параметры.БитДанных;
			/*//ОбъектДрайвера.СтопБит   = Параметры.СтопБит;
*/
			//ОбъектДрайвера.ТестУстройства();
			return null;
		}
		// Осуществляется открытие формы настройки параметров журналирования драйвера

		public object ПараметрыЖурналирования(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//ОбъектДрайвера.Скорость  = Параметры.Скорость;
			//ОбъектДрайвера.БитДанных = Параметры.БитДанных;
			//ОбъектДрайвера.ПараметрыЖурналирования();
			return null;
		}
		// Функция возвращает версию установленного драйвера
		//

		public object ПолучитьВерсиюДрайвера(/*ОбъектДрайвера, Параметры, ПараметрыПодключения, ВыходныеПараметры*/)
		{
			//Результат = Истина;
			//ВыходныеПараметры.Добавить(НСтр("ru='Установлен'"));
			//ВыходныеПараметры.Добавить(НСтр("ru='Не определена'"));
			return null;
		}
		// функция преобразует строковое представление версии (с тремя точками) к числовому (пригодному для сравнения)

		public object ВерсияСтрокаВЧисло(/*ВерсияСтрока*/)
		{
			return null;
		}
		// функция преобразует суффикс/префикс в символьную строку для передачи в драйвер
		// из формата #13#10
		// из формата 13(Строка) или  10(Число)
		// из формата (13)CR

		public object СПВСимволы(/*СуффиксНомер, ПоУмолчанию*/)
		{
			//Номер  = СуффиксНомер;
			//СуффиксДрайвера = "";
			//Позиция = Найти(Номер, "#");
			if(true/*Позиция = 0*/)
			{
			}
			//Номер = Сред(Номер, Найти(Номер, "#") + 1);
			return null;
		}
	}
}

