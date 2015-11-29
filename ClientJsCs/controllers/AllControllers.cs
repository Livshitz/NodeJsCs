using System;
using DuoCode.Runtime;
using Dom = DuoCode.Dom;

namespace ClientJsCs
{
	public static class AllControllers
	{
		public static void DefineControllers(App app)
		{
			app.controller("layout", new[] { "$scope", (dynamic)new Action<dynamic>((scope)=> {
				Dom.Global.console.log("scope!!", (object)scope);
				Console.WriteLine("LayoutCtrl");

				scope.text = "This is data from 'layout' controller";
			})});


			app.controller("index", new[] { "$scope", (dynamic)new Action<dynamic>((scope)=> {
				
                Dom.Global.console.log("scope!!", (object)scope);
				Console.WriteLine("Index");

				scope.text = "This is data from 'index' controller !!";
			})});
		}
	}

}