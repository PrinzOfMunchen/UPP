﻿
using System;
using System.Data.SqlClient;
using V82;
using V82.СправочникиСсылка;
using V82.Справочники;//Менеджер;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.Справочники//Менеджер
{
	///<summary>
	///(Общ)
	///</summary>
	public partial class СпособыРаспределенияЗатратНаВыпуск:СправочникМенеджер
	{

		public static СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск НайтиПоКоду(string Код)
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld3740 [Комментарий]
					,_Fld3741RRef [СпособРаспределенияЗатратНаВыпуск]
					,_Fld3742RRef [ТипФильтраПриРаспределенииЗатратНаВыпуск]
					,_Fld3743RRef [БазаРаспределенияЗатрат]
					,_Fld3744RRef [ПоказательБазыРаспределения]
					,_Fld3745RRef [ТипЦен]
					,_Fld3746RRef [ОсновноеСырье]
					,_Fld3747RRef [СпособРаспределенияЗатратПоПодразделениям]
					,_Fld3748 [РаспределятьНаСобственнуюПродукцию]
					,_Fld3749 [РаспределятьНаПродукциюСтороннегоПереработчика]
					,_Fld3750 [РаспределятьНаПродукциюИзДавальческогоСырья]
					,_Fld3751 [РаспределятьНаПодчиненныеПодразделения]
					,_Fld3752 [РаспределятьНаНаработку]
					,_Fld3753 [Процент]
					,_Fld3754 [Коэффициент]
					,_Fld3755RRef [ПорядокОкругления]
					,_Fld3756 [НастройкиПостроителя]
					,_Fld3757 [ИзменитьНаПроцент]
					,_Fld3758 [ИзменитьНаКоэффициент]
					,_Fld3759 [ОкруглитьДо]
					,_Fld3760 [СхемаКомпоновкиДанных]
					,_Fld3761RRef [Применимость]
					,_Fld3762 [ИспользоватьПростоеРаспределение]
					,_Fld3763RRef [НаправлениеРаспределения]
					,_Fld3764 [КогдаПрименять]
					,_Fld3765RRef [ТипБазыРаспределения]
					From _Reference244(NOLOCK)
					Where _Code=@Код";
					Команда.Parameters.AddWithValue("Код", Код);
					using (var Читалка = Команда.ExecuteReader())
					{
						if (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.СпособРаспределенияЗатратНаВыпуск = V82.Перечисления/*Ссылка*/.СпособыРаспределенияЗатратНаВыпуск.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.ТипФильтраПриРаспределенииЗатратНаВыпуск = V82.Перечисления/*Ссылка*/.ТипыФильтровПриРаспределенииЗатратНаВыпуск.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.БазаРаспределенияЗатрат = V82.Перечисления/*Ссылка*/.БазыРаспределенияЗатрат.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.ПоказательБазыРаспределения = V82.Перечисления/*Ссылка*/.ВидыПоказателейБазыРаспределения.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
							//Ссылка.ТипЦен = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(11));
							//Ссылка.ОсновноеСырье = new V82.СправочникиСсылка.ОсновноеСырье((byte[])Читалка.GetValue(12));
							//Ссылка.СпособРаспределенияЗатратПоПодразделениям = new V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск((byte[])Читалка.GetValue(13));
							Ссылка.РаспределятьНаСобственнуюПродукцию = ((byte[])Читалка.GetValue(14))[0]==1?true:false;
							Ссылка.РаспределятьНаПродукциюСтороннегоПереработчика = ((byte[])Читалка.GetValue(15))[0]==1?true:false;
							Ссылка.РаспределятьНаПродукциюИзДавальческогоСырья = ((byte[])Читалка.GetValue(16))[0]==1?true:false;
							Ссылка.РаспределятьНаПодчиненныеПодразделения = ((byte[])Читалка.GetValue(17))[0]==1?true:false;
							Ссылка.РаспределятьНаНаработку = ((byte[])Читалка.GetValue(18))[0]==1?true:false;
							Ссылка.Процент = Читалка.GetDecimal(19);
							Ссылка.Коэффициент = Читалка.GetDecimal(20);
							Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(21));
							Ссылка.ИзменитьНаПроцент = ((byte[])Читалка.GetValue(23))[0]==1?true:false;
							Ссылка.ИзменитьНаКоэффициент = ((byte[])Читалка.GetValue(24))[0]==1?true:false;
							Ссылка.ОкруглитьДо = ((byte[])Читалка.GetValue(25))[0]==1?true:false;
							Ссылка.Применимость = V82.Перечисления/*Ссылка*/.ХарактерЗатрат.ПустаяСсылка.Получить((byte[])Читалка.GetValue(27));
							Ссылка.ИспользоватьПростоеРаспределение = ((byte[])Читалка.GetValue(28))[0]==1?true:false;
							Ссылка.НаправлениеРаспределения = V82.Перечисления/*Ссылка*/.НаправленияРаспределенияЗатрат.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Ссылка.КогдаПрименять = Читалка.GetString(30);
							Ссылка.ТипБазыРаспределения = V82.Перечисления/*Ссылка*/.ТипыБазРаспределения.ПустаяСсылка.Получить((byte[])Читалка.GetValue(31));
							return Ссылка;
						}
						else
						{
							return null;
						}
					}
				}
			}
		}

		public static СправочникиВыборка.СпособыРаспределенияЗатратНаВыпуск Выбрать()
		{
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					Команда.CommandText = @"Select top 1000 
					_IDRRef [Ссылка]
					,_Version [Версия]
					,_Marked [ПометкаУдаления]
					,_IsMetadata [Предопределенный]
					,_Code [Код]
					,_Description [Наименование]
					,_Fld3740 [Комментарий]
					,_Fld3741RRef [СпособРаспределенияЗатратНаВыпуск]
					,_Fld3742RRef [ТипФильтраПриРаспределенииЗатратНаВыпуск]
					,_Fld3743RRef [БазаРаспределенияЗатрат]
					,_Fld3744RRef [ПоказательБазыРаспределения]
					,_Fld3745RRef [ТипЦен]
					,_Fld3746RRef [ОсновноеСырье]
					,_Fld3747RRef [СпособРаспределенияЗатратПоПодразделениям]
					,_Fld3748 [РаспределятьНаСобственнуюПродукцию]
					,_Fld3749 [РаспределятьНаПродукциюСтороннегоПереработчика]
					,_Fld3750 [РаспределятьНаПродукциюИзДавальческогоСырья]
					,_Fld3751 [РаспределятьНаПодчиненныеПодразделения]
					,_Fld3752 [РаспределятьНаНаработку]
					,_Fld3753 [Процент]
					,_Fld3754 [Коэффициент]
					,_Fld3755RRef [ПорядокОкругления]
					,_Fld3756 [НастройкиПостроителя]
					,_Fld3757 [ИзменитьНаПроцент]
					,_Fld3758 [ИзменитьНаКоэффициент]
					,_Fld3759 [ОкруглитьДо]
					,_Fld3760 [СхемаКомпоновкиДанных]
					,_Fld3761RRef [Применимость]
					,_Fld3762 [ИспользоватьПростоеРаспределение]
					,_Fld3763RRef [НаправлениеРаспределения]
					,_Fld3764 [КогдаПрименять]
					,_Fld3765RRef [ТипБазыРаспределения]
							From _Reference244(NOLOCK)";
					var Выборка = new V82.СправочникиВыборка.СпособыРаспределенияЗатратНаВыпуск();
					using (var Читалка = Команда.ExecuteReader())
					{
						while (Читалка.Read())
						{
							var Ссылка = new СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск();
							//ToDo: Читать нужно через GetValues()
							Ссылка.Ссылка = new Guid((byte[])Читалка.GetValue(0));
							var ПотокВерсии = ((byte[])Читалка.GetValue(1));
							Array.Reverse(ПотокВерсии);
							Ссылка.Версия =  BitConverter.ToInt64(ПотокВерсии, 0);
							Ссылка.ПометкаУдаления = ((byte[])Читалка.GetValue(2))[0]==1?true:false;
							Ссылка.Предопределенный = ((byte[])Читалка.GetValue(3))[0]==1?true:false;
							Ссылка.Код = Читалка.GetString(4);
							Ссылка.Наименование = Читалка.GetString(5);
							Ссылка.Комментарий = Читалка.GetString(6);
							Ссылка.СпособРаспределенияЗатратНаВыпуск = V82.Перечисления/*Ссылка*/.СпособыРаспределенияЗатратНаВыпуск.ПустаяСсылка.Получить((byte[])Читалка.GetValue(7));
							Ссылка.ТипФильтраПриРаспределенииЗатратНаВыпуск = V82.Перечисления/*Ссылка*/.ТипыФильтровПриРаспределенииЗатратНаВыпуск.ПустаяСсылка.Получить((byte[])Читалка.GetValue(8));
							Ссылка.БазаРаспределенияЗатрат = V82.Перечисления/*Ссылка*/.БазыРаспределенияЗатрат.ПустаяСсылка.Получить((byte[])Читалка.GetValue(9));
							Ссылка.ПоказательБазыРаспределения = V82.Перечисления/*Ссылка*/.ВидыПоказателейБазыРаспределения.ПустаяСсылка.Получить((byte[])Читалка.GetValue(10));
							//Ссылка.ТипЦен = new V82.СправочникиСсылка.ТипыЦенНоменклатуры((byte[])Читалка.GetValue(11));
							//Ссылка.ОсновноеСырье = new V82.СправочникиСсылка.ОсновноеСырье((byte[])Читалка.GetValue(12));
							//Ссылка.СпособРаспределенияЗатратПоПодразделениям = new V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск((byte[])Читалка.GetValue(13));
							Ссылка.РаспределятьНаСобственнуюПродукцию = ((byte[])Читалка.GetValue(14))[0]==1?true:false;
							Ссылка.РаспределятьНаПродукциюСтороннегоПереработчика = ((byte[])Читалка.GetValue(15))[0]==1?true:false;
							Ссылка.РаспределятьНаПродукциюИзДавальческогоСырья = ((byte[])Читалка.GetValue(16))[0]==1?true:false;
							Ссылка.РаспределятьНаПодчиненныеПодразделения = ((byte[])Читалка.GetValue(17))[0]==1?true:false;
							Ссылка.РаспределятьНаНаработку = ((byte[])Читалка.GetValue(18))[0]==1?true:false;
							Ссылка.Процент = Читалка.GetDecimal(19);
							Ссылка.Коэффициент = Читалка.GetDecimal(20);
							Ссылка.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка.Получить((byte[])Читалка.GetValue(21));
							Ссылка.ИзменитьНаПроцент = ((byte[])Читалка.GetValue(23))[0]==1?true:false;
							Ссылка.ИзменитьНаКоэффициент = ((byte[])Читалка.GetValue(24))[0]==1?true:false;
							Ссылка.ОкруглитьДо = ((byte[])Читалка.GetValue(25))[0]==1?true:false;
							Ссылка.Применимость = V82.Перечисления/*Ссылка*/.ХарактерЗатрат.ПустаяСсылка.Получить((byte[])Читалка.GetValue(27));
							Ссылка.ИспользоватьПростоеРаспределение = ((byte[])Читалка.GetValue(28))[0]==1?true:false;
							Ссылка.НаправлениеРаспределения = V82.Перечисления/*Ссылка*/.НаправленияРаспределенияЗатрат.ПустаяСсылка.Получить((byte[])Читалка.GetValue(29));
							Ссылка.КогдаПрименять = Читалка.GetString(30);
							Ссылка.ТипБазыРаспределения = V82.Перечисления/*Ссылка*/.ТипыБазРаспределения.ПустаяСсылка.Получить((byte[])Читалка.GetValue(31));
							Выборка.Add(Ссылка);
						}
							return Выборка;
					}
				}
			}
		}

		public static V82.СправочникиОбъект.СпособыРаспределенияЗатратНаВыпуск СоздатьЭлемент()
		{
			var Объект = new V82.СправочникиОбъект.СпособыРаспределенияЗатратНаВыпуск();
			Объект._ЭтоНовый = true;
			Объект.Ссылка = Guid.NewGuid();/*http://msdn.microsoft.com/ru-ru/library/aa379322(VS.85).aspx*/
			Объект.ЭтоГруппа = false;
			Объект.Комментарий = "";
			Объект.КогдаПрименять = "";
			Объект.СпособРаспределенияЗатратНаВыпуск = V82.Перечисления/*Ссылка*/.СпособыРаспределенияЗатратНаВыпуск.ПустаяСсылка;
			Объект.ТипФильтраПриРаспределенииЗатратНаВыпуск = V82.Перечисления/*Ссылка*/.ТипыФильтровПриРаспределенииЗатратНаВыпуск.ПустаяСсылка;
			Объект.БазаРаспределенияЗатрат = V82.Перечисления/*Ссылка*/.БазыРаспределенияЗатрат.ПустаяСсылка;
			Объект.ПоказательБазыРаспределения = V82.Перечисления/*Ссылка*/.ВидыПоказателейБазыРаспределения.ПустаяСсылка;
			Объект.ТипЦен = new V82.СправочникиСсылка.ТипыЦенНоменклатуры();
			Объект.ОсновноеСырье = new V82.СправочникиСсылка.ОсновноеСырье();
			Объект.СпособРаспределенияЗатратПоПодразделениям = new V82.СправочникиСсылка.СпособыРаспределенияЗатратНаВыпуск();
			Объект.ПорядокОкругления = V82.Перечисления/*Ссылка*/.ПорядкиОкругления.ПустаяСсылка;
			Объект.Применимость = V82.Перечисления/*Ссылка*/.ХарактерЗатрат.ПустаяСсылка;
			Объект.НаправлениеРаспределения = V82.Перечисления/*Ссылка*/.НаправленияРаспределенияЗатрат.ПустаяСсылка;
			Объект.ТипБазыРаспределения = V82.Перечисления/*Ссылка*/.ТипыБазРаспределения.ПустаяСсылка;
			return Объект;
		}
	}
}
