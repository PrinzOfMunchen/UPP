﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/NastrojjkiRaschetaCenyNomenklatury")]
	[Route("/Catalogs/NastrojjkiRaschetaCenyNomenklatury/{Code}")]
	public class NastrojjkiRaschetaCenyNomenklaturyRequest/*НастройкиРасчетаЦеныНоменклатурыЗапрос*/: V82.СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры,IReturn<NastrojjkiRaschetaCenyNomenklaturyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiRaschetaCenyNomenklaturyResponse//НастройкиРасчетаЦеныНоменклатурыОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiRaschetaCenyNomenklaturys")]
	[Route("/Catalogs/NastrojjkiRaschetaCenyNomenklaturys/{Codes}")]
	public class NastrojjkiRaschetaCenyNomenklaturysRequest/*НастройкиРасчетаЦеныНоменклатурыЗапрос*/: IReturn<List<NastrojjkiRaschetaCenyNomenklaturyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiRaschetaCenyNomenklaturysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiRaschetaCenyNomenklaturysResponse//НастройкиРасчетаЦеныНоменклатурыОтвет
	{
		public string Result {get;set;}
	}


	public class NastrojjkiRaschetaCenyNomenklaturyService /*НастройкиРасчетаЦеныНоменклатурыСервис*/ : Service
	{
		public object Any(NastrojjkiRaschetaCenyNomenklaturyRequest request)
		{
			return new NastrojjkiRaschetaCenyNomenklaturyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiRaschetaCenyNomenklaturyRequest request)
		{
			return null;
		}

		public object Get(NastrojjkiRaschetaCenyNomenklaturysRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.НастройкиРасчетаЦеныНоменклатуры>();
			foreach (var Code in request.Codes)
			{
					Коллекция.Add(null);
			}
			return Коллекция;
		}

	}
}
