﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПрохождениеКурсаОбученияДополнительный
	{
		////////////////////////////////////////////////////////////////////////////////
		// Вспомогательные процедуры, функции
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции объекта
		////////////////////////////////////////////////////////////////////////////////
		// Процедуры, функции для работы формы

		public void СобытиеПоКнопкеМероприятие(/*ЭтаФорма, ЭтотОбъект*/)
		{
			/*// Проверка на запись. Если не записан - записать надо или отмена действия.
*/
			if(true/*НЕ ЭтотОбъект.Проведен*/)
			{
				//Вопрос("Сначала проведите документ", РежимДиалогаВопрос.ОК,,);
			}
			if(true/*ЭтаФорма.Модифицированность*/)
			{
				//Отказ = Ложь;
				if(true/*Вопрос("Перед созданием мероприятия документ необходимо записать. Записать документ?", РежимДиалогаВопрос.ОКОтмена,, КодВозвратаДиалога.ОК,) = КодВозвратаДиалога.ОК*/)
				{
				}
				if(true/*Отказ*/)
				{
				}
			}
			if(true/*ЭтотОбъект.Мероприятие.Пустая()*/)
			{
				/*// Если курс помечен как пройденный, спросить "а стоит ли планировать?"
*/
				//Отказ = Ложь;
				if(true/*ЭтотОбъект.ФактЗавершенияКурса*/)
				{
					//ОтветНаВопрос = Вопрос("Данный курс помечен как пройденный. Надо планировать его проведение?", РежимДиалогаВопрос.ДаНет);
					if(true/*ОтветНаВопрос = КодВозвратаДиалога.Нет*/)
					{
						//Отказ = Истина;
					}
				}
				if(true/*НЕ Отказ*/)
				{
					/*// Создать мероприятие
*/
					//ИмяМероприятия = Строка(ЭтотОбъект.КурсОбучения) + ". " + Строка(ЭтотОбъект.Ответственный) + ". " + Строка(ЭтотОбъект.ОбучающиесяРаботники.Количество()) + " Чел.";
					//НовоеМероприятие = Справочники.Мероприятия.СоздатьЭлемент();
					//НовоеМероприятие.Наименование = ИмяМероприятия;
					//НовоеМероприятие.Записать();
					/*// Скопировать занятия в состав мероприятия
*/
					/*// Присвоить новое мероприятие реквизиту мероприятие. Открыть форму
*/
					//ЭтотОбъект.Мероприятие = НовоеМероприятие.Ссылка;
					//ЭтотОбъект.Мероприятие.ПолучитьФорму("ФормаЭлемента").Открыть();
				}
			}
			/*// Название кнопки "Мероприятия"
*/
			if(true/*ЭтотОбъект.Мероприятие.Пустая()*/)
			{
				//ЭтаФорма.ЭлементыФормы.ДействияФормы.Кнопки.ОрганизацияОбучения.Кнопки.Мероприятие.Текст = "Создать мероприятие";
			}
			/*// Записать документ еще раз.
*/
			//ЭтотОбъект.Записать();
		}

		public void СобытиеПоКнопкеЗанятость(/*ЭтаФорма, ЭтотОбъект*/)
		{
			//ДокументУчастияВМероприятии = ЭтотОбъект.ДокументУчастияВМероприятии;
			//ЭлементыФормы = ЭтаФорма.ЭлементыФормы;
			/*// создает или открывает документ "Участие в мероприятии"
*/
			if(true/*ЭтотОбъект.Мероприятие.Пустая()*/)
			{
				//Вопрос("Сначала создайте мероприятие", РежимДиалогаВопрос.ОК,,);
			}
			if(true/*ДокументУчастияВМероприятии.Пустая()*/)
			{
				/*// Создать мероприятие
*/
				//ИмяМероприятия = Строка(ЭтотОбъект.КурсОбучения) + ". " + Строка(ЭтотОбъект.Ответственный) + ". " + Строка(ЭтотОбъект.ОбучающиесяРаботники.Количество()) + " Чел.";
				//НовоеУчастие = Документы.УчастиеВМероприятиях.СоздатьДокумент();
				//НовоеУчастие.Мероприятие = ЭтотОбъект.Мероприятие.Ссылка;
				//НовоеУчастие.Ответственный = ЭтотОбъект.Ответственный;
				//НовоеУчастие.Дата = ТекущаяДата();
				/*// Скопировать занятия в состав мероприятия
*/
				/*// Для каждой части мероприятия
*/
				//НаборЧастейМероприятия = Справочники.СоставМероприятия.Выбрать(,ЭтотОбъект.Мероприятие.Ссылка,,);
				while(true/*НаборЧастейМероприятия.Следующий()*/)
				{
					//ЧастьМероприятия = НаборЧастейМероприятия.Ссылка;
				}
				/*;
		
		НовоеУчастие.Записать();*/
				//ДокументУчастияВМероприятии = НовоеУчастие.Ссылка;
				//ДокументУчастияВМероприятии.ПолучитьФорму("ФормаДокумента").Открыть();
			}
			if(true/*ДокументУчастияВМероприятии.Пустая()*/)
			{
				//ЭлементыФормы.ДействияФормы.Кнопки.ОрганизацияОбучения.Кнопки.Занятость.Текст = "Запланировать занятость";
			}
		}
	}
}

