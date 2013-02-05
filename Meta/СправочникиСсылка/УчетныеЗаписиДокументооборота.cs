﻿
using System;
using System.IO;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.СправочникиСсылка
{
	[ProtoContract]
	[DataContract]
	public partial class УчетныеЗаписиДокументооборота:СправочникСсылка,IСериализаторProtoBuf,IСериализаторJson
	{
		public static readonly Guid ГуидКласса = new Guid("b8ae20b8-da26-42d6-aa88-1518a3882bbd");
		public static readonly DateTime ВерсияКласса = DateTime.ParseExact("20121221191416.000", new string[] {"yyyyMMddHHmmss.fff"}, CultureInfo.InvariantCulture, DateTimeStyles.None);
		public static readonly long КонтрольнаяСуммаКласса = 123;
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(3)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(4)]
		public bool Предопределенный {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public string/*5*/ Код {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public string/*150*/ Наименование {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*(255)*/ ИмяПользователяPOP3 {get;set;}//Имя пользователя POP3
		[DataMember]
		[ProtoMember(8)]
		public string/*(255)*/ ПарольPOP3 {get;set;}//Пароль POP3
		[DataMember]
		[ProtoMember(9)]
		public string/*(255)*/ СерверPOP3 {get;set;}//Сервер POP3
		[DataMember]
		[ProtoMember(10)]
		public decimal/*(5)*/ ПортPOP3 {get;set;}//Порт POP3
		[DataMember]
		[ProtoMember(11)]
		public string/*(255)*/ ИмяПользователяSMTP {get;set;}//Имя пользователя SMTP
		[DataMember]
		[ProtoMember(12)]
		public string/*(255)*/ ПарольSMTP {get;set;}//Пароль SMTP
		[DataMember]
		[ProtoMember(13)]
		public string/*(255)*/ СерверSMTP {get;set;}//Сервер SMTP
		[DataMember]
		[ProtoMember(14)]
		public decimal/*(5)*/ ПортSMTP {get;set;}//Порт SMTP
		[DataMember]
		[ProtoMember(15)]
		public bool ТребуетсяSMTPАутентификация {get;set;}//Требуется SMTP Аутентификация
		[DataMember]
		[ProtoMember(16)]
		public string/*(255)*/ АдресЭлектроннойПочты {get;set;}//Адрес электронной почты
		[DataMember]
		[ProtoMember(17)]
		public V82.СправочникиСсылка.НалоговыеОрганы НалоговыйОрган {get;set;}//Налоговый орган
		[DataMember]
		[ProtoMember(18)]
		public V82.СправочникиСсылка.СерверыДокументооборота СерверДокументооборота {get;set;}//Сервер документооборота
		[DataMember]
		[ProtoMember(19)]
		public string/*(40)*/ СертификатРуководителя {get;set;}//Сертификат руководителя
		[DataMember]
		[ProtoMember(20)]
		public string/*(40)*/ СертификатГлавногоБухгалтера {get;set;}//Сертификат главного бухгалтера
		[DataMember]
		[ProtoMember(21)]
		public string/*(40)*/ СертификатДляШифрования {get;set;}//Сертификат для шифрования
		[DataMember]
		[ProtoMember(22)]
		public bool УдалитьАвтоматическоеОпределениеНабораПодписей {get;set;}//Удалить автоматическое определение набора подписей
		[DataMember]
		[ProtoMember(23)]
		public bool ИспользуютсяСъемныеКлючевыеНосители {get;set;}//Используются съемные ключевые носители
		[DataMember]
		[ProtoMember(24)]
		public bool УдалитьНестандартныеТаймауты {get;set;}//Нестандартные таймауты
		[DataMember]
		[ProtoMember(25)]
		public decimal/*(2)*/ УдалитьТаймаутНалоговогоОргана {get;set;}//Таймаут налогового органа
		[DataMember]
		[ProtoMember(26)]
		public decimal/*(2)*/ УдалитьТаймаутНалогоплательщика {get;set;}//Таймаут налогоплательщика
		[DataMember]
		[ProtoMember(27)]
		public bool УдалитьИспользуетсяОбособленнымиПодразделениями {get;set;}//Удалить используется обособленными подразделениями
		[DataMember]
		[ProtoMember(28)]
		public bool ОбменНапрямую {get;set;}//Используется возможность документооборота без посредничества специализированного оператора связи
		[DataMember]
		[ProtoMember(29)]
		public bool ОбменНапрямуюСФСГС {get;set;}//Используется возможность документооборота с Росстатом без посредничества специализированного оператора связи
		[DataMember]
		[ProtoMember(30)]
		public bool НеФормироватьПодтвержденияАвтоматически {get;set;}//Не формировать подтверждения автоматически
		[DataMember]
		[ProtoMember(31)]
		public V82.Перечисления/*Ссылка*/.РежимыАвтонастройкиУчетнойЗаписиДокументооборота РежимАвтонастройки {get;set;}//Режим автонастройки
		[DataMember]
		[ProtoMember(32)]
		public bool ИспользоватьСервисОнлайнПроверкиОтчетов {get;set;}//Использовать сервис онлайн-проверки отчетов
		[DataMember]
		[ProtoMember(33)]
		public bool ПредназначенаДляДокументооборотаСФНС {get;set;}//Предназначена для документооборота с ФНС
		[DataMember]
		[ProtoMember(34)]
		public bool ПредназначенаДляДокументооборотаСПФР {get;set;}//Предназначена для документооборота с ПФР
		[DataMember]
		[ProtoMember(35)]
		public bool ПредназначенаДляДокументооборотаСФСГС {get;set;}//Предназначена для документооборота с Росстатом
		[DataMember]
		[ProtoMember(36)]
		public string/*(3)*/ ИдентификаторСпецоператора {get;set;}//Идентификатор спецоператора
		[DataMember]
		[ProtoMember(37)]
		public string/*(43)*/ ИдентификаторАбонента {get;set;}
		[DataMember]
		[ProtoMember(38)]
		public string/*(40)*/ ИдентификаторСистемыОтправителяПФР {get;set;}//Идентификатор системы отправителя (ПФР)
		[DataMember]
		[ProtoMember(39)]
		public string/*(40)*/ ИдентификаторСистемыОтправителяФСГС {get;set;}//Идентификатор системы отправителя (ФСГС)
		[DataMember]
		[ProtoMember(40)]
		public bool ЯвляетсяУчетнойЗаписьюУполномоченногоПредставителя {get;set;}//Является учетной записью уполномоченного представителя
		[DataMember]
		[ProtoMember(41)]
		public string/*(12)*/ ИННУполномоченногоПредставителя {get;set;}//ИНН уполномоченного представителя
		[DataMember]
		[ProtoMember(42)]
		public string/*(9)*/ КППУполномоченногоПредставителя {get;set;}//КПП уполномоченного представителя
		[DataMember]
		[ProtoMember(43)]
		public string/*(0)*/ ПолноеНаименованиеУполномоченногоПредставителя {get;set;}//Полное наименование уполномоченного представителя
		[DataMember]
		[ProtoMember(44)]
		public V82.Перечисления/*Ссылка*/.СтатусыУчетнойЗаписиДокументооборота СтатусУчетнойЗаписи {get;set;}//Статус учетной записи
		[DataMember]
		[ProtoMember(45)]
		public V82.Перечисления/*Ссылка*/.СпецоператорыСвязи СпецоператорСвязи {get;set;}//Спецоператор связи

		public V82.СправочникиОбъект.УчетныеЗаписиДокументооборота  ПолучитьОбъект()
		{
			var Объект = new V82.СправочникиОбъект.УчетныеЗаписиДокументооборота();
			Объект._ЭтоНовый = false;
			Объект.Ссылка = Ссылка;
			Объект.Версия = Версия;
			Объект.ПометкаУдаления = ПометкаУдаления;
			Объект.Предопределенный = Предопределенный;
			Объект.Код = Код;
			Объект.Наименование = Наименование;
			Объект.ИмяПользователяPOP3 = ИмяПользователяPOP3;
			Объект.ПарольPOP3 = ПарольPOP3;
			Объект.СерверPOP3 = СерверPOP3;
			Объект.ПортPOP3 = ПортPOP3;
			Объект.ИмяПользователяSMTP = ИмяПользователяSMTP;
			Объект.ПарольSMTP = ПарольSMTP;
			Объект.СерверSMTP = СерверSMTP;
			Объект.ПортSMTP = ПортSMTP;
			Объект.ТребуетсяSMTPАутентификация = ТребуетсяSMTPАутентификация;
			Объект.АдресЭлектроннойПочты = АдресЭлектроннойПочты;
			Объект.НалоговыйОрган = НалоговыйОрган;
			Объект.СерверДокументооборота = СерверДокументооборота;
			Объект.СертификатРуководителя = СертификатРуководителя;
			Объект.СертификатГлавногоБухгалтера = СертификатГлавногоБухгалтера;
			Объект.СертификатДляШифрования = СертификатДляШифрования;
			Объект.УдалитьАвтоматическоеОпределениеНабораПодписей = УдалитьАвтоматическоеОпределениеНабораПодписей;
			Объект.ИспользуютсяСъемныеКлючевыеНосители = ИспользуютсяСъемныеКлючевыеНосители;
			Объект.УдалитьНестандартныеТаймауты = УдалитьНестандартныеТаймауты;
			Объект.УдалитьТаймаутНалоговогоОргана = УдалитьТаймаутНалоговогоОргана;
			Объект.УдалитьТаймаутНалогоплательщика = УдалитьТаймаутНалогоплательщика;
			Объект.УдалитьИспользуетсяОбособленнымиПодразделениями = УдалитьИспользуетсяОбособленнымиПодразделениями;
			Объект.ОбменНапрямую = ОбменНапрямую;
			Объект.ОбменНапрямуюСФСГС = ОбменНапрямуюСФСГС;
			Объект.НеФормироватьПодтвержденияАвтоматически = НеФормироватьПодтвержденияАвтоматически;
			Объект.РежимАвтонастройки = РежимАвтонастройки;
			Объект.ИспользоватьСервисОнлайнПроверкиОтчетов = ИспользоватьСервисОнлайнПроверкиОтчетов;
			Объект.ПредназначенаДляДокументооборотаСФНС = ПредназначенаДляДокументооборотаСФНС;
			Объект.ПредназначенаДляДокументооборотаСПФР = ПредназначенаДляДокументооборотаСПФР;
			Объект.ПредназначенаДляДокументооборотаСФСГС = ПредназначенаДляДокументооборотаСФСГС;
			Объект.ИдентификаторСпецоператора = ИдентификаторСпецоператора;
			Объект.ИдентификаторАбонента = ИдентификаторАбонента;
			Объект.ИдентификаторСистемыОтправителяПФР = ИдентификаторСистемыОтправителяПФР;
			Объект.ИдентификаторСистемыОтправителяФСГС = ИдентификаторСистемыОтправителяФСГС;
			Объект.ЯвляетсяУчетнойЗаписьюУполномоченногоПредставителя = ЯвляетсяУчетнойЗаписьюУполномоченногоПредставителя;
			Объект.ИННУполномоченногоПредставителя = ИННУполномоченногоПредставителя;
			Объект.КППУполномоченногоПредставителя = КППУполномоченногоПредставителя;
			Объект.ПолноеНаименованиеУполномоченногоПредставителя = ПолноеНаименованиеУполномоченногоПредставителя;
			Объект.СтатусУчетнойЗаписи = СтатусУчетнойЗаписи;
			Объект.СпецоператорСвязи = СпецоператорСвязи;
			return Объект;
		}

		public void СериализацияProtoBuf(Stream Поток)
		{
			Serializer.Serialize(Поток,this);
		}

		public string СериализацияJson()
		{
			return this.ToJson();
		}

		public string СериализацияXml()
		{
			return this.ToXml();
		}
	}
}
