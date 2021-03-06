﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum ВидыПеречисленийВБюджет
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"0c1444c0-b809-4976-a605-dc9aa5476ee6\", \"Представление\":\"НалоговыйПлатеж\"}")]
		НалоговыйПлатеж = 0,//Налоговый платеж
		[EnumMember(Value = "{\"Ссылка\":\"30f993ba-5533-4a75-acf5-463acff9c04f\", \"Представление\":\"ТаможенныйПлатеж\"}")]
		ТаможенныйПлатеж = 1,//Таможенный платеж
		[EnumMember(Value = "{\"Ссылка\":\"06871fdf-07ec-4892-82bf-d3dc3b44e1cc\", \"Представление\":\"ИнойПлатеж\"}")]
		ИнойПлатеж = 2,//Иной платеж
	}
	public static partial class ВидыПеречисленийВБюджет_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid НалоговыйПлатеж = new Guid("9adc05a6-47a5-e66e-4976-b8090c1444c0");//Налоговый платеж
		public static readonly Guid ТаможенныйПлатеж = new Guid("3a46f5ac-f9cf-4fc0-4a75-553330f993ba");//Таможенный платеж
		public static readonly Guid ИнойПлатеж = new Guid("dcd3bf82-443b-cce1-4892-07ec06871fdf");//Иной платеж
		public static ВидыПеречисленийВБюджет Получить(this ВидыПеречисленийВБюджет Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыПеречисленийВБюджет Получить(this ВидыПеречисленийВБюджет Значение, Guid Ссылка)
		{
			if(Ссылка == НалоговыйПлатеж)
			{
				return ВидыПеречисленийВБюджет.НалоговыйПлатеж;
			}
			else if(Ссылка == ТаможенныйПлатеж)
			{
				return ВидыПеречисленийВБюджет.ТаможенныйПлатеж;
			}
			else if(Ссылка == ИнойПлатеж)
			{
				return ВидыПеречисленийВБюджет.ИнойПлатеж;
			}
			return ВидыПеречисленийВБюджет.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыПеречисленийВБюджет Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыПеречисленийВБюджет Значение)
		{
			switch (Значение)
			{
				case ВидыПеречисленийВБюджет.НалоговыйПлатеж: return НалоговыйПлатеж;
				case ВидыПеречисленийВБюджет.ТаможенныйПлатеж: return ТаможенныйПлатеж;
				case ВидыПеречисленийВБюджет.ИнойПлатеж: return ИнойПлатеж;
			}
			return Guid.Empty;
		}
	}
}