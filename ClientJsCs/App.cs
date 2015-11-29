using System;
using DuoCode.Runtime;
using Dom = DuoCode.Dom;

#pragma warning disable 0626 // disable: method is marked external and has no attributes on it
#pragma warning disable 0824 // disable: constructor 'ctor' is marked external

namespace ClientJsCs
{
	[Js(Extern = true, Name = "")]
	public class App
	{
		public extern void controller(string name, dynamic dep);

	}
}

