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
	///(Общ)
	///</summary>
	public partial class СотрудникиОрганизаций:СправочникОбъект
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
		public string/*10*/ Код;
		public string/*100*/ Наименование;
		public V82.СправочникиСсылка.ФизическиеЛица Физлицо;
		public bool Актуальность;//Не находится в архиве
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.Организации ОбособленноеПодразделение;//Трудовой договор: Обособленное подразделение
		public V82.Перечисления/*Ссылка*/.ВидыДоговоровСФизЛицами ВидДоговора;//Вид договора
		public V82.Перечисления/*Ссылка*/.ВидыЗанятостиВОрганизации ВидЗанятости;//Вид занятости
		public string/*(11)*/ НомерДоговора;//Трудовой договор: Номер договора
		public DateTime ДатаДоговора;//Трудовой договор: Дата договора
		public V82.СправочникиСсылка.ГрафикиРаботы ГрафикРаботы;//Трудовой договор: График работы
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации;//Трудовой договор: Подразделение организации
		public V82.СправочникиСсылка.ДолжностиОрганизаций Должность;//Трудовой договор: Должность
		public decimal/*(4.2)*/ ЗанимаемыхСтавок;//Трудовой договор: Занимаемых ставок
		public DateTime ДатаНачала;//Трудовой договор: Дата начала
		public DateTime ДатаОкончания;//Трудовой договор: Дата окончания
		public decimal/*(4.1)*/ ИспытательныйСрок;//Трудовой договор: Испытательный срок
		public object ВидРасчета;//Трудовой договор: Вид расчета
		public decimal/*(15.3)*/ ТарифнаяСтавка;//Трудовой договор: Тарифная ставка
		public V82.СправочникиСсылка.Валюты ВалютаТарифнойСтавки;//Трудовой договор: Валюта тарифной ставки
		public string/*(15)*/ ПостфиксНаименования;//Постфикс наименования
		public V82.СправочникиСсылка.ТарифныеРазряды ТарифныйРазряд;//Трудовой договор: Тарифный разряд
		public V82.СправочникиСсылка.Организации ТекущееОбособленноеПодразделение;//Текущее обособленное подразделение
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ТекущееПодразделениеОрганизации;//Текущее подразделение организации
		public V82.СправочникиСсылка.ДолжностиОрганизаций ТекущаяДолжностьОрганизации;//Текущая должность организации
		public DateTime ДатаПриемаНаРаботу;//Дата приема на работу
		public DateTime ДатаУвольнения;//Дата увольнения
		public V82.СправочникиСсылка.Подразделения ТекущееПодразделениеКомпании;//Подразделение компании
		public V82.СправочникиСсылка.ДолжностиОрганизаций ТекущаяДолжностьКомпании;//Должность компании
		public DateTime ДатаПриемаНаРаботуВКомпанию;//Принят в компанию
		public DateTime ДатаУвольненияИзКомпании;//Уволен из компании
		public bool ЯвляетсяСтудентомРаботающимВСтудотряде;//Является студентом работающим в студотряде
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
						Insert Into _Reference237(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_ParentIDRRef
						,_Folder
						,_Code
						,_Description
						,_Fld3496RRef
						,_Fld3497
						,_Fld3498RRef
						,_Fld3499RRef
						,_Fld3500RRef
						,_Fld3501RRef
						,_Fld3502
						,_Fld3503
						,_Fld3504RRef
						,_Fld3505RRef
						,_Fld3506RRef
						,_Fld3507
						,_Fld3508
						,_Fld3509
						,_Fld3510
						,_Fld3511RRef
						,_Fld3512
						,_Fld3513RRef
						,_Fld3514
						,_Fld3515RRef
						,_Fld3516RRef
						,_Fld3517RRef
						,_Fld3518RRef
						,_Fld3519
						,_Fld3520
						,_Fld3521RRef
						,_Fld3522RRef
						,_Fld3523
						,_Fld3524
						,_Fld3525)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Предопределенный
						,@Родитель
						,@ЭтоГруппа
						,@Код
						,@Наименование
						,@Физлицо
						,@Актуальность
						,@Организация
						,@ОбособленноеПодразделение
						,@ВидДоговора
						,@ВидЗанятости
						,@НомерДоговора
						,@ДатаДоговора
						,@ГрафикРаботы
						,@ПодразделениеОрганизации
						,@Должность
						,@ЗанимаемыхСтавок
						,@ДатаНачала
						,@ДатаОкончания
						,@ИспытательныйСрок
						,@ВидРасчета
						,@ТарифнаяСтавка
						,@ВалютаТарифнойСтавки
						,@ПостфиксНаименования
						,@ТарифныйРазряд
						,@ТекущееОбособленноеПодразделение
						,@ТекущееПодразделениеОрганизации
						,@ТекущаяДолжностьОрганизации
						,@ДатаПриемаНаРаботу
						,@ДатаУвольнения
						,@ТекущееПодразделениеКомпании
						,@ТекущаяДолжностьКомпании
						,@ДатаПриемаНаРаботуВКомпанию
						,@ДатаУвольненияИзКомпании
						,@ЯвляетсяСтудентомРаботающимВСтудотряде)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Reference237
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_IsMetadata	= @Предопределенный
						,_ParentIDRRef	= @Родитель
						,_Folder	= @ЭтоГруппа
						,_Code	= @Код
						,_Description	= @Наименование
						,_Fld3496RRef	= @Физлицо
						,_Fld3497	= @Актуальность
						,_Fld3498RRef	= @Организация
						,_Fld3499RRef	= @ОбособленноеПодразделение
						,_Fld3500RRef	= @ВидДоговора
						,_Fld3501RRef	= @ВидЗанятости
						,_Fld3502	= @НомерДоговора
						,_Fld3503	= @ДатаДоговора
						,_Fld3504RRef	= @ГрафикРаботы
						,_Fld3505RRef	= @ПодразделениеОрганизации
						,_Fld3506RRef	= @Должность
						,_Fld3507	= @ЗанимаемыхСтавок
						,_Fld3508	= @ДатаНачала
						,_Fld3509	= @ДатаОкончания
						,_Fld3510	= @ИспытательныйСрок
						,_Fld3511RRef	= @ВидРасчета
						,_Fld3512	= @ТарифнаяСтавка
						,_Fld3513RRef	= @ВалютаТарифнойСтавки
						,_Fld3514	= @ПостфиксНаименования
						,_Fld3515RRef	= @ТарифныйРазряд
						,_Fld3516RRef	= @ТекущееОбособленноеПодразделение
						,_Fld3517RRef	= @ТекущееПодразделениеОрганизации
						,_Fld3518RRef	= @ТекущаяДолжностьОрганизации
						,_Fld3519	= @ДатаПриемаНаРаботу
						,_Fld3520	= @ДатаУвольнения
						,_Fld3521RRef	= @ТекущееПодразделениеКомпании
						,_Fld3522RRef	= @ТекущаяДолжностьКомпании
						,_Fld3523	= @ДатаПриемаНаРаботуВКомпанию
						,_Fld3524	= @ДатаУвольненияИзКомпании
						,_Fld3525	= @ЯвляетсяСтудентомРаботающимВСтудотряде
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
					Команда.Parameters.AddWithValue("Физлицо", Физлицо.Ссылка);
					Команда.Parameters.AddWithValue("Актуальность", Актуальность);
					Команда.Parameters.AddWithValue("Организация", Организация.Ссылка);
					Команда.Parameters.AddWithValue("ОбособленноеПодразделение", ОбособленноеПодразделение.Ссылка);
					Команда.Parameters.AddWithValue("ВидДоговора", ВидДоговора.Ключ());
					Команда.Parameters.AddWithValue("ВидЗанятости", ВидЗанятости.Ключ());
					Команда.Parameters.AddWithValue("НомерДоговора", НомерДоговора);
					Команда.Parameters.AddWithValue("ДатаДоговора", ДатаДоговора);
					Команда.Parameters.AddWithValue("ГрафикРаботы", ГрафикРаботы.Ссылка);
					Команда.Parameters.AddWithValue("ПодразделениеОрганизации", ПодразделениеОрганизации.Ссылка);
					Команда.Parameters.AddWithValue("Должность", Должность.Ссылка);
					Команда.Parameters.AddWithValue("ЗанимаемыхСтавок", ЗанимаемыхСтавок);
					Команда.Parameters.AddWithValue("ДатаНачала", ДатаНачала);
					Команда.Parameters.AddWithValue("ДатаОкончания", ДатаОкончания);
					Команда.Parameters.AddWithValue("ИспытательныйСрок", ИспытательныйСрок);
					Команда.Parameters.AddWithValue("ТарифнаяСтавка", ТарифнаяСтавка);
					Команда.Parameters.AddWithValue("ВалютаТарифнойСтавки", ВалютаТарифнойСтавки.Ссылка);
					Команда.Parameters.AddWithValue("ПостфиксНаименования", ПостфиксНаименования);
					Команда.Parameters.AddWithValue("ТарифныйРазряд", ТарифныйРазряд.Ссылка);
					Команда.Parameters.AddWithValue("ТекущееОбособленноеПодразделение", ТекущееОбособленноеПодразделение.Ссылка);
					Команда.Parameters.AddWithValue("ТекущееПодразделениеОрганизации", ТекущееПодразделениеОрганизации.Ссылка);
					Команда.Parameters.AddWithValue("ТекущаяДолжностьОрганизации", ТекущаяДолжностьОрганизации.Ссылка);
					Команда.Parameters.AddWithValue("ДатаПриемаНаРаботу", ДатаПриемаНаРаботу);
					Команда.Parameters.AddWithValue("ДатаУвольнения", ДатаУвольнения);
					Команда.Parameters.AddWithValue("ТекущееПодразделениеКомпании", ТекущееПодразделениеКомпании.Ссылка);
					Команда.Parameters.AddWithValue("ТекущаяДолжностьКомпании", ТекущаяДолжностьКомпании.Ссылка);
					Команда.Parameters.AddWithValue("ДатаПриемаНаРаботуВКомпанию", ДатаПриемаНаРаботуВКомпанию);
					Команда.Parameters.AddWithValue("ДатаУвольненияИзКомпании", ДатаУвольненияИзКомпании);
					Команда.Parameters.AddWithValue("ЯвляетсяСтудентомРаботающимВСтудотряде", ЯвляетсяСтудентомРаботающимВСтудотряде);
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
					Команда.CommandText = @"Delete _Reference237
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
		/*МодульОбъекта*/
		////////////////////////////////////////////////////////////////////////////////
		// ПЕРЕМЕННЫЕ МОДУЛЯ

		public object СформироватьЗапросДляПечатиТрудовогоДоговора(/**/)
		{
			//Запрос = Новый Запрос;
			//Запрос.МенеджерВременныхТаблиц = Новый МенеджерВременныхТаблиц;
			/*// Установим параметры запроса
*/
			//Запрос.УстановитьПараметр("СправочникСсылка", Ссылка);
			//Запрос.УстановитьПараметр("Физлицо", Физлицо);
			//Запрос.УстановитьПараметр("Организация", ОбособленноеПодразделение);
			//Запрос.УстановитьПараметр("ДатаДокумента",	 ДатаДоговора);
			/*// Выберем (если есть доступ) ответственное физлицо
*/
			/*Запрос.Текст =
	"ВЫБРАТЬ РАЗРЕШЕННЫЕ
	|	ОтветственныеЛицаОрганизацийСрезПоследних.ФизическоеЛицо КАК Физлицо,
	|	ОтветственныеЛицаОрганизацийСрезПоследних.Должность,
	|	ОтветственныеЛицаОрганизацийСрезПоследних.ФизическоеЛицо.Наименование КАК НаименованиеФизлица,
	|	ФизическиеЛица.Комментарий
	|ПОМЕСТИТЬ ВТОтветственноеЛицо
	|ИЗ
	|	РегистрСведений.ОтветственныеЛицаОрганизаций.СрезПоследних(
	|			&ДатаДокумента,
	|			ОтветственноеЛицо = ЗНАЧЕНИЕ(Перечисление.ОтветственныеЛицаОрганизаций.Руководитель)
	|				И СтруктурнаяЕдиница = &Организация) КАК ОтветственныеЛицаОрганизацийСрезПоследних
	|		ВНУТРЕННЕЕ СОЕДИНЕНИЕ Справочник.ФизическиеЛица КАК ФизическиеЛица
	|		ПО ОтветственныеЛицаОрганизацийСрезПоследних.ФизическоеЛицо = ФизическиеЛица.Ссылка";*/
			//Запрос.Выполнить();
			/*Запрос.Текст =
	"ВЫБРАТЬ
	|	ОтветственноеЛицоОрганизации.Должность КАК ДолжностьРуководителя,
	|	ТрудовойДоговор.НомерДоговора КАК НомерДок,
	|	ТрудовойДоговор.ДатаДоговора КАК ДатаДок,
	|	ТрудовойДоговор.Организация.НаименованиеПолное КАК ПолноеНазваниеОрганизации,
	|	ЕСТЬNULL(ФИООтветственныхЛиц.Фамилия + "" "" + ФИООтветственныхЛиц.Имя + "" "" + ФИООтветственныхЛиц.Отчество, ОтветственноеЛицоОрганизации.НаименованиеФизлица) КАК ФИОРуководителя,
	|	ЕСТЬNULL(ФИОФизЛиц.Фамилия + "" "" + ФИОФизЛиц.Имя + "" "" + ФИОФизЛиц.Отчество, ТрудовойДоговор.Физлицо.Наименование) КАК ФИОРаботника,
	|	ТрудовойДоговор.ДатаОкончания КАК ДатаУвольнения,
	|	ТрудовойДоговор.ДатаНачала КАК ДатаПриема,
	|	ТрудовойДоговор.Должность.Наименование КАК Должность,
	|	ТрудовойДоговор.ЗанимаемыхСтавок,
	|	ТрудовойДоговор.ИспытательныйСрок,
	|	ТрудовойДоговор.ПодразделениеОрганизации.Наименование КАК Подразделение,
	|	ВЫБОР
	|		КОГДА ТрудовойДоговор.ВидЗанятости = ЗНАЧЕНИЕ(Перечисление.ВидыЗанятостиВОрганизации.ОсновноеМестоРаботы)
	|			ТОГДА ""основной работе""
	|		ИНАЧЕ ""совместительству""
	|	КОНЕЦ КАК ВидЗанятости,
	|	ПаспортныеДанныеФизЛицСрезПоследних.ДокументСерия,
	|	ПаспортныеДанныеФизЛицСрезПоследних.ДокументНомер,
	|	ПаспортныеДанныеФизЛицСрезПоследних.ДокументДатаВыдачи,
	|	ВЫРАЗИТЬ(ПаспортныеДанныеФизЛицСрезПоследних.ДокументКемВыдан КАК СТРОКА(300)) КАК ДокументКемВыдан,
	|	АдресРегистрации.Представление КАК АдресРегистрации,
	|	ТелефонДомашний.Представление КАК Телефоны,
	|	КонтактнаяИнформация.Представление КАК АдресОрганизации,
	|	ТелефонОрганизации.Представление КАК ТелефоныОрганизации,
	|	ТрудовойДоговор.Организация.Наименование КАК НазваниеОрганизации,
	|	ТрудовойДоговор.Организация.ИНН + ""/"" + ТрудовойДоговор.Организация.КПП КАК ИНН,
	|	ТрудовойДоговор.ГрафикРаботы.ВидГрафика КАК ВидГрафика,
	|	ТрудовойДоговор.ГрафикРаботы.ДлительностьРабочейНедели КАК ДлительностьРабочейНедели,
	|	ТрудовойДоговор.ВидРасчета,
	|	ТрудовойДоговор.ТарифнаяСтавка,
	|	ТрудовойДоговор.ВалютаТарифнойСтавки.Наименование КАК ВалютаТарифнойСтавки,
	|	ТрудовойДоговор.ПерсональныеНадбавки.(
	|		Ссылка,
	|		НомерСтроки,
	|		Надбавка КАК Надбавка,
	|		Показатель1
	|	)
	|ИЗ
	|	Справочник.СотрудникиОрганизаций КАК ТрудовойДоговор
	|		ЛЕВОЕ СОЕДИНЕНИЕ ВТОтветственноеЛицо КАК ОтветственноеЛицоОрганизации
	|		ПО (ИСТИНА)
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.ФИОФизЛиц.СрезПоследних(
	|				&ДатаДокумента,
	|				Физлицо В
	|					(ВЫБРАТЬ
	|						Ответственные.Физлицо
	|					ИЗ
	|						ВТОтветственноеЛицо КАК Ответственные)) КАК ФИООтветственныхЛиц
	|		ПО (ИСТИНА)
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.ФИОФизЛиц.СрезПоследних(&ДатаДокумента, Физлицо = &Физлицо) КАК ФИОФизЛиц
	|		ПО (ИСТИНА)
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.ПаспортныеДанныеФизЛиц.СрезПоследних(&ДатаДокумента, Физлицо = &Физлицо) КАК ПаспортныеДанныеФизЛицСрезПоследних
	|		ПО (ИСТИНА)
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.КонтактнаяИнформация КАК АдресРегистрации
	|		ПО ТрудовойДоговор.Физлицо = АдресРегистрации.Объект
	|			И (АдресРегистрации.Вид = ЗНАЧЕНИЕ(Справочник.ВидыКонтактнойИнформации.ЮрАдресФизЛица))
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.КонтактнаяИнформация КАК ТелефонДомашний
	|		ПО ТрудовойДоговор.Физлицо = ТелефонДомашний.Объект
	|			И (ТелефонДомашний.Вид = ЗНАЧЕНИЕ(Справочник.ВидыКонтактнойИнформации.ТелефонФизЛица))
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.КонтактнаяИнформация КАК КонтактнаяИнформация
	|		ПО ТрудовойДоговор.Организация = КонтактнаяИнформация.Объект
	|			И (КонтактнаяИнформация.Вид = ЗНАЧЕНИЕ(Справочник.ВидыКонтактнойИнформации.ЮрАдресОрганизации))
	|		ЛЕВОЕ СОЕДИНЕНИЕ РегистрСведений.КонтактнаяИнформация КАК ТелефонОрганизации
	|		ПО ТрудовойДоговор.Организация = ТелефонОрганизации.Объект
	|			И (ТелефонОрганизации.Вид = ЗНАЧЕНИЕ(Справочник.ВидыКонтактнойИнформации.ТелефонОрганизации))
	|ГДЕ
	|	ТрудовойДоговор.Ссылка = &СправочникСсылка";*/
			return null;
		}
		// СформироватьЗапросДляПечати()
		// Функция формирует уникальный номер трудового договора
		// уникальность в пределах года
		//

		public object ПолучитьНомерТрудовогоДоговора(/**/)
		{
			return null;
		}
		// ПолучитьНомерТрудовогоДоговора()

		public void ПроверитьНомерТрудовогоДоговора(/*НачальнаяДатаДокумента*/)
		{
			//Справочники.СотрудникиОрганизаций.ПроверитьНомерТрудовогоДоговора(Организация, ВидДоговора, НачальнаяДатаДокумента, ДатаДоговора, НомерДоговора);
		}
		// ПроверитьНомерТрудовогоДоговора()
		// Функция формирует очередной табельный номер сотрудника
		// уникальность в пределах организации и вида договора
		// Возвращаемое значение:
		//   Строка   – табельный номер
		//

		public object ПолучитьОчереднойТабельныйНомер(/**/)
		{
			if(true/*Не ЗначениеЗаполнено(ВидДоговора)*/)
			{
			}
			//Префикс = "";
			//Запрос = Новый Запрос;
			//Запрос.УстановитьПараметр("парамОрганизация",Организация);
			//парамВидДоговора = Новый Массив;
			//СотрудникиОрганизацийПереопределяемый.ЗаполнитьПараметрыВидовДоговоров(парамВидДоговора, ВидДоговора, Префикс);
			//Запрос.УстановитьПараметр("парамВидДоговора",парамВидДоговора);
			//Запрос.УстановитьПараметр("Ссылка",Ссылка);
			/*ТекстЗапроса = 
	"ВЫБРАТЬ
	|	МАКСИМУМ(СотрудникиОрганизаций.Код) КАК Код
	|ИЗ
	|	Справочник.СотрудникиОрганизаций КАК СотрудникиОрганизаций
	|ГДЕ
	|	СотрудникиОрганизаций.Организация = &парамОрганизация
	|	И СотрудникиОрганизаций.ВидДоговора В(&парамВидДоговора)
	|	И СотрудникиОрганизаций.Ссылка <> &Ссылка";*/
			//Запрос.Текст = ТекстЗапроса;
			//РезультатаЗапроса = Запрос.Выполнить();
			if(true/*РезультатаЗапроса.Пустой()*/)
			{
			}
			return null;
		}
		// ПолучитьОчереднойТабельныйНомер()

		public object Печать(/*ИмяМакета, КоличествоЭкземпляров = 1, НаПринтер = Ложь*/)
		{
			return null;
		}
		// Возвращает доступные варианты печати
		//
		// Вовращаемое значение:
		//  Структура, каждая строка которой соответствует одному из вариантов печати
		//

		public object ПолучитьСтруктуруПечатныхФорм(/**/)
		{
			//СтруктураПечатныхФорм = СотрудникиОрганизацийПереопределяемый.ПолучитьСтруктуруПечатныхФорм(ЭтотОбъект);
			return null;
		}
		// ПолучитьСтруктуруПечатныхФорм()
		///////////////////////////////////////////////////////////////////////////////
		// ПРОЦЕДУРЫ - ОБРАБОТЧИКИ СОБЫТИЙ
		// Процедура - обработчик события "Копирование" объекта

		public void ПриКопировании(/*ОбъектКопирования*/)
		{
			if(true/*Не ЭтоГруппа*/)
			{
				//Физлицо = Справочники.ФизическиеЛица.ПустаяСсылка();
				//Наименование = "";
				if(true/*ВидДоговора = Перечисления.ВидыДоговоровСФизЛицами.ТрудовойДоговор*/)
				{
					//НомерДоговора = ПолучитьНомерТрудовогоДоговора();
				}
			}
		}
		// Процедура - обработчик события "Заполнение" объекта

		public void ОбработкаЗаполнения(/*Основание*/)
		{
			//ТипОснования = ТипЗнч(Основание);
			if(true/*ТипОснования = Тип("СправочникСсылка.ФизическиеЛица") 
		И НЕ Основание.ЭтоГруппа*/)
			{
				//Физлицо = Основание;
			}
		}
		// Процедура - обработчик события "ПередЗаписью" объекта
		//
		//Процедура ПередЗаписью(Отказ)
		//

		public void ПередЗаписью(/*Отказ*/)
		{
			if(true/*ПолучитьКадровыеДанныеФизлица*/)
			{
				//СотрудникиОрганизацийПереопределяемый.МодульОбъектаПередЗаписьюДополнительно(ЭтотОбъект, Отказ);
			}
			if(true/*ОбменДанными.Загрузка*/)
			{
			}
			if(true/*Не ЭтоГруппа И Физлицо.Пустая()*/)
			{
				//ОбщегоНазначения.СообщитьОбОшибке("Для сотрудника не задано физическое лицо!", Отказ);
			}
			if(true/*Не ЭтоГруппа И ОбособленноеПодразделение.Пустая()*/)
			{
				//ОбособленноеПодразделение = Организация;
			}
			if(true/*Не ЭтоГруппа И НЕ ЗначениеЗаполнено(ДатаПриемаНаРаботу) и ТекущееОбособленноеПодразделение <> ОбособленноеПодразделение*/)
			{
				//ТекущееОбособленноеПодразделение = ОбособленноеПодразделение;
			}
		}
		// ПередЗаписью()
		////////////////////////////////////////////////////////////////////////////////
		// ОПЕРАТОРЫ ОСНОВНОЙ ПРОГРАММЫ
	}
}
