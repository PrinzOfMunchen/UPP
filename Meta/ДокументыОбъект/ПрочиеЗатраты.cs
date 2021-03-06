﻿
using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.Serialization;
using ProtoBuf;/*https://github.com/ServiceStack/ServiceStack/tree/master/lib*/
using ServiceStack.Text;/*https://github.com/ServiceStack/ServiceStack.Text*/
using V82;
using V82.ОбщиеОбъекты;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.ДокументыСсылка;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	///<summary>
	///(Общ)
	///</summary>
	[ProtoContract]
	[DataContract]
	public partial class ПрочиеЗатраты:ДокументОбъект
	{
		public bool _ЭтоНовый;
		public bool ЭтоНовый()
		{
			return _ЭтоНовый;
		}
		[DataMember]
		[ProtoMember(1)]
		public Guid Ссылка {get;set;}
		[DataMember]
		[ProtoMember(2)]
		public long Версия {get;set;}
		[DataMember]
		[ProtoMember(3)]
		public string ВерсияДанных {get;set;}
		/*static хэш сумма состава и порядка реквизитов*/
		/*версия класса восстановленного из пакета*/
		[DataMember]
		[ProtoMember(4)]
		public bool ПометкаУдаления {get;set;}
		[DataMember]
		[ProtoMember(5)]
		public DateTime Дата {get;set;}
		[DataMember]
		[ProtoMember(6)]
		public DateTime ПрефиксНомера {get;set;}
		[DataMember]
		[ProtoMember(7)]
		public string/*11*/ Номер {get;set;}
		[DataMember]
		[ProtoMember(8)]
		public bool Проведен {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(9)]
		public V82.Перечисления/*Ссылка*/.ВидыОперацийПрочиеЗатраты ВидОперации {get;set;}//Вид операции
		///<summary>
		///(Общ) Любая дополнительная информация
		///</summary>
		[DataMember]
		[ProtoMember(10)]
		public string/*(0)*/ Комментарий {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(11)]
		public V82.СправочникиСсылка.Организации Организация {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(12)]
		public V82.СправочникиСсылка.Пользователи Ответственный {get;set;}
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(13)]
		public bool ОтражатьВУправленческомУчете {get;set;}//Отражать в управленческом учете
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(14)]
		public bool ОтражатьВБухгалтерскомУчете {get;set;}//Отражать в бухгалтерском учете
		///<summary>
		///(Общ)
		///</summary>
		[DataMember]
		[ProtoMember(15)]
		public bool ОтражатьВНалоговомУчете {get;set;}//Отражать в налоговом учете
		///<summary>
		///(Упр)
		///</summary>
		[DataMember]
		[ProtoMember(16)]
		public V82.СправочникиСсылка.Подразделения Подразделение {get;set;}
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(17)]
		public V82.СправочникиСсылка.ПодразделенияОрганизаций ПодразделениеОрганизации {get;set;}//Подразделение организации
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(18)]
		public object Счет {get;set;}
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(19)]
		public object Субконто1 {get;set;}//Субконто 1
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(20)]
		public object Субконто2 {get;set;}//Субконто 2
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(21)]
		public object Субконто3 {get;set;}//Субконто 3
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(22)]
		public object СчетНУ {get;set;}//Счет (налоговый учет)
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(23)]
		public object СубконтоНУ1 {get;set;}//Субконто 1 (налоговый учет)
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(24)]
		public object СубконтоНУ2 {get;set;}//Субконто 2 (налоговый учет)
		///<summary>
		///(Регл)
		///</summary>
		[DataMember]
		[ProtoMember(25)]
		public object СубконтоНУ3 {get;set;}//Субконто 3 (налоговый учет)
		[DataMember]
		[ProtoMember(26)]
		public object Проект {get;set;}
		public void Записать()
		{
			//Установка блокировки элемента на горизантально масштабированный кластер.
			//Опционально введение тайм аута на запись одного и того же объекта, не чаще раза в 5-секунд. Защита от спама. упращение алгоритма блокировки.
			//Выделение сервиса для блокировки элемента и генерации кода
			//Выполнение операций контроля без обращений к sql-серверу.
			//Контроль конфликта блокировок.
			//Контроль загрузки булкинсертом гетерогенной коллекции.
			//Контроль уникальности кода для Документов.
			//Контроль уникальности номера для документов, в границах префикса.
			//Контроль владельца, он не может быть группой.
			//Контроль владельца он должен быть задан.
			//Контроль родителя он должен быть группой.
			//Контроль количества уровней, должен соотвествовать метаданным.
			//Контроль версии, объект не должен был быть записан перед чтением текущей записи, алгоритм версионника.
			//Контроль уникальности ссылки
			//Контроль зацикливания
			//Опционально контроль битых ссылок.
			//Соблюдейние транзакционности. ПередЗаписью. Открытие транзации. Валидации. ПриЗаписи. Фиксация транзакции. Информирование о записи элемента.
			using (var Подключение = new SqlConnection(СтрокаСоединения))
			{
				Подключение.Open();
				using (var Команда = Подключение.CreateCommand())
				{
					if(_ЭтоНовый)
					{
						Команда.CommandText = @"
						Insert Into _Document415(
						_IDRRef
						/*,_Version*/
						,_Marked
						,_IsMetadata
						,_Number
						,_Fld10225RRef
						,_Fld10227
						,_Fld10228RRef
						,_Fld10229RRef
						,_Fld10230
						,_Fld10231
						,_Fld10232
						,_Fld10233RRef
						,_Fld10234RRef
						,_Fld10235RRef
						,_Fld10236RRef
						,_Fld10237RRef
						,_Fld10238RRef
						,_Fld10239RRef
						,_Fld10240RRef
						,_Fld10241RRef
						,_Fld10242RRef)
						Values(
						@Ссылка
						/*,@Версия*/
						,@ПометкаУдаления
						,@Номер
						,@ВидОперации
						,@Комментарий
						,@Организация
						,@Ответственный
						,@ОтражатьВУправленческомУчете
						,@ОтражатьВБухгалтерскомУчете
						,@ОтражатьВНалоговомУчете
						,@Подразделение
						,@ПодразделениеОрганизации
						,@Счет
						,@Субконто1
						,@Субконто2
						,@Субконто3
						,@СчетНУ
						,@СубконтоНУ1
						,@СубконтоНУ2
						,@СубконтоНУ3)";
					}
					else
					{
						Команда.CommandText = @"
						Update _Document415
						Set
						/*_IDRRef	= @Ссылка*/
						/*,_Version	= @Версия*/
						_Marked	= @ПометкаУдаления
						,_Number	= @Номер
						,_Fld10225RRef	= @ВидОперации
						,_Fld10227	= @Комментарий
						,_Fld10228RRef	= @Организация
						,_Fld10229RRef	= @Ответственный
						,_Fld10230	= @ОтражатьВУправленческомУчете
						,_Fld10231	= @ОтражатьВБухгалтерскомУчете
						,_Fld10232	= @ОтражатьВНалоговомУчете
						,_Fld10233RRef	= @Подразделение
						,_Fld10234RRef	= @ПодразделениеОрганизации
						,_Fld10235RRef	= @Счет
						,_Fld10236RRef	= @Субконто1
						,_Fld10237RRef	= @Субконто2
						,_Fld10238RRef	= @Субконто3
						,_Fld10239RRef	= @СчетНУ
						,_Fld10240RRef	= @СубконтоНУ1
						,_Fld10241RRef	= @СубконтоНУ2
						,_Fld10242RRef	= @СубконтоНУ3
						Where _IDRRef = @Ссылка";
					}
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					/*Команда.Parameters.AddWithValue("Версия", Версия);*/
					Команда.Parameters.AddWithValue("ПометкаУдаления", ПометкаУдаления);
					Команда.Parameters.AddWithValue("Номер", Номер);
					Команда.Parameters.AddWithValue("ВидОперации", ВидОперации.Ключ());
					Команда.Parameters.AddWithValue("Комментарий", Комментарий);
					Команда.Parameters.AddWithValue("ОтражатьВУправленческомУчете", ОтражатьВУправленческомУчете);
					Команда.Parameters.AddWithValue("ОтражатьВБухгалтерскомУчете", ОтражатьВБухгалтерскомУчете);
					Команда.Parameters.AddWithValue("ОтражатьВНалоговомУчете", ОтражатьВНалоговомУчете);
					Команда.Parameters.AddWithValue("Счет", Guid.Empty);
					Команда.Parameters.AddWithValue("Субконто1", Guid.Empty);
					Команда.Parameters.AddWithValue("Субконто2", Guid.Empty);
					Команда.Parameters.AddWithValue("Субконто3", Guid.Empty);
					Команда.Parameters.AddWithValue("СчетНУ", Guid.Empty);
					Команда.Parameters.AddWithValue("СубконтоНУ1", Guid.Empty);
					Команда.Parameters.AddWithValue("СубконтоНУ2", Guid.Empty);
					Команда.Parameters.AddWithValue("СубконтоНУ3", Guid.Empty);
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
					Команда.CommandText = @"Delete _Document415
					Where _IDRRef=@Ссылка";
					Команда.Parameters.AddWithValue("Ссылка", Ссылка.ToByteArray());
					Команда.ExecuteNonQuery();
				}
			}
		}
	}
}