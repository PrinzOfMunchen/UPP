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
	public partial class ТиповыеАнкеты: СправочникТест
	{

		public static void Создать1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("Создание 1000 элементов справочника ТиповыеАнкеты. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			for (var НомерЭлемента = 1;НомерЭлемента < 1000;НомерЭлемента++)
			{
				var Объект = V82.Справочники/*Менеджер*/.ТиповыеАнкеты.СоздатьЭлемент();
				Объект.Код = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(1,9);//НомерЭлемента;
				Объект.Наименование = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,50);//"Наименование " + НомерЭлемента;

				Объект.ЗагружатьОбъекты = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ВидСправочникаДляЗагрузки = (V82.Перечисления/*Ссылка*/.ВидыОбъектовЗагружаемыхИзОпроса)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВидыОбъектовЗагружаемыхИзОпроса));
				Объект.Адресная = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.НаименованиеАнкеты = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,200);
				Объект.Вступление = ГенераторСлучайныхЧисел.СлучайноеРусскоеСлово(3,255);
				Объект.ЗаполнятьАнкетуДанными = ГенераторСлучайныхЧисел.СледующееБулево();
				Объект.ВидАнкеты = (V82.Перечисления/*Ссылка*/.ВидыАнкет)ГенераторСлучайныхЧисел.СледующееПеречисление(typeof(V82.Перечисления/*Ссылка*/.ВидыАнкет));
				Объект.СекундОтвета = ГенераторСлучайныхЧисел.Следующий(99999);

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
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.ТиповыеАнкеты.Выбрать())
			{
				var Объект = Ссылка.ПолучитьОбъект();
				Объект.Удалить();
			}
		}

		public static void СериализацияProtoBuf1000()
		{
			var Старт = DateTime.Now;
			Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("СериализацияProtoBuf 1000 элементов справочника ТиповыеАнкеты. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			using (var Поток = new MemoryStream())
			{
				var НомерЭлемента = 0;
				foreach (var Ссылка in V82.Справочники/*Менеджер*/.ТиповыеАнкеты.Выбрать())
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
			Console.WriteLine("СериализацияJson 1000 элементов справочника ТиповыеАнкеты. Старт: " + Старт.ToString("dd.MM.yy HH:mm:ss.fff") + ".");
			var НомерЭлемента = 0;
			foreach (var Ссылка in V82.Справочники/*Менеджер*/.ТиповыеАнкеты.Выбрать())
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
