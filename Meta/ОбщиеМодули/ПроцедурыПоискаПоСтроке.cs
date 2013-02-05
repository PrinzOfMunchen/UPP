﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V82.ОбщиеМодули
{
	public partial class ПроцедурыПоискаПоСтроке
	{
		////////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ И ФУНКЦИИ ОБЕСПЕЧЕНИЯ ПОИСКА ПО СТРОКЕ В ПОЛЕ ВВОДА
		// Процедура инициализирует параметры обработки поиска по строке

		public void ИнициализироватьПараметрыОбработкиПоискаПоСтроке(/*ОбработкаПоискаПоСтроке, ТекстПоискаПоСтроке, ПоследнееЗначениеЭлементаПоискаПоСтроке*/)
		{
			//ОбработкаПоискаПоСтроке                 = Ложь;
			//ТекстПоискаПоСтроке                     = "";
			//ПоследнееЗначениеЭлементаПоискаПоСтроке = Неопределено;
		}
		// Функция формирует ограничение для запроса по полю

		public object СформироватьОграничениеПоПолюВхождениеВНачало(/*ИмяПоля, ТипЗначенияПоиска*/)
		{
			//Ограничение = ИмяПоля + ?(ТипЗначенияПоиска = Тип("Строка"), (" ПОДОБНО &ТекстАвтоПодбора СПЕЦСИМВОЛ ""~"""), (" =  &ТекстАвтоПодбораЧисло"));
			return null;
		}
		//Функция Определяет тип ограничений по полю

		public object ОпределитьТипОграниченийПоПолю(/*ИмяЭлемента, МетаданныеОбъекта, ДляСправочника = Истина*/)
		{
			if(true/*ДляСправочника*/)
			{
				if(true/*ИмяЭлемента <> "Наименование" И ИмяЭлемента <> "Код"*/)
				{
					//ТипЗначенияПоиска = МетаданныеОбъекта.Реквизиты[ИмяЭлемента].Тип.Типы()[0];
				}
			}
			return null;
		}
		// Функция создает объект запрос и устанавливает у него параметры ТекстАвтоПодбора и ТекстАвтоПодбораЧисло
		// убирает лишние символы в строке поиска

		public object СоздатьЗапросДляСпискаАвтоподбора(/*СтрокаПоиска, СтрокаОтборовПоСтруктуре, СтруктураПараметров, ИмяТаблицыОграничений*/)
		{
			//Запрос = Новый Запрос;
			//СтрокаПоиска = ОбщегоНазначения.СформироватьСтрокуДляПоискаВЗапросе(СтрокаПоиска);
			//Запрос.УстановитьПараметр("ТекстАвтоПодбора"     , (СтрокаПоиска + "%"));
			/*// Устанавливает ограничения
*/
			//СтрокаОтборовПоСтруктуре = "";
			return null;
		}
		//Функция Строит запрос автоподбора для регистра

		public object ПолучитьРезультатЗапросаАвтоподбораДляРегистра(/*Знач Текст, СтруктураПараметров, ИмяРегистра, ПоляДляПоиска, КоличествоЭлементов*/)
		{
			if(true/*(ПоляДляПоиска = Неопределено) ИЛИ ПоляДляПоиска.Количество() = 0*/)
			{
			}
			//Объект = Метаданные.РегистрыСведений[ИмяРегистра];
			//СтрокаОтборовПоСтруктуре = "";
			//Запрос = СоздатьЗапросДляСпискаАвтоподбора(Текст, СтрокаОтборовПоСтруктуре, СтруктураПараметров, "ТаблицаРегистра");
			/*СтрокаПолей = "ВЫБРАТЬ РАЗРЕШЕННЫЕ ПЕРВЫЕ " + Строка(КоличествоЭлементов) + "
				  	|	ТаблицаРегистра.* ";*/
			/*Запрос.Текст = СтрокаПолей + "
		|ИЗ
		|	РегистрСведений." + ИмяРегистра + " КАК ТаблицаРегистра
		|ГДЕ ";*/
			/*// формируем ограничения по полям для поиска
*/
			//ОграничениеПоПолю = "";
			/*Запрос.Текст = Запрос.Текст +"
		|	(" + ОграничениеПоПолю + ") " + СтрокаОтборовПоСтруктуре;*/
			return null;
		}
		// функция по типу возвращает наименование ветки метаданных

		public object ПолучитьВеткуМетаданныхПоТипу(/*ТипДанных*/)
		{
			//ВеткаМетаданных = "";
			if(true/*Справочники.ТипВсеСсылки().СодержитТип(ТипДанных)*/)
			{
				//ВеткаМетаданных = "Справочник";
			}
			return null;
		}
		// Функция выполняет запрос при автоподборе текста  и при окончании ввода текста в поле ввода.
		//
		// Параметры
		//  Текст - Строка, текст введенный в поле ввода видв контактной информации, по которому необходимо строить поиск
		//  СтруктураПараметров - Структура параметров запроса, ключ - имя параметра, значение - значение параметра.
		//  ТипСправочника - Тип, тип справочника автоподбора текста
		//  КоличествоЭлементов - Число, количество элементов в результирующей таблице запроса
		//
		// Возвращаемое значение
		//  РезультатЗапроса
		//

		public object ПолучитьРезультатЗапросаАвтоподбора(/*Знач Текст, СтруктураПараметров, ТипСправочника, КоличествоЭлементов*/)
		{
			//ВеткаМетаданных = ПолучитьВеткуМетаданныхПоТипу(ТипСправочника);
			if(true/*ВеткаМетаданных = ""*/)
			{
			}
			//ПустаяСсылкаТипа = Новый(ТипСправочника);
			//МетаданныеОбъекта = ПустаяСсылкаТипа.Метаданные();
			//КоллекцияПоискаПоПодстроке = МетаданныеОбъекта.ВводПоСтроке;
			if(true/*КоллекцияПоискаПоПодстроке.Количество() = 0*/)
			{
			}
			//ИмяТаблицыСправочника = МетаданныеОбъекта.Имя;
			//ИмяТаблицыОграничений = ?(КоллекцияПоискаПоПодстроке.Количество() = 1, "ТаблицаВложенногоЗапроса", "ТаблицаСправочника");
			//СтрокаОтборовПоСтруктуре = "";
			//Запрос = СоздатьЗапросДляСпискаАвтоподбора(Текст, СтрокаОтборовПоСтруктуре, СтруктураПараметров, ИмяТаблицыОграничений);
			/*СтрокаПолей = "
	|ВЫБРАТЬ РАЗРЕШЕННЫЕ РАЗЛИЧНЫЕ ПЕРВЫЕ " + Строка(КоличествоЭлементов) + "
	|	ТаблицаВложенногоЗапроса.Ссылка КАК Ссылка,
	|";*/
			if(true/*МетаданныеОбъекта.ДлинаНаименования > 0*/)
			{
				/*СтрокаПолей = СтрокаПолей + "
		|	ТаблицаВложенногоЗапроса.Ссылка.Наименование КАК Наименование,";*/
			}
			if(true/*МетаданныеОбъекта.ДлинаКода > 0*/)
			{
				/*СтрокаПолей = СтрокаПолей + "
		|	ТаблицаВложенногоЗапроса.Ссылка.Код КАК Код,";*/
			}
			if(true/*КоллекцияПоискаПоПодстроке.Количество() = 1*/)
			{
				//ЭлементКоллекции = КоллекцияПоискаПоПодстроке[0];
				//ТипЗначенияПоиска = ОпределитьТипОграниченийПоПолю(ЭлементКоллекции.Имя, МетаданныеОбъекта);
				if(true/*ЭлементКоллекции.Имя <> "Наименование" И ЭлементКоллекции.Имя <> "Код"*/)
				{
					/*СтрокаПолей = СтрокаПолей + "
			|	ТаблицаВложенногоЗапроса.Ссылка." + ЭлементКоллекции.Имя + " КАК " + ЭлементКоллекции.Имя;*/
				}
				/*Запрос.Текст = Лев(СтрокаПолей, (СтрДлина(СтрокаПолей) - 1)) + "
		|ИЗ
		|	" + ВеткаМетаданных + "." + ИмяТаблицыСправочника + " КАК ТаблицаВложенногоЗапроса
		|ГДЕ ";*/
				//ОграничениеПоПолю = СформироватьОграничениеПоПолюВхождениеВНачало("ТаблицаВложенногоЗапроса." + ЭлементКоллекции.Имя, ТипЗначенияПоиска);
				/*ОграничениеПоПолю = ОграничениеПоПолю + "
		|	И НЕ ТаблицаВложенногоЗапроса.ПометкаУдаления ";*/
				/*Запрос.Текст = Запрос.Текст +"
		|	" + ОграничениеПоПолю + СтрокаОтборовПоСтруктуре;*/
			}
			return null;
		}
		// Процедура обслуживает событие ОбновлениеОтображения в форме, где расположен ЭУ поиска по строке.
		//
		// Параметры
		//  ЭтаФорма - Форма записи регистра сведений КонтактнаяИнформация
		//  Элемент - элемент управления в котором происводится поиск по строке
		//

		public void ОбновлениеОтображенияВФормеПриПоискеПоСтроке(/*ЭтаФорма, Элемент, ОбработкаПоискаПоСтроке, ТекстПоискаПоСтроке*/)
		{
			if(true/*ОбработкаПоискаПоСтроке*/)
			{
				//ЭтаФорма.ТекущийЭлемент = Элемент;
				//Элемент.ВыделенныйТекст = ТекстПоискаПоСтроке;
				//ОбработкаПоискаПоСтроке = Ложь;
				//ТекстПоискаПоСтроке = "";
			}
			if(true/*ТипЗнч(Элемент.Значение) = Тип("Строка")*/)
			{
				//Элемент.ЦветТекстаПоля = ЦветаСтиля.ТекстИнформационнойНадписи;
			}
		}
		// Функция подбирает значения по выборке

		public object ПолучитьАвтоподборПоВыборке(/*РезультатЗапроса, Текст, ТекстАвтоПодбора, СтандартнаяОбработка, ПоляПоиска, Знач ПолеВыбора = ""*/)
		{
			//СтруктураНайденногоЭлемента = Новый Структура;
			if(true/*РезультатЗапроса = Неопределено*/)
			{
			}
			//СтандартнаяОбработка = Ложь;
			if(true/*РезультатЗапроса.Пустой()*/)
			{
			}
			//ВрегТекст =	ВРег(Текст);
			//Выборка = РезультатЗапроса.Выбрать();
			if(true/*Выборка.Количество() <> 1*/)
			{
			}
			/*// выбран только один элемент - его и подставляем
*/
			//Выборка.Следующий();
			return null;
		}
		// Функция формирует массив имен полей по которым организованн ввод по строке

		public object СформироватьМассивПоКоллекцииВводаПоСтроке(/*ТипСправочника*/)
		{
			//ПоляПоиска = Новый Массив();
			//ПустаяСсылка = Новый(ТипСправочника);
			//КоллекцияЭлементовПоиска = ПустаяСсылка.Метаданные().ВводПоСтроке;
			return null;
		}
		// Процедура обслуживает событие АвтоПодборТекста элемента управления ПолеВвода для подмены автопоиска по тексту.
		//
		// Параметры
		//  Элемент - поле ввода
		//  Текст - текст введенный в поле ввода Вид
		//  ТекстАвтоПодбора - текст автоподбора в поле Вид
		//  СтандартнаяОбработка - булево, флаг стандартной обработки события автоподбора
		//  СтруктураПараметров - Структура параметров запроса, ключ - имя параметра, значение - значение параметра.
		//  ТипСправочника - Тип, тип справочника автоподбора текста
		//

		public void АвтоПодборТекстаВЭлементеУправления(/*Элемент, Текст, ТекстАвтоПодбора, СтандартнаяОбработка, СтруктураПараметров, ТипСправочника*/)
		{
			//РезультатЗапроса = ПолучитьРезультатЗапросаАвтоподбора(Текст, СтруктураПараметров, ТипСправочника, 2);
			//ПоляПоиска = СформироватьМассивПоКоллекцииВводаПоСтроке(ТипСправочника);
			//ПолучитьАвтоподборПоВыборке(РезультатЗапроса, Текст, ТекстАвтоПодбора, СтандартнаяОбработка, ПоляПоиска);
		}
		// Функция обслуживает событие АвтоПодборТекста элемента управления ПолеВвода для подмены автопоиска по тексту.
		//
		// Параметры
		//  Элемент - поле ввода
		//  Текст - текст введенный в поле ввода Вид
		//  ТекстАвтоПодбора - текст автоподбора в поле Вид
		//  СтандартнаяОбработка - булево, флаг стандартной обработки события автоподбора
		//  СтруктураПараметров - Структура параметров запроса, ключ - имя параметра, значение - значение параметра.
		//  ТипСправочника - строка, имя регистра в котором ищется информация
		//	ПоляПоиска - массивы полей для Поиска
		//

		public object АвтоПодборТекстаВЭлементеУправленияПоРегистру(/*Элемент, Текст, ТекстАвтоПодбора, СтандартнаяОбработка, СтруктураПараметров, 
														ИмяРегистра, ПоляПоиска, ПолеВыбора*/)
		{
			//РезультатЗапроса = ПолучитьРезультатЗапросаАвтоподбораДляРегистра(Текст, СтруктураПараметров, ИмяРегистра, ПоляПоиска, 2);
			//СтруктураНайденногоЭлемента = ПолучитьАвтоподборПоВыборке(РезультатЗапроса, Текст, ТекстАвтоПодбора, СтандартнаяОбработка, ПоляПоиска, ПолеВыбора);
			return null;
		}
		// Функция формирует список выбора значений, для события ОкончаниеВводаТекста.
		//
		// Параметры
		//  РезультатЗапроса - РезультатЗапроса при поиске по строке
		//  Текст - Строка, текст поиска по строке
		//  ТипСправочника - Тип, тип справочника автоподбора текста
		//  ОсновноеПредставлениеВВидеКода - Булево, является ли представление в виде кода основным для справочника
		//
		// Возвращаемое значение:
		//   Список значений
		//

		public object СформироватьСписокВыбораЗначенийПоискаПоСтроке(/*ТаблицаЗапроса, Знач Текст, ПоляПоиска, ОсновноеПредставлениеВВидеКода*/)
		{
			//СписокВозврата = Новый СписокЗначений;
			//Текст = ВРег(Текст);
			//ДлинаТекста = СтрДлина(Текст);
			//ЕстьНаименование = (ТаблицаЗапроса.Колонки.Найти("Наименование") <> Неопределено);
			//ЕстьКод          = (ТаблицаЗапроса.Колонки.Найти("Код") <> Неопределено);
			//НужноИскатьПоКоду 		  = (ОбщегоНазначения.ВернутьИндексВМассиве(ПоляПоиска, "Код") <> -1);
			//НужноИскатьПоНаименованию = (ОбщегоНазначения.ВернутьИндексВМассиве(ПоляПоиска, "Наименование") <> -1);
			return null;
		}
		// Функция формирует список выбора значений, для АдресногоКлассификатора

		public object СформироватьСписокВыбораАдресногоКлассификатора(/*ТаблицаЗапроса, Знач Текст, НачальныйУровеньДетализации, КонечныйУровеньДетализации*/)
		{
			//КЧ = Новый КвалификаторыЧисла(12,2);
			//Массив = Новый Массив;
			//Массив.Добавить(Тип("Число"));
			//ОписаниеТиповЧ = Новый ОписаниеТипов(Массив, , ,КЧ);
			//ТаблицаЗапроса.Колонки.Добавить("УникальныйНомерСтроки", ОписаниеТиповЧ);
			//СписокВозврата = Новый СписокЗначений;
			//Текст = ВРег(Текст);
			//ДлинаТекста = СтрДлина(Текст);
			//НомерЭлемента = 0;
			return null;
		}
		// функция возвращает был ли выбран пользователем элемент из выпадающего списка выбора

		public object ОпределитьВыборПользователяИзСписка(/*Элемент, ЭтаФорма, СписокВыбора, ТаблицаВыборки, Значение, ПолеВыбора, СтруктураВыбранногоЭлемента*/)
		{
			/*// а содержит ли список строки
*/
			if(true/*СписокВыбора.Количество() > 0*/)
			{
				/*// список отсортируем в алфавитном порядке
*/
				//СписокВыбора.СортироватьПоПредставлению();
				//ВыбранныйЭлемент = ЭтаФорма.ВыбратьИзСписка(СписокВыбора, Элемент);
			}
			if(true/*ВыбранныйЭлемент <> Неопределено*/)
			{
				//ВыбраннаяСтрока = ТаблицаВыборки.Найти(ВыбранныйЭлемент.Значение, "УникальныйНомерСтроки");
				//Значение = ВыбраннаяСтрока[ПолеВыбора];
				/*// структуру надо вернуть
*/
				//УправлениеКонтактнойИнформацией.ПеренестиСтрокуТаблицыВСтруктуру(ТаблицаВыборки, ВыбраннаяСтрока, СтруктураВыбранногоЭлемента);
			}
			return null;
		}
		// процедура переносит значение из выборки в структуру

		public void ОбработатьЕдинственныйЭлементВыбора(/*РезультатЗапроса, Выборка, Значение, ПолеВыбора, СтруктураВыбранногоЭлемента*/)
		{
			//Выборка.Следующий();
			//Значение = Выборка[ПолеВыбора];
			//УправлениеКонтактнойИнформацией.ПеренестиСтрокуВыборкиВСтруктуру(РезультатЗапроса, Выборка, СтруктураВыбранногоЭлемента);
		}
		// Процедура предупреждает пользователя что найдено более 50 элементов для подбора

		public void ПредупредитьНайденоБолееПятидесятиЭлементов(/**/)
		{
			/*Предупреждение("Найдено более 50-ти значений, удовлетворяющих условиям выбора.
				   |Задайте более длинную строку или воспользуйтесь командой выбора (F4).");*/
		}
		// Процедура организует выбор элементов по результату запроса

		public void ВыбратьЭлементОкончаниеВводаТекста(/*Элемент, Текст, Значение, СтандартнаяОбработка, ОбработкаПоискаПоСтроке, ТекстПоискаПоСтроке, РезультатЗапроса, ЭтаФорма, ПоследнееЗначениеЭлементаПоискаПоСтроке = Неопределено, 
											ПриОтсутствииЗначенияОставлятьТекст = Истина, ПоляПоиска, ПолеВыбора, 
											СтруктураВыбранногоЭлемента = Неопределено, ОсновноеПредставлениеВВидеКода = Ложь,
											Знач СообщатьПользователюОбОшибкеВводаДанных = Истина*/)
		{
			if(true/*РезультатЗапроса = Неопределено*/)
			{
			}
			//СтандартнаяОбработка = Ложь;
			if(true/*РезультатЗапроса.Пустой() И ПриОтсутствииЗначенияОставлятьТекст*/)
			{
				//Значение = Текст;
			}
			//Выборка = РезультатЗапроса.Выбрать();
			//ТаблицаВыборки = РезультатЗапроса.Выгрузить();
			//Значение = СформироватьСписокВыбораЗначенийПоискаПоСтроке(ТаблицаВыборки, Текст, ПоляПоиска, ОсновноеПредставлениеВВидеКода);
		}
		// Процедура организует выбор элементов по результату запроса

		public void ВыбратьЭлементОкончаниеВводаАдресногоКлассификатора(/*Элемент, Текст, Значение, СтандартнаяОбработка, ОбработкаПоискаПоСтроке, ТекстПоискаПоСтроке, РезультатЗапроса, ЭтаФорма, ПоследнееЗначениеЭлементаПоискаПоСтроке = Неопределено, 
											ПриОтсутствииЗначенияОставлятьТекст = Истина, ПоляПоиска, ПолеВыбора, 
											СтруктураВыбранногоЭлемента = Неопределено, НачальныйУровеньДетализации = 0, КонечныйУровеньДетализации = 5*/)
		{
			if(true/*РезультатЗапроса = Неопределено*/)
			{
			}
			//СтандартнаяОбработка = Ложь;
			if(true/*РезультатЗапроса.Пустой() И ПриОтсутствииЗначенияОставлятьТекст*/)
			{
				//Значение = Текст;
			}
			//Выборка = РезультатЗапроса.Выбрать();
			//КоличествоЭлементовВыборки = Выборка.Количество();
			if(true/*КоличествоЭлементовВыборки = 1*/)
			{
				/*// единственный элемент в выборке - переносим значение в стуктуру
*/
				//ОбработатьЕдинственныйЭлементВыбора(РезультатЗапроса, Выборка, Значение, ПолеВыбора, СтруктураВыбранногоЭлемента);
			}
			if(true/*ЭлементВыбран*/)
			{
			}
			/*// то что пользователь ввел то и оставляем
*/
			//Значение = Текст;
		}
		// Процедура обслуживает событие ОкончаниеВводаТекста элемента управления Вид в форме записи регистра
		// сведений Контактная информация.
		//
		// Параметры
		//  Элемент - поле ввода
		//  Текст - текст введенный в поле ввода Вид
		//  Значение - данные элемента управления поле ввода
		//  СтандартнаяОбработка - булево, флаг стандартной обработки события автоподбора
		//  СтруктураПараметров - Структура параметров запроса, ключ - имя параметра, значение - значение параметра.
		//  ЭтаФорма - форма записи регистра сведений контактная информация
		//  ТипСправочника - Тип, тип справочника автоподбора текста
		//

		public void ОкончаниеВводаТекстаВЭлементеУправления(/*Элемент, Текст, Значение, СтандартнаяОбработка, СтруктураПараметров, ЭтаФорма, ТипСправочника, 
	ОбработкаПоискаПоСтроке = Неопределено, ТекстПоискаПоСтроке = Неопределено, ПоследнееЗначениеЭлементаПоискаПоСтроке = Неопределено, 
	ПриОтсутствииЗначенияОставлятьТекст = Истина, Знач СообщатьПользователюОбОшибкеВводаДанных = Истина*/)
		{
			if(true/*ПустаяСтрока(Текст)*/)
			{
				//Значение = Новый(ТипСправочника);
				//СтандартнаяОбработка = Ложь;
			}
			//ПоляПоиска = СформироватьМассивПоКоллекцииВводаПоСтроке(ТипСправочника);
			//РезультатЗапроса = ПолучитьРезультатЗапросаАвтоподбора(Текст, СтруктураПараметров, ТипСправочника, 51);
			/*// определим способ основного представления справочника
*/
			//ОсновноеПредставлениеВВидеКода = Ложь;
			//ОбъектМетаданных = Метаданные.НайтиПоТипу(ТипСправочника);
			if(true/*ОбъектМетаданных <> Неопределено*/)
			{
				if(true/*ОбъектМетаданных.ОсновноеПредставление = Метаданные.СвойстваОбъектов.ОсновноеПредставлениеСправочника.ВВидеКода*/)
				{
					//ОсновноеПредставлениеВВидеКода = Истина;
				}
			}
			/*ВыбратьЭлементОкончаниеВводаТекста(Элемент, Текст, Значение, СтандартнаяОбработка, ОбработкаПоискаПоСтроке, ТекстПоискаПоСтроке, РезультатЗапроса, ЭтаФорма, ПоследнееЗначениеЭлементаПоискаПоСтроке, 
										ПриОтсутствииЗначенияОставлятьТекст, ПоляПоиска, "Ссылка", , ОсновноеПредставлениеВВидеКода,
										СообщатьПользователюОбОшибкеВводаДанных);*/
		}
		// Процедура обслуживает событие ОкончаниеВводаТекста элемента управления По Адресному Классификатору

		public void ОкончаниеВводаТекстаВЭлементеУправленияПоАдресномуКлассификатору(/*Элемент, Текст, Значение, СтандартнаяОбработка, СтруктураПараметров, ЭтаФорма, 
															ОбработкаПоискаПоСтроке = Неопределено, ТекстПоискаПоСтроке = Неопределено, 
															ПоследнееЗначениеЭлементаПоискаПоСтроке = Неопределено, ПриОтсутствииЗначенияОставлятьТекст = Истина,
															СтруктураВыбранногоЭлемента = Неопределено, 
															НачальныйУровеньДетализацииАдреса, КонечныйУровеньДетализацииАдреса*/)
		{
			if(true/*ПустаяСтрока(Текст)*/)
			{
				//Значение = "";
				//СтандартнаяОбработка = Ложь;
			}
			//МассивПоиска = Новый Массив();
			//МассивПоиска.Добавить("Наименование");
			//СокращенныйТекстТерритории = СокрЛП(УправлениеКонтактнойИнформацией.ОбрезатьСокращение(Текст));
			//СообщатьОбОшибкеПриОтсутствииЭлементов = (СокращенныйТекстТерритории = Текст);
			/*// пробуем найти адресный элемент без обрезания потенциального сокращения
*/
			//РезультатЗапроса = ПолучитьРезультатЗапросаАвтоподбораДляРегистра(Текст, СтруктураПараметров, "АдресныйКлассификатор", МассивПоиска, 51);
			if(true/*РезультатЗапроса.Пустой() И НЕ СообщатьОбОшибкеПриОтсутствииЭлементов*/)
			{
				/*// Ничего найти не удалось. Обрезаем сокращения и пытаемся еще раз
*/
				//РезультатЗапроса = ПолучитьРезультатЗапросаАвтоподбораДляРегистра(СокращенныйТекстТерритории, СтруктураПараметров, "АдресныйКлассификатор", МассивПоиска, 51);
			}
			/*ВыбратьЭлементОкончаниеВводаАдресногоКлассификатора(Элемент, Текст, Значение, СтандартнаяОбработка, ОбработкаПоискаПоСтроке, ТекстПоискаПоСтроке, РезультатЗапроса, 
										ЭтаФорма, ПоследнееЗначениеЭлементаПоискаПоСтроке, ПриОтсутствииЗначенияОставлятьТекст, 
										МассивПоиска, "Наименование", СтруктураВыбранногоЭлемента, НачальныйУровеньДетализацииАдреса, КонечныйУровеньДетализацииАдреса);*/
		}
		// Процедура обслуживает событие ОкончаниеВводаТекста элемента управления По Адресному Классификатору

		public void ОкончаниеВводаТекстаВЭлементеУправленияПоГородуУлице(/*Элемент, Текст, Значение, СтандартнаяОбработка, ЭтаФорма, 
															ОбработкаПоискаПоСтроке = Неопределено, ТекстПоискаПоСтроке = Неопределено, 
															ПоследнееЗначениеЭлементаПоискаПоСтроке = Неопределено, ПриОтсутствииЗначенияОставлятьТекст = Истина,
															СтруктураВыбранногоЭлемента = Неопределено, 
															КонечныйУровеньДетализацииАдреса, ПодборГорода = Истина, ГородДляОграничения = ""*/)
		{
			if(true/*ПустаяСтрока(Текст)*/)
			{
				//Значение = "";
				//СтандартнаяОбработка = Ложь;
			}
			//МассивПоиска = Новый Массив();
			//МассивПоиска.Добавить("Наименование");
			//СокращенныйТекстТерритории = СокрЛП(УправлениеКонтактнойИнформацией.ОбрезатьСокращение(Текст));
			//СообщатьОбОшибкеПриОтсутствииЭлементов = (СокращенныйТекстТерритории = Текст);
			/*// пробуем найти адресный элемент без обрезания потенциального сокращения
*/
			if(true/*ПодборГорода*/)
			{
				//РезультатЗапроса = УправлениеКонтактнойИнформацией.ВернутьРезультатЗапросаПоискаГорода(Текст, 51);
			}
			if(true/*РезультатЗапроса.Пустой() И НЕ СообщатьОбОшибкеПриОтсутствииЭлементов*/)
			{
				/*// Ничего найти не удалось. Обрезаем сокращения и пытаемся еще раз
*/
				if(true/*ПодборГорода*/)
				{
					//РезультатЗапроса = УправлениеКонтактнойИнформацией.ВернутьРезультатЗапросаПоискаГорода(СокращенныйТекстТерритории, 51);
				}
			}
			//УровеньПодбора = ?(ПодборГорода, 1, КонечныйУровеньДетализацииАдреса);
			/*ВыбратьЭлементОкончаниеВводаАдресногоКлассификатора(Элемент, Текст, Значение, СтандартнаяОбработка, ОбработкаПоискаПоСтроке, ТекстПоискаПоСтроке, РезультатЗапроса, 
										ЭтаФорма, ПоследнееЗначениеЭлементаПоискаПоСтроке, ПриОтсутствииЗначенияОставлятьТекст, 
										МассивПоиска, "Наименование", СтруктураВыбранногоЭлемента, УровеньПодбора, КонечныйУровеньДетализацииАдреса);*/
		}
		////////////////////////////////////////////////////////////////////////////////
		// По плану видов расчета выполняет поиск элементов по первым символам имени с применением шаблона
		// Параметры:
		//     	СтрокаПервыеСимволы - Строка - первые символы имени расчета
		// 	   	ИмяПланаВидовРасчета - Строка - имя плана видов расчета
		//	   	СтрокаДопУсловие - Строка - дополнительное условие для отбора видов расчетов
		//		СписокДопПараметры - Структура - параметры запроса, необходимые для вычисления доп. условия
		//		СтандартнаяОбработка - Булево - признак стандартной обработки события окончания ввода текста
		// Возвращает:
		//		Удовлетворяющий шаблону имени и условиям отбора вид расчета, если таких несколько - то список значений

		public object ПолучитьСписокВидовРасчетаПоПервымСимволамИмениРасчета(/*СтрокаПервыеСимволы, ИмяПланаВидовРасчета, СтрокаДопУсловие, СтруктураДопПараметры, СтандартнаяОбработка*/)
		{
			if(true/*ПустаяСтрока(СтрокаПервыеСимволы)*/)
			{
			}
			//Запрос = Новый Запрос;
			/*Запрос.Текст = "ВЫБРАТЬ ПЕРВЫЕ 51
	               |	ОсновныеНачисленияОрганизаций.Ссылка КАК Ссылка,
	               |	ОсновныеНачисленияОрганизаций.Наименование + "" ("" + ОсновныеНачисленияОрганизаций.Код + "")"" КАК СтрокаПредставления
	               |ИЗ
	               |	ПланВидовРасчета." + ИмяПланаВидовРасчета + " КАК ОсновныеНачисленияОрганизаций
	               |
	               |ГДЕ
	               |	ОсновныеНачисленияОрганизаций.Наименование ПОДОБНО &парамШаблонИмени
				   | " + ?(СтрокаДопУсловие = "" , "", " И " + СтрокаДопУсловие);*/
			/*// Параметры, требуемые для вычисления дополнительного условия
*/
			/*// заменим спецсимволы
*/
			//СтрокаПервыеСимволы = СтрЗаменить(СтрокаПервыеСимволы, "~", "~~");
			//СтрокаПервыеСимволы = СтрЗаменить(СтрокаПервыеСимволы, "%", "~%");
			//СтрокаПервыеСимволы = СтрЗаменить(СтрокаПервыеСимволы, "_", "~_");
			//СтрокаПервыеСимволы = СтрЗаменить(СтрокаПервыеСимволы, "[", "~[");
			//СтрокаПервыеСимволы = СтрЗаменить(СтрокаПервыеСимволы, "-", "~-");
			//Запрос.УстановитьПараметр("парамШаблонИмени", СтрокаПервыеСимволы + "%");
			//Выборка = Запрос.Выполнить().Выбрать();
			//Значение = Новый СписокЗначений;
			while(true/*Выборка.Следующий()*/)
			{
				//Значение.Добавить(Выборка.Ссылка, Выборка.СтрокаПредставления);
			}
			/*;
	
	СтандартнаяОбработка = (Значение.Количество() > 50);*/
			return null;
		}
	}
}

