using System;
using System.Net;

namespace TestApp.Models
{
	public class FirebaseResult
	{
		public string Message { get; set; }

		public HttpStatusCode StatusCode { get; set; }
	}
}

