﻿
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.IO;
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиТест
{
	///<summary>
	///(Общ)
	///</summary>
	public partial class СпособыРаспределенияЗатратНаВыпуск: СправочникТест
	{

		public static void Создать1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Создание 1000 элементов справочника СпособыРаспределенияЗатратНаВыпуск. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var НомерЭлемента = 1;НомерЭлемента < 1000;НомерЭлемента++)
			{
				var Объект = V82.Справочники/*Менеджер*/.СпособыРаспределенияЗатратНаВыпуск.СоздатьЭлемент();
				Объект.Код = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,9);//НомерЭлемента;
				Объект.Наименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,50);//"Наименование " + НомерЭлемента;

				Объект.Комментарий = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,255);
				Объект.СпособРаспределенияЗатратНаВыпуск = (V82.Перечисления/*Ссылка*/.СпособыРаспределенияЗатратНаВыпуск)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.СпособыРаспределенияЗатратНаВыпуск));
				Объект.ТипФильтраПриРаспределенииЗатратНаВыпуск = (V82.Перечисления/*Ссылка*/.ТипыФильтровПриРаспределенииЗатратНаВыпуск)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ТипыФильтровПриРаспределенииЗатратНаВыпуск));
				Объект.БазаРаспределенияЗатрат = (V82.Перечисления/*Ссылка*/.БазыРаспределенияЗатрат)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.БазыРаспределенияЗатрат));
				Объект.ПоказательБазыРаспределения = (V82.Перечисления/*Ссылка*/.ВидыПоказателейБазыРаспределения)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВидыПоказателейБазыРаспределения));
				Объект.ТипЦен = V82.Справочники/*Менеджер*/.ТипыЦенНоменклатуры.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.ТипыЦенНоменклатуры();
				Объект.ОсновноеСырье = V82.Справочники/*Менеджер*/.ОсновноеСырье.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.ОсновноеСырье();
				Объект.СпособРаспределенияЗатратПоПодразделениям = V82.Справочники/*Менеджер*/.СпособыРаспределенияЗатратНаВыпуск.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск();
				Объект.РаспределятьНаСобственнуюПродукцию = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.РаспределятьНаПродукциюСтороннегоПереработчика = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.РаспределятьНаПродукциюИзДавальческогоСырья = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.РаспределятьНаПодчиненныеПодразделения = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.РаспределятьНаНаработку = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.Процент = ГенераторСлучайныхЧисел.Следующий(99999);
				Объект.Коэффициент = ГенераторСлучайныхЧисел.Следующий(999999999);
				Объект.ПорядокОкругления = (V82.Перечисления/*Ссылка*/.ПорядкиОкругления)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ПорядкиОкругления));
				Объект.ИзменитьНаПроцент = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ИзменитьНаКоэффициент = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ОкруглитьДо = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.Применимость = (V82.Перечисления/*Ссылка*/.ХарактерЗатрат)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ХарактерЗатрат));
				Объект.ИспользоватьПростоеРаспределение = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.НаправлениеРаспределения = (V82.Перечисления/*Ссылка*/.НаправленияРаспределенияЗатрат)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.НаправленияРаспределенияЗатрат));
				Объект.КогдаПрименять = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,255);
				Объект.ТипБазыРаспределения = (V82.Перечисления/*Ссылка*/.ТипыБазРаспределения)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ТипыБазРаспределения));

				Объект.Записать();
				Console.Write("Выполнено: " + НомерЭлемента + "%.");
				Console.CursorLeft = 0;
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void Удалить1000()
		{
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.СпособыРаспределенияЗатратНаВыпуск.Выбрать())
			{
				var Объект = Ссылка.ПолучитьОбъект();
				Объект.Удалить();
			}
		}

		public static void СериализацияProtoBuf1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияProtoBuf 1000 элементов справочника СпособыРаспределенияЗатратНаВыпуск. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var Поток = new MemoryStream())
			{
				var НомерЭлемента = 0;
				foreach (var Ссылка in V82.Справочники/*Менеджер*/.СпособыРаспределенияЗатратНаВыпуск.Выбрать())
				{
					НомерЭлемента++;
					Ссылка.СериализацияProtoBuf(Поток);
					Console.Write("Выполнено: " + НомерЭлемента + "%.");
					Console.CursorLeft = 0;
				}
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}

		public static void СериализацияJson1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияJson 1000 элементов справочника СпособыРаспределенияЗатратНаВыпуск. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var НомерЭлемента = 0;
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.СпособыРаспределенияЗатратНаВыпуск.Выбрать())
			{
				НомерЭлемента++;
				Ссылка.СериализацияJson();
				Console.Write("Выполнено: " + НомерЭлемента + "%.");
				Console.CursorLeft = 0;
			}
			var Финиш = DateTime.Now;
			Console.WriteLine("Закончено " + Math.Round(((Финиш - Старт).TotalMilliseconds / 1000), 3).ToString() + " сек. Финиш: " + Финиш.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			Console.WriteLine("-------------------------------------------------------------------- -");
		}
	}
}
