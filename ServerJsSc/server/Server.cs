using System;
using DuoCode.Runtime;
using NodeJs.Http;
using System.IO;

namespace NodejsWebApp
{
	static class Server
	{
		[Js(InvokeMainMode = InvokeMainMode.Immediate)]
		static void Main()
		{
			Js.debugger();

            dynamic express = Js.require<dynamic>("express");
			dynamic path = Js.require<dynamic>("path");
			dynamic body_parser = Js.require<dynamic>("body-parser");
			dynamic partials = Js.require<dynamic>("express-partials");
			dynamic pjax = Js.require<dynamic>("express-pjax");
			dynamic favicon = Js.require<dynamic>("serve-favicon");
			dynamic logger = Js.require<dynamic>("morgan");
			dynamic cookieParser = Js.require<dynamic>("cookie-parser");

            string __dirname = path.resolve(path.dirname()); ;
			Console.WriteLine("__dirname = " + __dirname);

			var app = express();
			app.use("/", express.@static(Path.Combine(__dirname, "./public")));
			app.set("views", __dirname + "/views");
			app.set("view engine", "jade");
			app.use(body_parser());
			app.use(body_parser.urlencoded(new{ extended="true" })); // parse application/x-www-form-urlencoded
			app.use(body_parser.json()); // parse application/json
			app.use(body_parser.json(new{ type="application/vnd.api+json" })); // parse application/vnd.api+json as json
			app.use(partials());
			app.use(pjax());

			app.use(logger("dev"));
			app.use(cookieParser());
			app.use(Js.require<dynamic>("stylus").middleware(path.join(__dirname, "public")));
			//app.use(express.@static(path.join(__dirname, "public")));

			/*
			// catch 404 and forward to error handler
			app.use(new Action<dynamic, dynamic, dynamic>((req, res, next) =>{
				dynamic err = Js.@new("Error", "Not Found");
				err.status = 404;
				next(err);
			}));
			*/

			var http = Js.require<Http>("http");
			const string hostName = "127.0.0.1";
			const int port = 1337;

			foreach(var pair in Routes.RoutesDefinitions)
			{
				app.get(pair.Key, pair.Value);
			}

			app.listen(port, hostName, new Action(() => {
				Console.WriteLine("Express server listening on port {0} in {1} mode", port, (string)app.settings.env);
			}));

			//var server = http.createServer(new Action<IncomingMessage, ServerResponse>(d));
			//server.listen(port, hostName);
			Console.WriteLine(string.Format("Server running at http://{0}:{1}/", hostName, port));

			Js.referenceAs<dynamic>("module").exports = app;
		}

		static void d(IncomingMessage req, ServerResponse res)
		{
			var headers = new JsDictionary<string, string>() { { "Content-Type", "text/plain" } };
			res.writeHead(200, headers);
			res.end("Hello World\n");
		}
	}
}
