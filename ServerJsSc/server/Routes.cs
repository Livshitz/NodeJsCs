using System;
using System.Collections.Generic;

namespace NodejsWebApp
{
	public static class Routes
	{
		public static Dictionary<string, Action<dynamic, dynamic>> RoutesDefinitions = new Dictionary<string, Action<dynamic, dynamic>>();

		static Routes()
		{
			RoutesDefinitions.Add("/", new Action<dynamic, dynamic>((req, res) => {
				//res.send("Hello World");
				res.render("index", new { title= "NodeJs build with C#" });
				Console.WriteLine("/");
			}));

			RoutesDefinitions.Add("/test", new Action<dynamic, dynamic>((req, res) => {
				res.send("Hello TESTTTT");
				Console.WriteLine("/test");
			}));
		}
	}
}
