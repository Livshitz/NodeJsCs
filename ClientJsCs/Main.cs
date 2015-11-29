using System;
using DuoCode.Runtime;
using Dom = DuoCode.Dom;

namespace ClientJsCs
{
	public class Program
	{
		static void Main()
		{
			Console.WriteLine("Run!");
			//Dom.Global.window.alert("ho");
			//Js.debugger();

			dynamic win = Js.referenceAs<dynamic>("window");
			dynamic angular = win.angular;
			Dom.Global.console.log((object)win);
			//var appServices = angular.module("myAppServices");
			App app = angular.module("myApp", new[] {
				"ngMaterial",
				//"utilsService",

			});

			AllControllers.DefineControllers(app);

			win.app = app;

			Dom.Global.console.log((object)app);
		}
	}
}
