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
	///Настройки формирования документов выпуска продукции по данным подсистемы "Оперативный учет производства"
	///</summary>
	public partial class НастройкиФормированияДокументовВыпускаПродукции: СправочникТест
	{

		public static void Создать1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Создание 1000 элементов справочника НастройкиФормированияДокументовВыпускаПродукции. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var НомерЭлемента = 1;НомерЭлемента < 1000;НомерЭлемента++)
			{
				var Объект = V82.Справочники/*Менеджер*/.НастройкиФормированияДокументовВыпускаПродукции.СоздатьЭлемент();
				Объект.Наименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,70);//"Наименование " + НомерЭлемента;

				Объект.ГраницаОбработки = ГенераторСлучайныхЧисел.СледующаяДата();
				Объект.Подразделение = V82.Справочники/*Менеджер*/.Подразделения.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.Подразделения();
				Объект.ПериодДетализации = (V82.Перечисления/*Ссылка*/.Периодичность)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.Периодичность));
				Объект.ВидРегулярногоДокумента = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,50);
				Объект.Организация = V82.Справочники/*Менеджер*/.Организации.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.Организации();
				Объект.ПодразделениеОрганизации = V82.Справочники/*Менеджер*/.ПодразделенияОрганизаций.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.ПодразделенияОрганизаций();
				Объект.Склад = V82.Справочники/*Менеджер*/.Склады.НайтиПоКоду(ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,3)) ?? new V82.СправочникиСсылка.Склады();
				Объект.ОтражатьВУправленческомУчете = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ОтражатьВБухгалтерскомУчете = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ОтражатьВНалоговомУчете = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ОтразитьВыпуск = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ОтразитьМатериалы = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.НеОбрабатыватьПериодДоЗавершенияСмен = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ФормироватьДокументыАвтоматически = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.РегламентноеЗадание = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,36);
				Объект.Задержка = ГенераторСлучайныхЧисел.Следующий(99);
				Объект.Комментарий = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,255);
				Объект.НеОбрабатыватьВсеДокументы = ГенераторСлучайныхЧисел.СледующееБулево();

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
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.НастройкиФормированияДокументовВыпускаПродукции.Выбрать())
			{
				var Объект = Ссылка.ПолучитьОбъект();
				Объект.Удалить();
			}
		}

		public static void СериализацияProtoBuf1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияProtoBuf 1000 элементов справочника НастройкиФормированияДокументовВыпускаПродукции. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var Поток = new MemoryStream())
			{
				var НомерЭлемента = 0;
				foreach (var Ссылка in V82.Справочники/*Менеджер*/.НастройкиФормированияДокументовВыпускаПродукции.Выбрать())
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
			Console.WriteLine("СериализацияJson 1000 элементов справочника НастройкиФормированияДокументовВыпускаПродукции. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var НомерЭлемента = 0;
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.НастройкиФормированияДокументовВыпускаПродукции.Выбрать())
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
