// Partial type definitions for Node.js v0.12.2
// Project: http://nodejs.org/

using System;
using DuoCode.Runtime;

#pragma warning disable 0626 // disable: method is marked external and has no attributes on it
#pragma warning disable 0824 // disable: constructor 'ctor' is marked external

namespace NodeJs // http://nodejs.org/api/
{
	[Js(Extern = true, Name = "")]
	public static class Global
	{
		public static extern string __filename { get; }
		public static extern string __dirname { get; }
		public static extern dynamic module { get; }
		public static extern dynamic exports { get; }

		public static extern object setTimeout(Action callback, int milliseconds);
		public static extern void clearTimeout(object handle);
		public static extern object setInterval(Action callback, int milliseconds);
		public static extern void clearInterval(object handle);
	}

	[Js(Extern = true)]
	public class Buffer // http://nodejs.org/api/buffer.html
	{
		public extern Buffer(int size);
		public extern Buffer(Array array);
		public extern Buffer(Buffer buffer);
		public extern Buffer(string str, string encoding = "utf8");

		public static extern bool isEncoding(string encoding);
		public static extern bool isBuffer(object obj);
		public static extern int byteLength(string str, string encoding = "utf8");
		public static extern Buffer concat(Buffer[] list, int totalLength = 0);
		public static extern int compare(Buffer buf1, Buffer buf2);

		public extern int length { get; }

		public extern int write(string @string, int offset = 0, int length = 0, string encoding = "utf8");
		public extern int writeUIntLE(uint value, int offset, int byteLength, bool noAssert = false);
		public extern int writeUIntBE(uint value, int offset, int byteLength, bool noAssert = false);
		public extern int writeIntLE(int value, int offset, int byteLength, bool noAssert = false);
		public extern int writeIntBE(int value, int offset, int byteLength, bool noAssert = false);

		public extern uint readUIntLE(int offset, int byteLength, bool noAssert = false);
		public extern uint readUIntBE(int offset, int byteLength, bool noAssert = false);
		public extern int readIntLE(int offset, int byteLength, bool noAssert = false);
		public extern int readIntBE(int offset, int byteLength, bool noAssert = false);

		public extern string toString();
		public extern string toString(string encoding = "utf8", int start = 0, int end = 0);
		public extern string toJSON();

		public extern byte this[int index] { get; set; }
		public extern bool equals(Buffer otherBuffer);
		public extern int compare(Buffer otherBuffer);
		public extern void copy(Buffer targetBuffer, int targetStart = 0, int sourceStart = 0, int sourceEnd = 0);
		public extern Buffer slice(int start = 0, int end = 0);

		public extern byte readUInt8(int offset, bool noAssert = false);
		public extern ushort readUInt16LE(int offset, bool noAssert = false);
		public extern ushort readUInt16BE(int offset, bool noAssert = false);
		public extern uint readUInt32LE(int offset, bool noAssert = false);
		public extern uint readUInt32BE(int offset, bool noAssert = false);
		public extern sbyte readInt8(int offset, bool noAssert = false);
		public extern short readInt16LE(int offset, bool noAssert = false);
		public extern short readInt16BE(int offset, bool noAssert = false);
		public extern int readInt32LE(int offset, bool noAssert = false);
		public extern int readInt32BE(int offset, bool noAssert = false);
		public extern float readFloatLE(int offset, bool noAssert = false);
		public extern float readFloatBE(int offset, bool noAssert = false);
		public extern double readDoubleLE(int offset, bool noAssert = false);
		public extern double readDoubleBE(int offset, bool noAssert = false);

		public extern void writeUInt8(byte value, int offset, bool noAssert = false);
		public extern void writeUInt16LE(ushort value, int offset, bool noAssert = false);
		public extern void writeUInt16BE(ushort value, int offset, bool noAssert = false);
		public extern void writeUInt32LE(uint value, int offset, bool noAssert = false);
		public extern void writeUInt32BE(uint value, int offset, bool noAssert = false);
		public extern void writeInt8(sbyte value, int offset, bool noAssert = false);
		public extern void writeInt16LE(short value, int offset, bool noAssert = false);
		public extern void writeInt16BE(short value, int offset, bool noAssert = false);
		public extern void writeInt32LE(int value, int offset, bool noAssert = false);
		public extern void writeInt32BE(int value, int offset, bool noAssert = false);
		public extern void writeFloatLE(float value, int offset, bool noAssert = false);
		public extern void writeFloatBE(float value, int offset, bool noAssert = false);
		public extern void writeDoubleLE(double value, int offset, bool noAssert = false);
		public extern void writeDoubleBE(double value, int offset, bool noAssert = false);
	}

	[Js(Extern = true, Name = "console")]
	public static class Console // https://nodejs.org/api/console.html
	{
		public extern static void log(params object[] data);
		public extern static void log(string format, params object[] data);
		public extern static void info(params object[] data);
		public extern static void info(string format, params object[] data);
		public extern static void error(params object[] data);
		public extern static void error(string format, params object[] data);
		public extern static void warn(params object[] data);
		public extern static void warn(string format, params object[] data);
		public extern static void dir(object obj, object options = null);
		public extern static void time(string label);
		public extern static void timeEnd(string label);
		public extern static void trace(string message, params object[] data);
		public extern static void assert(bool value, string message = null, params object[] data);
	}

