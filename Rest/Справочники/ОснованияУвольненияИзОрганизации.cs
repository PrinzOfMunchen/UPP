﻿
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.Справочники
{
	[Route("/Catalogs/OsnovaniyaUvolneniyaIzOrganizacii")]
	[Route("/Catalogs/OsnovaniyaUvolneniyaIzOrganizacii/{Code}")]
	public class OsnovaniyaUvolneniyaIzOrganizaciiRequest/*ОснованияУвольненияИзОрганизацииЗапрос*/: V82.СправочникиСсылка.ОснованияУвольненияИзОрганизации,IReturn<OsnovaniyaUvolneniyaIzOrganizaciiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OsnovaniyaUvolneniyaIzOrganizaciiResponse//ОснованияУвольненияИзОрганизацииОтвет
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/OsnovaniyaUvolneniyaIzOrganizaciis")]
	[Route("/Catalogs/OsnovaniyaUvolneniyaIzOrganizaciis/{Codes}")]
	public class OsnovaniyaUvolneniyaIzOrganizaciisRequest/*ОснованияУвольненияИзОрганизацииЗапрос*/: IReturn<List<OsnovaniyaUvolneniyaIzOrganizaciiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OsnovaniyaUvolneniyaIzOrganizaciisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OsnovaniyaUvolneniyaIzOrganizaciisResponse//ОснованияУвольненияИзОрганизацииОтвет
	{
		public string Result {get;set;}
	}


	public class OsnovaniyaUvolneniyaIzOrganizaciiService /*ОснованияУвольненияИзОрганизацииСервис*/ : Service
	{
		public object Any(OsnovaniyaUvolneniyaIzOrganizaciiRequest request)
		{
			return new OsnovaniyaUvolneniyaIzOrganizaciiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OsnovaniyaUvolneniyaIzOrganizaciiRequest request)
		{
			return null;
		}

		public object Get(OsnovaniyaUvolneniyaIzOrganizaciisRequest request)
		{
			var Коллекция = new List<V82.СправочникиСсылка.ОснованияУвольненияИзОрганизации>();
			foreach (var Code in request.Codes)
			{
					Коллекция.Add(null);
			}
			return Коллекция;
		}

	}
}
