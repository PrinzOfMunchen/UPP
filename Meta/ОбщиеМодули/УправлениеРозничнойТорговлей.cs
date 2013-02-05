﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class УправлениеРозничнойТорговлей
	{
		// Процедура проверяет корректность информационной карты. Если тип карты некорректен, то он очищается,
		// и выдается соответствующее сообщение.
		//
		// Параметры:
		//  ИнформационнаяКарта - информационная карта, который нужно проверить.
		//  ТипКарты - нужный тип карты.
		//

		public void ПроверитьКорректностьИнформационнойКарты(/*ИнформационнаяКарта, ТипКарты*/)
		{
			if(true/*ЗначениеЗаполнено(ИнформационнаяКарта)*/)
			{
				if(true/*ИнформационнаяКарта.ТипКарты <> ТипКарты*/)
				{
					//Сообщить("В данном контексте можно выбирать только дисконтные карты.");
					//ИнформационнаяКарта = Неопределено;
				}
			}
		}
		// ПроверитьКорректностьИнформационнойКарты()
		// Процедура открывает форму выбора справочника "ИнформационныеКарты" с переданным отбором по типу информационной карты.
		//
		// Параметры:
		//  ЭлементФормы - элемент формы, в котором инициирован выбор.
		//  ТипКарты - нужный тип карты.
		//  СтандартнаяОбработка - Флаг стандартной обработки выбора. Здесь сбрасывается.
		//

		public void НачалоВыбораИнформационнойКарты(/*ЭлементФормы, ТипКарты, СтандартнаяОбработка*/)
		{
			//СтандартнаяОбработка = Ложь;
			//ФормаВыбора = Справочники.ИнформационныеКарты.ПолучитьФормуВыбора(, ЭлементФормы);
			//ФормаВыбора.ПараметрВыборГруппИЭлементов = ЭлементФормы.ВыборГруппИЭлементов;
			//ФормаВыбора.СправочникСписок.Отбор.ТипКарты.Установить(ТипКарты);
			//ФормаВыбора.ЭлементыФормы.СправочникСписок.НастройкаОтбора.ТипКарты.Доступность = Ложь;
			//ФормаВыбора.ЭлементыФормы.СправочникСписок.ТекущаяСтрока = ЭлементФормы.Значение;
			//ФормаВыбора.Открыть();
		}
		// НачалоВыбораИнформационнойКарты()
		// Процедура проверяет тип оплаты в строках переданной ТЧ.
		//
		// Параметры:
		//  ДокументОбъект - объект проводимого документа.
		//  ИмяТабличнойЧасти - имя ТЧ документа.
		//  ТаблицаЗначений - таблица значений или ТЧ, в которой нужно выполнить проверку.
		//  Отказ - флаг отказа в проведении.
		//  Заголовок - строка, заголовок сообщения об ошибке проведения.
		//  ТипОплаты - нужный тип оплаты.
		//

		public void ПроверитьКорректностьТипаОплатыВТЧ(/*ДокументОбъект, ИмяТабличнойЧасти,
             ТаблицаЗначений, Отказ, Заголовок, ТипОплаты*/)
		{
			//ПредставлениеТабличнойЧасти = ДокументОбъект.Метаданные().ТабличныеЧасти[ИмяТабличнойЧасти].Представление();
			//СтрокаОкончанияСообщенияОбОшибке = "Выбран вид оплаты неверного типа!";
			//СтруктураСложныхКритериев = Новый Структура;
			//СтруктураСложныхКритериев.Вставить("ТипОплаты", ВидСравнения.НеРавно);
			/*Выборка = ОбщегоНазначения.ОтобратьСтрокиПоКритериям(ТаблицаЗначений, Новый Структура("ТипОплаты", ТипОплаты),
	   СтруктураСложныхКритериев).Выбрать();*/
			while(true/*Выборка.Следующий()*/)
			{
				/*СтрокаНачалаСообщенияОбОшибке = "В строке номер """+ СокрЛП(Выборка.НомерСтроки)
		   + """ табличной части """ + ПредставлениеТабличнойЧасти + """: ";*/
				/*ОбщегоНазначения.СообщитьОбОшибке(СтрокаНачалаСообщенияОбОшибке + СтрокаОкончанияСообщенияОбОшибке,
		                    Отказ, Заголовок);*/
			}
			//;;
		}
		// ПроверитьКорректностьТипаОплатыВТЧ()
		// Процедура проверяет корректность вида оплаты. Если вид оплаты некорректен, то он очищается,
		// и выдается соответствующее сообщение.
		//
		// Параметры:
		//  ВидОплаты - Вид оплаты, который нужно проверить.
		//  ТипОплаты - Нужный тип оплаты.
		//

		public void ПроверитьКорректностьВидаОплаты(/*ВидОплаты, ТипОплаты*/)
		{
			if(true/*ЗначениеЗаполнено(ВидОплаты)*/)
			{
				if(true/*ВидОплаты.ТипОплаты <> ТипОплаты*/)
				{
					//Сообщить("В данном контексте можно выбирать только вид оплаты с типом """ + ТипОплаты + """.");
					//ВидОплаты = Неопределено;
				}
			}
		}
		// ПроверитьКорректностьВидаОплаты()
		// Процедура открывает форму выбора справочника "ВидыОплатЧекаККМ" с переданным отбором по типу оплаты.
		//
		// Параметры:
		//  ЭлементФормы - элемент формы, в котором инициирован выбор.
		//  ТипОплаты - нужный тип оплаты.
		//  СтандартнаяОбработка - Флаг стандартной обработки выбора. Здесь сбрасывается.
		//

		public void НачалоВыбораВидаОплатыЧекаККМ(/*ЭлементФормы, ТипОплаты, СтандартнаяОбработка*/)
		{
			//СтандартнаяОбработка = Ложь;
			//ФормаВыбора = Справочники.ВидыОплатЧекаККМ.ПолучитьФормуВыбора(, ЭлементФормы);
			//ФормаВыбора.ПараметрВыборГруппИЭлементов = ЭлементФормы.ВыборГруппИЭлементов;
			//ЭлементОтбора = ФормаВыбора.СправочникСписок.Отбор.ТипОплаты;
			if(true/*ТипЗнч(ТипОплаты) = Тип("СписокЗначений")*/)
			{
				//ЭлементОтбора.ВидСравнения = ВидСравнения.ВСписке;
				//ЭлементОтбора.Значение = ТипОплаты;
				//ЭлементОтбора.Использование = Истина;
			}
			//ФормаВыбора.ЭлементыФормы.СправочникСписок.НастройкаОтбора.ТипОплаты.Доступность = Ложь;
			//ФормаВыбора.ЭлементыФормы.СправочникСписок.ТекущаяСтрока = ЭлементФормы.Значение;
			//ФормаВыбора.Открыть();
		}
		// НачалоВыбораВидаОплатыЧекаККМ()
		// Функция возвращает в виде соответствия тарифы торговой уступки по договору эквайринга.
		//
		// Параметры:
		//  ДоговорЭквайринга - нужный договор эквайринга.
		//
		// Возвращаемое значение:
		//  Соответствие - соответствие тарифов торговой уступки.
		//

		public object СформироватьСоответствиеТарифовЭквайринг(/*ДоговорЭквайринга*/)
		{
			//СоответствиеТарифов = Новый Соответствие;
			/*Запрос = Новый Запрос("
	|ВЫБРАТЬ
	|	Тарифы.ВидОплаты КАК ВидОплаты,
	|	Тарифы.ПроцентТорговойУступки КАК ПроцентТорговойУступки
	|ИЗ
	|	Справочник.ДоговорыЭквайринга.ТарифыЗаРасчетноеОбслуживание КАК Тарифы
	|ГДЕ
	|	Тарифы.Ссылка = &ДоговорЭквайринга
	|");*/
			//Запрос.УстановитьПараметр("ДоговорЭквайринга", ДоговорЭквайринга);
			//Выборка = Запрос.Выполнить().Выбрать();
			while(true/*Выборка.Следующий()*/)
			{
				//СоответствиеТарифов.Вставить(Выборка.ВидОплаты, Выборка.ПроцентТорговойУступки);
			}
			return null;
		}
		// СформироватьСоответствиеТарифовЭквайринг()
		// Функция возвращает процент торговой уступки для переданных
		// договора эквайринга и вида оплаты.
		//
		// Параметры:
		//  ДоговорЭквайринга - договор эквайринга, по которому нужно получить % торговой уступки.
		//  ВидОплаты - вид оплаты, для которого  нужно получить % торговой уступки.
		//
		// Возвращаемое значение:
		//  Число. Процент торговой уступки. 0 - если не найден.
		//

		public object ПолучитьПроцентТорговойУступки(/*ДоговорЭквайринга, ВидОплаты*/)
		{
			/*Запрос = Новый Запрос("
	|ВЫБРАТЬ ПЕРВЫЕ 1
	|	Тарифы.ПроцентТорговойУступки КАК ПроцентТорговойУступки
	|ИЗ
	|	Справочник.ДоговорыЭквайринга.ТарифыЗаРасчетноеОбслуживание КАК Тарифы
	|ГДЕ
	|	Тарифы.Ссылка = &ДоговорЭквайринга
	|	И Тарифы.ВидОплаты = &ВидОплаты
	|");*/
			//Запрос.УстановитьПараметр("ДоговорЭквайринга", ДоговорЭквайринга);
			//Запрос.УстановитьПараметр("ВидОплаты", ВидОплаты);
			//Выборка = Запрос.Выполнить().Выбрать();
			if(true/*Выборка.Следующий()*/)
			{
				//ПроцентТорговойУступки = Выборка.ПроцентТорговойУступки;
			}
			return null;
		}
		// ПолучитьПроцентТорговойУступки()
		// Получает продажную цену по переданным параметрам.
		//
		// Параметры:
		//  ДатаЦен - дата, на которую нужно получить цену.
		//  Номенклатура - номенклатура, для которой нужно получить цену.
		//  ХарактеристикаНоменклатуры - характеристика номенклатуры, для которой нужно получить цену.
		//  Склад - склад, на котором нужно получить цену.
		//
		// Возвращаемое значение:
		//  Число - найденная цена. Если цена не найдена - возвращается 0.
		//

		public object ПолучитьПродажнуюЦену(/*ДатаЦен, Номенклатура, ХарактеристикаНоменклатуры, Склад,
                              УсловиеПродаж = Неопределено*/)
		{
			//ПродажнаяЦена = 0;
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("Дата", Ценообразование.ПолучитьАктуальнуюДатуРасчетаЦен(ДатаЦен));
			//Запрос.УстановитьПараметр("Номенклатура", Номенклатура);
			//Запрос.УстановитьПараметр("Характеристики", Ценообразование.ПолучитьМассивХарактеристик(ХарактеристикаНоменклатуры));
			//Запрос.УстановитьПараметр("Склад", Склад);
			/*ТекстЗапроса = "
	|ВЫБРАТЬ ПЕРВЫЕ 1
	|	ЦеныПродажные.Цена КАК Цена
	|ИЗ
	|	РегистрСведений.ЦеныАТТ.СрезПоследних(&Дата, Склад = &Склад
	|	   И Номенклатура = &Номенклатура
	|	   И ХарактеристикаНоменклатуры В (&Характеристики)) КАК ЦеныПродажные
	|УПОРЯДОЧИТЬ ПО
	|	ЦеныПродажные.ХарактеристикаНоменклатуры УБЫВ
	|";*/
			//Запрос.Текст = ТекстЗапроса;
			//Выборка = Запрос.Выполнить().Выбрать();
			if(true/*Выборка.Следующий()*/)
			{
				//ПродажнаяЦена = Выборка.Цена;
				//Ценообразование.ИзменитьЦенуПоУсловиюПродаж(ДатаЦен, Номенклатура, УсловиеПродаж, ПродажнаяЦена);
			}
			return null;
		}
		// ПолучитьПродажнуюЦену()
		// Процедура проверяет в строках с видом склада "Розничный" заполнено ли поле "СуммаПродажная".
		//
		// Параметры:
		//  ДокументОбъект - объект проводимого документа.
		//  ИмяТабличнойЧасти - имя ТЧ документа.
		//  ТаблицаЗначений - таблица значений или ТЧ, в которой нужно выполнить проверку.
		//  Отказ - флаг отказа в проведении.
		//  Заголовок - строка, заголовок сообщения об ошибке проведения.
		//  ИмяКолонкиВидСклада - название колонки, содержащей вид склада.
		//

		public void ПроверитьЧтоДляРозничныхСкладовЗаполненаСуммаПродажная(/*ДокументОбъект, ИмяТабличнойЧасти,
             ТаблицаЗначений, Отказ, Заголовок, ИмяКолонкиВидСклада = Неопределено*/)
		{
			//ПредставлениеТабличнойЧасти = ДокументОбъект.Метаданные().ТабличныеЧасти[ИмяТабличнойЧасти].Представление();
			//СтруктураКритериев = Новый Структура;
			//СтруктураКритериев.Вставить("СуммаПродажная", 0);
			if(true/*ИмяКолонкиВидСклада <> Неопределено*/)
			{
				//СтруктураКритериев.Вставить(ИмяКолонкиВидСклада, Перечисления.ВидыСкладов.Розничный);
			}
			//СтрокаОкончанияСообщенияОбОшибке = "Не задана цена АТТ." + Символы.ПС + "Необходимо выполнить переоценку!";
			//НайденныеСтроки = ТаблицаЗначений.НайтиСтроки(СтруктураКритериев);
		}
		// ПроверитьЧтоДляРозничныхСкладовЗаполненаСуммаПродажная()
		// Процедура заполняет в переданной ТЧ колонку "СуммаПродажная".
		//
		// Параметры:
		//  ТаблицаТоваров - таблица значений или ТЧ, в которой нужно колонку "СуммаПродажная" заполнить.
		//  ТаблицаПоЦенам - таблица значений, содержащая продажные цены.
		//  ИмяКолонкиВидСклада - название колонки, содержащей вид склада.
		//

		public void ЗаполнитьКолонкуСуммаПродажная(/*ТаблицаТоваров, ТаблицаПоЦенам, ИмяКолонкиВидСклада = Неопределено, ИмяКолонкиКоличество = "Количество"*/)
		{
			//ЕстьХарактеристика = (ТаблицаТоваров.Колонки.Найти("ХарактеристикаНоменклатуры") <> Неопределено);
			if(true/*ЕстьХарактеристика*/)
			{
				//СтрокаИндексов = "Номенклатура, Склад, ХарактеристикаНоменклатуры";
			}
			//ТаблицаПоЦенам.Индексы.Добавить(СтрокаИндексов);
			//СтруктураПоискаЦены = Новый Структура;
			//ПустаяХарактеристика = Справочники.ХарактеристикиНоменклатуры.ПустаяСсылка();
			//ВидСкладаРозничный = Перечисления.ВидыСкладов.Розничный;
		}
		// ЗаполнитьКолонкуСуммаПродажная()
		// Определяет наличие розничного склада в переданной ТЧ.
		//
		// Параметры:
		//  ТаблицаТоваров - таблица значений или ТЧ.
		//  ИмяКолонкиСклад - название колонки, содержащей склад.
		//  ИмяКолонкиВидСклада - название колонки, содержащей вид склада.
		//
		// Возвращаемое значение:
		//  Булево - Истина, если в переданной ТЧ есть розничный склад.
		//

		public object ОпределитьНаличиеРозничногоСклада(/*ТаблицаТоваров, ИмяКолонкиСклад, ИмяКолонкиВидСклада*/)
		{
			if(true/*ТаблицаТоваров.Колонки.Найти(ИмяКолонкиСклад) = Неопределено
	 Или ТаблицаТоваров.Колонки.Найти(ИмяКолонкиВидСклада) = Неопределено*/)
			{
				//ЕстьРозничныйСклад = Ложь;
			}
			return null;
		}
		// ОпределитьНаличиеРозничногоСклада()
		// Выполняет запрос по продажным ценам по переданным параметрам.
		//
		// Параметры:
		//  ДатаЦен - дата, на которую нужно получить цены.
		//  СписокСкладов - список складов, по которым нужно получить цены.
		//  СписокНоменклатуры - список номенклатуры, для которой нужно получить цены.
		//
		// Возвращаемое значение:
		//  РезультатЗапроса - результат выполненого запроса по продажным ценам.
		//

		public object СформироватьЗапросПоПродажнымЦенам(/*ДатаЦен, СписокСкладов, СписокНоменклатуры*/)
		{
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("Дата", ДатаЦен);
			//Запрос.УстановитьПараметр("СписокСкладов", СписокСкладов);
			//Запрос.УстановитьПараметр("СписокНоменклатуры", СписокНоменклатуры);
			/*ТекстЗапроса = "
	|ВЫБРАТЬ
	|	ЦеныПродажные.Склад КАК Склад,
	|	ЦеныПродажные.Номенклатура КАК Номенклатура,
	|	ЦеныПродажные.ХарактеристикаНоменклатуры КАК ХарактеристикаНоменклатуры,
	|	ЦеныПродажные.Цена КАК Цена
	|ИЗ
	|	РегистрСведений.ЦеныАТТ.СрезПоследних(&Дата, Склад В (&СписокСкладов)
	|	   И Номенклатура В (&СписокНоменклатуры)) КАК ЦеныПродажные
	|";*/
			//Запрос.Текст = ТекстЗапроса;
			return null;
		}
		// СформироватьЗапросПоПродажнымЦенам()
		// Рассчитывает величину розничной цены по цене поставки и проценту розничной наценки.
		// Розничная цена всегда в рублях и со всеми налогами.
		// Получается из цены поставки, увеличенной на процент розничной наценки,
		// пересчитанной в рубли, увеличенной при необходимости на величину налогов,
		// округленной по параметрам округления розничного типа цен.
		//
		// Параметры:
		//  ЦенаПоставки                   - число, цена поставки, по которой надо рассчитать розничную цену;
		//  ВалютаПоставки                 - ссылка на справочник, определяет валюту цены поставки,
		//                                   из которой надо рассчитать розничную цену;
		//  КурсПоставки                   - число, курс валюты, в которой задана цена поставки;
		//  КратностьПоставки              - число, кратность валюты, в которой задана цена поставки;
		//  ВалютаРегламентированногоУчета - валюта регламентированного учета
		//  ПроцентРозничнойНаценки        - число, процент розничной наценки на цену поставки;
		//  ЦенаПоставкиВключаетНДС        - булево, признак того, что в цену поставки включен НДС;
		//  СтавкаНДС                      - число, определяет ставку НДС в цене поставки;
		//  ТипЦенРозничнойТорговли        - ссылка на справочник, определяет тип розничной цены.
		//  ЕдиницаЦены                    - ссылка на элемент справочника "Единицы измерения",
		//                                   определяет для какой единицы указана цена,
		//  ЕдиницаХранения                - ссылка на элемент справочника "Единицы измерения",
		//                                   определяет единицу хранения номенклатуры,
		//
		// Возвращаемое значение:
		//  Рассчитанное значение розничной цены.
		//

		public object РассчитатьРозничнуюЦену(/*ЦенаПоставки, ВалютаПоставки, КурсПоставки,КратностьПоставки,
	                            ВалютаРегламентированногоУчета, ПроцентРозничнойНаценки,
	                            ЦенаПоставкиВключаетНДС, СтавкаНДС,
	                            ТипЦенРозничнойТорговли, ЕдиницаЦены, ЕдиницаХранения*/)
		{
			/*// Увеличиваем на процент розничной наценки.
*/
			//РозничнаяЦена = ЦенаПоставки * (100 + ПроцентРозничнойНаценки) / 100;
			/*// Пересчитаем цену из единицы цены в единицу хранения остатков.
*/
			//РозничнаяЦена = Ценообразование.ПересчитатьЦенуПриИзмененииЕдиницы(РозничнаяЦена, ЕдиницаЦены, ЕдиницаХранения);
			/*// Пересчитываем в рубли.
*/
			/*РозничнаяЦена = МодульВалютногоУчета.ПересчитатьИзВалютыВВалюту(РозничнаяЦена, ВалютаПоставки,
	                                           ВалютаРегламентированногоУчета, КурсПоставки, 1, КратностьПоставки);*/
			/*// Увеличиваем при необходимости на величину налогов (розничная цена всегда с налогами)
*/
			/*РозничнаяЦена = Ценообразование.ПересчитатьЦенуПриИзмененииФлаговНалогов(РозничнаяЦена,
	                Перечисления.СпособыЗаполненияЦен.ПоЦенамНоменклатуры,
	                ЦенаПоставкиВключаетНДС, Истина, Истина, СтавкаНДС);*/
			/*// Округляем по параметрам округления розничного типа цен.
*/
			if(true/*НЕ ЗначениеЗаполнено(ТипЦенРозничнойТорговли)*/)
			{
				//ПорядокОкругления        = Перечисления.ПорядкиОкругления.Окр0_01;
				//ОкруглятьВБольшуюСторону = Ложь;
			}
			//РозничнаяЦена = Ценообразование.ОкруглитьЦену(РозничнаяЦена, ПорядокОкругления, ОкруглятьВБольшуюСторону);
			return null;
		}
		// РассчитатьРозничнуюЦену()
		// Позволяет получить остатки и цены Товаров в рознице
		//
		// Параметры:
		//  Номенклатура               - ссылка на элемент справочника "Номенклатура", для которого надо получить цены и остаток,
		//  ХарактеристикаНоменклатуры - ссылка на элемент справочника "ХарактеристикиНоменклатуры", для которого надо получить цены и остаток,
		//  Склад                      - ссылка на элемент справочника "СкладыКомпании", для которого надо получить цены и остаток,
		//  Дата                       - дата, на которую надо получить цены и остаток.
		//
		// Возвращаемое значение:
		//  Таблица значений, содержащая найденные цены и остатки.
		//

		public object ПолучитьОстаткиИЦеныВРознице(/*Номенклатура, ХарактеристикаНоменклатуры, Склад = Неопределено,
	                                 Дата = Неопределено*/)
		{
			/*// В качестве оперативных остатков берем текущие.
*/
			//ДатаОстатков = Дата;
			if(true/*Дата <> Неопределено*/)
			{
				//ДатаОстатков = ?(НачалоДня(Дата) = НачалоДня(ТекущаяДата()), Неопределено, Дата);
			}
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("Дата"                      , ДатаОстатков);
			//Запрос.УстановитьПараметр("Номенклатура"              , Номенклатура);
			//Запрос.УстановитьПараметр("Склад"                     , Склад);
			/*Запрос.УстановитьПараметр("ХарактеристикаНоменклатуры", ?(ХарактеристикаНоменклатуры = Неопределено,
	                          Справочники.ХарактеристикиНоменклатуры.ПустаяСсылка(), ХарактеристикаНоменклатуры));*/
			/*Запрос.Текст = "
	|ВЫБРАТЬ
	|	ОстаткиТоваровКомпанииОстатки.КоличествоОстаток,
	|	ОстаткиТоваровКомпанииОстатки.ЦенаВРознице
	|ИЗ
	|	РегистрНакопления.ТоварыВНТТ.Остатки(&Дата, Номенклатура = &Номенклатура "
	+ ?(НЕ ЗначениеЗаполнено(Склад),"", "И Склад = &Склад") + "
	|	И ХарактеристикаНоменклатуры = &ХарактеристикаНоменклатуры
	|	И (ЦенаВРознице > 0)) КАК ОстаткиТоваровКомпанииОстатки";*/
			return null;
		}
		// ПолучитьОстаткиИЦеныВРознице()
		// Формирует список розничных цен для заданных позиций номенклатуры и характеристики на выбранном складе
		// на заданную дату.
		//
		// Параметры:
		//  Номенклатура               - ссылка на справочник, позиция номенклатуры,
		//                               для которой надо получить розничну цену;
		//  Единица                    - ссылка на справочник, единица измерения в которую надо
		//                               пересчитать цену и количество остатка;
		//  ХарактеристикаНоменклатуры - ссылка на справочник, характеристика номенклатуры,
		//                               для которой надо получить розничну цену;
		//  СкладКомпании              - ссылка на справочник, розничный склад компании на котором надо получить
		//                               розничную цену и остаток;
		//  ВалютаРегламентированногоУчета - валюта регламентированного учета
		//  Дата                       - дата, на которую нужна цена в рознице;
		//  Валюта                     - валюта, в которую необходимо пересчитать цены;
		//  Курс                       - курс валюты для пересчета цен;
		//  Кратность                  - кратность валюты для пересчета цен.
		//
		// Возвращаемое значение:
		// Число, выбраное значение розничной цены.
		//

		public object СформироватьСписокРозничныхЦен(/*Номенклатура, Единица, ХарактеристикаНоменклатуры, СкладКомпании,
                                       ВалютаРегламентированногоУчета, Дата = Неопределено,
                                       Валюта = Неопределено, Курс = Неопределено, Кратность = Неопределено,
                                       УчитыватьНДС = Ложь, СуммаВключаетНДС = Ложь, СтавкаНДС = 0*/)
		{
			//СписокЦен = Новый СписокЗначений;
			/*ТаблицаРозничныхЦен = ПолучитьОстаткиИЦеныВРознице(Номенклатура, ХарактеристикаНоменклатуры,
	                                                   СкладКомпании, Дата);*/
			return null;
		}
		// СформироватьСписокРозничныхЦен()
		// Функция возвращает розничную цену для требуемой номенклатуры,
		// на заданную дату, за заданную единицу измерения, пересчитанную в требуемую валюту по заданному курсу.
		//
		// Параметры:
		//  Номенклатура                   - ссылка на элемент справочника "Номенклатура", для которого надо получить цену,
		//  ХарактеристикаНоменклатуры     - ссылка на элемент справочника "ХарактеристикиНоменклатуры", для которого надо получить цену,
		//  Склад                          - ссылка на элемент справочника "Склады компании", определяет склад
		//                                   для которого надо получить цену,
		//  ВалютаРегламентированногоУчета - валюта регламентированного учета
		//  Дата                           - дата, на которую надо получить цену, если не заполнено, то берется рабочая дата
		//  ЕдиницаИзмерения               - ссылка на элемент справочника "Единицы измерения", определяет для какой единицы надо получить
		//                                   цену, если не заполнен, то заполняется единицей цены
		//  Валюта                         - ссылка на элемент справочника "Валюты", определяет валюту. в которой надо вернуть цену,
		//                                   если заполнен, то заполняется валютой цены
		//  Курс                           - число, курс требуемой валюты, если не заполнен, берется курс из регистра
		//                                   сведений "Курсы валют".
		//  Кратность                      - число, кратность требуемой валюты, если не заполнена, берется курс из регистра
		//                                   сведений "Курсы валют".
		//
		// Возвращаемое значение:
		//  Число, рассчитанное значение цены.
		//

		public object ПолучитьРозничнуюЦену(/*Номенклатура, ХарактеристикаНоменклатуры = Неопределено, Склад, ВалютаРегламентированногоУчета,
                              Дата = Неопределено, ЕдиницаИзмерения = Неопределено,
                              Валюта = Неопределено, Курс = 0, Кратность = 1*/)
		{
			/*// Если дата не заполнена, возьмем рабочую дату.
*/
			if(true/*НЕ ЗначениеЗаполнено(Дата)*/)
			{
				//Дата = ОбщегоНазначения.ПолучитьРабочуюДату();
			}
			if(true/*Склад.ВидСклада = Перечисления.ВидыСкладов.НТТ*/)
			{
				/*// Для услуг в качестве розничной цены используется цена компании по заданному в настройках типу цен.
*/
				if(true/*Номенклатура.Услуга*/)
				{
					//ПолученнаяЦена = Ценообразование.ПолучитьЦенуНоменклатуры(Номенклатура, , Склад.ТипЦенРозничнойТорговли, Дата, ЕдиницаИзмерения, Валюта, Курс, Кратность);
					//ЕдиницаЦены    = ЕдиницаИзмерения;
					//ВалютаЦены     = Валюта;
				}
			}
			//ПолученнаяЦена = Ценообразование.ПересчитатьЦенуПриИзмененииЕдиницы(ПолученнаяЦена, ЕдиницаЦены, ЕдиницаИзмерения);
			//ПолученнаяЦена = Ценообразование.ПересчитатьЦенуПриИзмененииВалюты(ПолученнаяЦена, ВалютаЦены, Валюта, Курс, Кратность, Дата);
			return null;
		}
		// ПолучитьРозничнуюЦену()
		// Определяет есть ли в данном документе склад - НТТ,
		// для которого надо указывать цену в рознице.
		//
		// Параметры:
		//  ДокументОбъект - объект редактируемого документа.
		//
		// Возвращаемое значение:
		//  Ссылка на розничный склад, если нет розничного склада, то Неопределено.
		//

		public object ЕстьНТТВДокументе(/*ДокументОбъект*/)
		{
			//МетаданныеДокумента = ДокументОбъект.Метаданные();
			if(true/*МетаданныеДокумента.Реквизиты.Найти("СкладПолучатель") <> Неопределено*/)
			{
				//Склад = ДокументОбъект.СкладПолучатель;
			}
			if(true/*Склад.ВидСклада = Перечисления.ВидыСкладов.НТТ*/)
			{
			}
			return null;
		}
		// ЕстьНТТВДокументе()
		// Функция по префиксу пердприятия и номеру товара предприятия возвращает штрихкод EAN-13 без контрольного символа
		// номер предприятия - строка
		// номер товара - Строка
		// СтрокаНомераТовара - преобразованный к строке номер товара предприятия с дополняющими нулями

		public object ПолучитьШтрихКодПоПредприятияюИНомеруТовара(/*Знач НомерПредприятия, Знач НомерТовара, СтрокаНомераТовара*/)
		{
			//СтрокаНомераТовара = СтрЗаменить(Строка(НомерТовара), Символы.НПП, "");
			//КоличествоДополняющихНулей = 12 - СтрДлина(НомерПредприятия) - СтрДлина(СтрокаНомераТовара);
			return null;
		}
		// Функция определяет доступное значение кода для заданного регистра сведений
		//
		// Параметры
		//  ИмяРегистра – <Строка>
		//              – имя регистра сведений, для которого определяется
		//                доступное значение кода
		//
		// Возвращаемое значение:
		//   <Число>    – значение, которое может быть использовано для новой
		//                записи регистра сведений в качестве кода
		//

		public object ПолучитьНовыйКодДляРегистраСведений(/*ИмяРегистра*/)
		{
			/*Запрос = Новый Запрос(
	"ВЫБРАТЬ
	|	ЕСТЬNULL(МАКСИМУМ(Регистр.Код), 0) КАК Код
	|ИЗ
	|	РегистрСведений." + ИмяРегистра + " КАК Регистр");*/
			//Выборка = Запрос.Выполнить().Выбрать();
			//Выборка.Следующий();
			return null;
		}
		// ПолучитьНовыйКодДляРегистраСведений()
		// Функция возвращает штрихкод для требуемой номенклатуры,
		// на заданную дату, за заданную единицу измерения, пересчитанную в требуемую валюту по заданному курсу.
		//
		// Параметры:
		//  ТипШтрихкода                   - ссылка на элемент плана видов характеристик "ТипыШтрихкодов",
		//  Владелец                       - ссылка на элемент справочника "Номенклатура",
		//  ЕдиницаИзмерения               - ссылка на элемент справочника "Единицы измерения", определяет
		//                                   для какой единицы надо получить штрихкод,
		//  ХарактеристикаНоменклатуры     - ссылка на элемент справочника "Характеристики номенклатуры", определяет
		//                                   для какой характеристики надо получить штрихкод,
		//  СерияНоменклатуры              - ссылка на элемент справочника "Характеристики номенклатуры", определяет
		//                                   для какой характеристики надо получить штрихкод,
		//  КачествоНоменклатуры           - ссылка на элемент справочника "Характеристики номенклатуры", определяет
		//                                   для какой характеристики надо получить штрихкод.
		//
		// Возвращаемое значение:
		//  Строка таблицы значений - результата запроса.
		//

		public object ПолучитьШтрихКод(/*Владелец, ЕдиницаИзмерения = Неопределено, ХарактеристикаНоменклатуры = Неопределено,
	                     СерияНоменклатуры = Неопределено, Качество = Неопределено*/)
		{
			if(true/*ЕдиницаИзмерения = Неопределено*/)
			{
				//ЕдиницаИзмерения = Справочники.ЕдиницыИзмерения.ПустаяСсылка();
			}
			if(true/*ХарактеристикаНоменклатуры = Неопределено*/)
			{
				//ХарактеристикаНоменклатуры = Справочники.ХарактеристикиНоменклатуры.ПустаяСсылка();
			}
			if(true/*СерияНоменклатуры = Неопределено*/)
			{
				//СерияНоменклатуры = Справочники.СерииНоменклатуры.ПустаяСсылка();
			}
			if(true/*Качество = Неопределено*/)
			{
				//Качество = Справочники.Качество.ПустаяСсылка();
			}
			/*Запрос = Новый Запрос("
	|ВЫБРАТЬ ПЕРВЫЕ 1
	|	РегШтрихкоды.ТипШтрихкода,
	|	РегШтрихкоды.Штрихкод
	|ИЗ
	|	РегистрСведений.Штрихкоды КАК РегШтрихкоды
	|ГДЕ
	|	РегШтрихкоды.Владелец = &Владелец
	|	И РегШтрихкоды.ЕдиницаИзмерения = &ЕдиницаИзмерения
	|	И РегШтрихкоды.ХарактеристикаНоменклатуры = &ХарактеристикаНоменклатуры
	|	И РегШтрихкоды.СерияНоменклатуры = &СерияНоменклатуры
	|	И РегШтрихкоды.Качество = &Качество
	|");*/
			//Запрос.УстановитьПараметр("Владелец"                  , Владелец);
			//Запрос.УстановитьПараметр("ЕдиницаИзмерения"          , ЕдиницаИзмерения);
			//Запрос.УстановитьПараметр("ХарактеристикаНоменклатуры", ХарактеристикаНоменклатуры);
			//Запрос.УстановитьПараметр("СерияНоменклатуры"         , СерияНоменклатуры);
			//Запрос.УстановитьПараметр("Качество"                  , Качество);
			//Выборка = Запрос.Выполнить().Выгрузить();
			if(true/*Выборка.Количество() > 0*/)
			{
				//ПолученныйШтрихкод = Выборка[0];
			}
			return null;
		}
		// ПолучитьШтрихКод()
		// Функция по международному сокращению возвращает является ли эта единица измерения весовой или нет

		public object ПолучитьПоМеждународномуСокращениюЭтоВесоваяЕдиница(/*Знач МеждународноеСокращение*/)
		{
			if(true/*ПустаяСтрока(МеждународноеСокращение)*/)
			{
			}
			//Макет = Справочники.КлассификаторЕдиницИзмерения.ПолучитьМакет("КлассификаторЕдиницИзмерения");
			//ОбластьВесоваяЕдиница			= Макет.Области.ВесоваяЕдиница;
			//ОбластьМеждународноеСокращение	= Макет.Области.МеждународноеСокращение;
			/*// пробегаем по всему адресному классификатору и заполняем международное сокращение
*/
			/*// так и не нашли нужное нам сокращение
*/
			return null;
		}
		// процедура добавляет в классификатор единиц измерения
		// элемент с определенным международным сокращением

		public object СоздатьНовыйЭлементКлассификаторЕдиницИзмерения(/*Знач МеждународноеСокращение*/)
		{
			//Макет = Справочники.КлассификаторЕдиницИзмерения.ПолучитьМакет("КлассификаторЕдиницИзмерения");
			//ОбластьКодЧисловой         = Макет.Области.КодЧисловой;
			//ОбластьНаименованиеПолное  = Макет.Области.НаименованиеПолное;
			//ОбластьНаименованиеКраткое = Макет.Области.НаименованиеКраткое;
			//ОбластьМеждународноеСокращение = Макет.Области.МеждународноеСокращение;
			/*// пробегаем по всему адресному классификатору и заполняем международное сокращение
*/
			return null;
		}
		// функция находит классификатор единиц измерения по мехдународному сокращению
		// в случае его отсутствия создает новый элемент

		public object НайтиИлиСоздатьКлассификаторЕдиницИзмеренияПоМеждународномуСокращению(/*Знач МеждународноеСокращение*/)
		{
			if(true/*НЕ ЗначениеЗаполнено(МеждународноеСокращение)*/)
			{
			}
			//ЕдиницаПоКлассификатору = Справочники.КлассификаторЕдиницИзмерения.НайтиПоРеквизиту("МеждународноеСокращение", МеждународноеСокращение);
			if(true/*НЕ ЗначениеЗаполнено(ЕдиницаПоКлассификатору)*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("Не найден классификатор единиц измерения с международным сокращением: " + МеждународноеСокращение);
				//ЕдиницаПоКлассификатору = СоздатьНовыйЭлементКлассификаторЕдиницИзмерения(МеждународноеСокращение);
			}
			return null;
		}
		// Процедура выполняет печать этикеток из переданного доумента.
		//
		// Параметры:
		//  Док - ссылка на документ, из которго нужно напечатать этикетки.
		//  ИмяКолонкиЦена - имя колонки, в которой содержится цена.
		//

		public void НапечататьЭтикеткиИзДокумента(/*Док, ИмяКолонкиЦена = Неопределено*/)
		{
			//МетаданныеДокумента = Док.Метаданные();
			//ИмяДокумента = МетаданныеДокумента.Имя;
			//ЕстьЦена             = (ИмяКолонкиЦена <> Неопределено);
			//ЕстьХарактеристика   = ОбщегоНазначения.ЕстьРеквизитТабЧастиДокумента("ХарактеристикаНоменклатуры", МетаданныеДокумента, "Товары");
			//ЕстьСерия            = ОбщегоНазначения.ЕстьРеквизитТабЧастиДокумента("СерияНоменклатуры", МетаданныеДокумента, "Товары");
			//ЕстьКачество         = ОбщегоНазначения.ЕстьРеквизитТабЧастиДокумента("Качество", МетаданныеДокумента, "Товары");
			//ЕстьЕдиницаИзмерения = ОбщегоНазначения.ЕстьРеквизитТабЧастиДокумента("ЕдиницаИзмерения", МетаданныеДокумента, "Товары");
			/*Запрос = Новый Запрос("
	|ВЫБРАТЬ
	|	Док.Номенклатура КАК Номенклатура,
	|	Док.Количество КАК Количество,
	|	Док.Характеристика КАК Характеристика,
	|	Док.Серия КАК Серия,
	|	Док.Качество КАК Качество,
	|	Док.ЕдиницаИзмерения КАК ЕдиницаИзмерения,
	|	Док.Цена КАК Цена,
	|	" + ?(ЕстьЦена, "&Валюта", "ЗНАЧЕНИЕ(Справочник.Валюты.ПустаяСсылка)") + " КАК Валюта,
	|	РегШК.ТипШтрихкода КАК ТипШтрихкода,
	|	РегШК.Штрихкод КАК Штрихкод
	|ИЗ
	|	(ВЫБРАТЬ
	|		Док.Номенклатура КАК Номенклатура,
	|		Док.Количество КАК Количество,
	|		" + ?(ЕстьХарактеристика, "Док.ХарактеристикаНоменклатуры", "ЗНАЧЕНИЕ(Справочник.ХарактеристикиНоменклатуры.ПустаяСсылка)") + " КАК Характеристика,
	|		" + ?(ЕстьСерия, "Док.СерияНоменклатуры", "ЗНАЧЕНИЕ(Справочник.СерииНоменклатуры.ПустаяСсылка)") + " КАК Серия,
	|		" + ?(ЕстьКачество, "Док.Качество", "ЗНАЧЕНИЕ(Справочник.Качество.Новый)") + " КАК Качество,
	|		" + ?(ЕстьЕдиницаИзмерения, "Док.ЕдиницаИзмерения", "Док.Номенклатура.ЕдиницаХраненияОстатков") + " КАК ЕдиницаИзмерения,
	|		" + ?(ЕстьЦена, "Док." + ИмяКолонкиЦена, "0") + " КАК Цена
	|	ИЗ
	|		Документ." + ИмяДокумента + ".Товары КАК Док
	|	ГДЕ
	|		Док.Ссылка = &Док
	|	) КАК Док
	|ВНУТРЕННЕЕ СОЕДИНЕНИЕ
	|	РегистрСведений.Штрихкоды КАК РегШК
	|ПО
	|	РегШК.Владелец = Док.Номенклатура
	|	И РегШК.ЕдиницаИзмерения = Док.ЕдиницаИзмерения
	|	И РегШК.ХарактеристикаНоменклатуры = Док.Характеристика
	|	И РегШК.СерияНоменклатуры = Док.Серия
	|	И РегШК.Качество = Док.Качество
	|");*/
			//Запрос.УстановитьПараметр("Док", Док);
			if(true/*ЕстьЦена*/)
			{
				//Запрос.УстановитьПараметр("Валюта", глЗначениеПеременной("ВалютаРегламентированногоУчета"));
			}
			//ПечатьЭтикеток(Запрос.Выполнить().Выгрузить());
		}
		// НапечататьЭтикеткиИзДокумента()
		// Печать этикеток со штрихкодом
		//

		public void ПечатьЭтикеток(/*Товары = Неопределено*/)
		{
			//ФормаОбработкиЭтикеток = Обработки.ПечатьЭтикеток.Создать().ПолучитьФорму();
			if(true/*ТипЗнч(Товары) = Тип ("ТаблицаЗначений")*/)
			{
				//ФормаОбработкиЭтикеток.мВнешняяТаблицаТоваров = Товары;
			}
			//ФормаОбработкиЭтикеток.Открыть();
		}
		// ПечатьЭтикеток()
		// Проверяет необходимость открытия формы "РегистрацияПродаж" документа "ЧекККМ.
		//

		public void ЗапускИнтерфейсаКассира(/*ТекущийПользователь, ВключенИнтерфейсКассира*/)
		{
			//ПользовательИБ = ПользователиИнформационнойБазы.ТекущийПользователь();
			if(true/*ПользовательИБ <> Неопределено
	   И ПользовательИБ.ОсновнойИнтерфейс <> Неопределено
	   И ПользовательИБ.ОсновнойИнтерфейс.Имя = "ИнтерфейсКассира"*/)
			{
				/*//Задействуем интерфейс кассира
*/
				//ВключенИнтерфейсКассира = Истина;
				//Администратор = Ложь;
				//Кассир = Ложь;
				//ИнтерфейсКассира = ГлавныйИнтерфейс.ИнтерфейсКассира;
				//ИнтерфейсКассира.Переключаемый = Истина;
				//ИнтерфейсКассира.Видимость     = Истина;
				if(true/*РольДоступна("АдминистраторККМ")
		 Или РольДоступна("АдминистраторККМСОграничениемПравДоступа")*/)
				{
					/*//Администратор
*/
					//Администратор = Истина;
				}
				//Отказ = Ложь;
				//Причина = "";
				//КассаККМ = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(ТекущийПользователь, "ОсновнаяКассаККМ");
				if(true/*КассаККМ = Справочники.КассыККМ.ПустаяСсылка()*/)
				{
					//Предупреждение("Для пользователя """+ ТекущийПользователь+""" не выбрана касса по умолчанию!");
					//Отказ = Истина;
					//Причина = "Не выбрана касса по умолчанию";
				}
				//Склад = УправлениеПользователями.ПолучитьЗначениеПоУмолчанию(ТекущийПользователь, "ОсновнойСклад");
				if(true/*Склад = Неопределено
		 Или Склад = Справочники.Склады.ПустаяСсылка()*/)
				{
					//Предупреждение("Для пользователя """+ ТекущийПользователь+""" не выбран склад по умолчанию!");
					//Отказ = Истина;
					//Причина = "Не выбран склад по умолчанию";
				}
				//ФР = Неопределено;
				if(true/*Не Отказ*/)
				{
					//МассивФР = ПолучитьСерверТО().ПолучитьСписокУстройств(Перечисления.ВидыТорговогоОборудования.ФискальныйРегистратор, КассаККМ);
					if(true/*МассивФР.Количество() <> 0
			 Или (УстановленЕНВДОрганизации(КассаККМ.Владелец)
			   И КассаККМ.ФормироватьНефискальныеЧеки)*/)
					{
						if(true/*Склад.НомерСекции = 0*/)
						{
							//Предупреждение("У склада: """ + Склад + """не указан номер секции!");
							//Отказ = Истина;
							//Причина = "У склада не указан номер секции";
						}
					}
				}
				if(true/*Не Отказ*/)
				{
					//Документы.ЧекККМ.СоздатьДокумент().ПолучитьФорму("ФормаРегистрацииПродаж",).Открыть();
				}
			}
		}
		// Проверка установленного у организации признака "Розничная торговля облагается ЕНВД"
		//

		public object УстановленЕНВДОрганизации(/*Организация*/)
		{
			/*Запрос = Новый Запрос("
	|ВЫБРАТЬ
	|	УчетнаяПолитикаОрганизацийСрезПоследних.РозничнаяТорговляОблагаетсяЕНВД
	|ИЗ
	|	РегистрСведений.УчетнаяПолитикаОрганизаций.СрезПоследних(&Дата, Организация = &Ссылка) КАК УчетнаяПолитикаОрганизацийСрезПоследних
	|");*/
			//Запрос.УстановитьПараметр("Ссылка", Организация);
			//Запрос.УстановитьПараметр("Дата"  , ТекущаяДата());
			//Выборка = Запрос.Выполнить().Выбрать();
			//ОрганизацияОблагаетсяЕНВД = ?(Выборка.Следующий(), Выборка.РозничнаяТорговляОблагаетсяЕНВД, Ложь);
			return null;
		}
		// Возвращает значение типа штрихкода для использования в ЭУ
		// "1С:Печать штрихкодов"
		//
		// Параметры
		// 	ТипКода -	ПланыВидовХарактеристик.ТипыШтрихкодов - тип, значение для которого
		//				нужно получить
		//
		// Возвращаемое значение:
		//   Число, которое может быть присвоено свойству ЭУ "ТипКода"
		//

		public object ПолучитьЗначениеТипаШтрихкодаДляЭУ(/*ТипКода*/)
		{
			if(true/*ТипКода = ПланыВидовХарактеристик.ТипыШтрихкодов.EAN8*/)
			{
				//Значение = 0;
			}
			return null;
		}
		// ПолучитьЗначениеТипаШтрихкодаДляЭУ()
		// Процедура осуществляет ввод документа "ПереоценкаТоваровВРознице" на основании прихода товара.
		// Вызывается из форм документов поступления.
		//
		// Параметры:
		//  ДокументОбъект - объект документа, вызвавшего процедуру.
		//  ФормаДокумента - форма документа, вызвавшего процедуру.
		//

		public void ВвестиПереоценкуНаОснованииПрихода(/*ДокументОбъект, ФормаДокумента*/)
		{
			if(true/*ДокументОбъект.Товары.Количество() = 0*/)
			{
				//Предупреждение("Не заполнена табличная часть ""Товары"".");
			}
			if(true/*ДокументОбъект.Модифицированность()*/)
			{
				/*Ответ = Вопрос("Перед выполнением переоценки документ необходимо записать." + Символы.ПС +
		               "Записать?", РежимДиалогаВопрос.ДаНет);*/
				if(true/*Ответ = КодВозвратаДиалога.Нет*/)
				{
				}
				if(true/*ДокументОбъект.Проведен*/)
				{
				}
			}
			//ОбъектПереоценки = Документы.ПереоценкаТоваровВРознице.СоздатьДокумент();
			//ОбъектПереоценки.Заполнить(ДокументОбъект.Ссылка);
			//ФормаПереоценки = ОбъектПереоценки.ПолучитьФорму();
			//ФормаПереоценки.ПараметрОснование = ДокументОбъект.Ссылка;
			//ФормаПереоценки.Открыть();
		}
		// ВвестиПереоценкуНаОснованииПрихода()
	}
}