	[Js(Extern = true)]
	public class ReadableStream
	{
		public extern bool readable { get; }
		public extern dynamic read();
		public extern dynamic read(int size);
		public extern void setEncoding(string encoding);
		public extern void pause();
		public extern void resume();
		public extern WritableStream pipe(WritableStream destination, JsDictionary<string, object> options);
		public extern void unpipe();
		public extern void unpipe(WritableStream destination);
		public extern void unshift(string chunk);
		//public extern void unshift(NodeBuffer chunk);
		[Obsolete]
		public extern ReadableStream wrap(ReadableStream oldStream);

		protected ReadableStream() { }
	}

	[Js(Extern = true)]
	public class WritableStream
	{
		public extern bool writable { get; }
		//bool write(buffer: NodeBuffer, cb?: Function): boolean;
		public extern bool write(string data);
		public extern bool write(string data, Action callback);
		public extern bool write(string data, string encoding, Action callback);
		public extern void end();
		public extern void end(string data);
		public extern void end(string data, string encoding);

		protected WritableStream() { }
	}

	namespace Events // http://nodejs.org/api/events.html
	{
		[Js(Extern = true)]
		public class EventEmitter
		{
			static extern int listenerCount(EventEmitter emitter, string @event);

			public extern EventEmitter addListener(string @event, Delegate listener);
			public extern EventEmitter on(string @event, Delegate listener);
			public extern EventEmitter once(string @event, Delegate listener);
			public extern EventEmitter removeListener(string @event, Delegate listener);
			public extern EventEmitter removeAllListeners();
			public extern EventEmitter removeAllListeners(string @event);
			public extern void setMaxListeners(int n);
			public extern Delegate[] listeners(string @event);
			public extern bool emit(string @event, object arg1);
			public extern bool emit(string @event, object arg1, object arg2);
			public extern bool emit(string @event, object arg1, object arg2, object arg3);
			public extern bool emit(string @event, object arg1, object arg2, object arg3, object arg4);
			public extern bool emit(string @event, __arglist);

			protected EventEmitter() { }
		}
	}

	namespace Os // http://nodejs.org/api/os.html
	{
		[Js(Extern = true)]
		public interface Os
		{
			string tmpdir();
			string endianness();
			string hostname();
			string type();
			string platform();
			string arch();
			string release();
			double uptime();
			double[] loadavg();
			long totalmem();
			long freemem();
			dynamic[] cpus();
			dynamic[] networkInterfaces();
			string EOL { get; }
		}
	}

	namespace Http // http://nodejs.org/api/http.html
	{
		[Js(Extern = true)]
		public class Agent
		{
			public extern int maxSockets { get; set; }
			public extern dynamic sockets { get; }
			public extern dynamic requests { get; }

			private Agent() { }
		}

		[Js(Extern = true)]
		public class Server : Events.EventEmitter
		{
			public extern void listen(int port);
			public extern void listen(int port, string hostname);
			public extern void listen(int port, string hostname, int backlog);
			public extern void listen(int port, string hostname, int backlog, Action callback);

			public extern void listen(string path, Action callback = null);

			public extern void listen(object handle, Action callback = null);

			public extern void close();
			public extern void close(Action callback);

			public extern void setTimeout(int msecs, Action callback);

			public extern int maxHeadersCount { get; set; }
			public extern int timeout { get; set; }

			private Server() { }
		}

		[Js(Extern = true)]
		public class IncomingMessage : ReadableStream
		{
			public extern string httpVersion { get; }
			public extern JsDictionary<string, string> headers { get; }
			public extern JsDictionary<string, string> trailers { get; }
			public extern string method { get; }
			public extern string url { get; }
			public extern int statusCode { get; }
			public extern /*Socket*/ object socket /* connection */ { get; }

			public extern void setTimeout(int msecs, Action callback);

			private IncomingMessage() { }
		}

		[Js(Extern = true)]
		public class ServerResponse : WritableStream
		{
			public extern bool headersSent { get; }
			public extern int statusCode { get; set; }
			public extern bool sendDate { get; set; }

			public extern void writeContinue();
			public extern void writeHead(int statusCode);
			public extern void writeHead(int statusCode, string reasonPhrase);
			public extern void writeHead(int statusCode, JsDictionary<string, string> headers);
			public extern void writeHead(int statusCode, string reasonPhrase, JsDictionary<string, string> headers);

			public extern void setHeader(string name, string value);
			public extern void setHeader(string name, params string[] value);

			public extern void setTimeout(int msecs, Action callback);

			public extern string getHeader(string name);
			public extern string removeHeader(string name);

			public extern void addTrailers(JsDictionary<string, string> trailers);

			private ServerResponse() { }
		}

		[Js(Extern = true)]
		public class ClientRequest : WritableStream
		{
			public extern void abort();
			public extern void setTimeout(int timeout);
			public extern void setTimeout(int timeout, Action callback);
			public extern void setNoDelay(bool noDelay);
			public extern void setSocketKeepAlive(bool enable = false, int initialDelay = 0);

			private ClientRequest() { }
		}

		[Js(Extern = true)]
		public interface Http
		{
			JsDictionary<int, string> STATUS_CODES { get; }

			Agent globalAgent { get; }

			Server createServer(Action<IncomingMessage, ServerResponse> requestListener);

			ClientRequest request(string options, Action<IncomingMessage> callback);
			ClientRequest request(JsDictionary<string, string> options, Action<IncomingMessage> callback);
			ClientRequest get(JsDictionary<string, string> options, Action<IncomingMessage> callback);
		}
	}
}
