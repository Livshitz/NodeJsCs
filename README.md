# NodeJsSc
Demonstration of how to use DuoCode to build a NodeJs webb app with C#

### Requirements:
- Visual Studio 2015 Community (free) https://www.visualstudio.com/en-us/features/node-js-vs.aspx
- DuoCode http://duoco.de/download
- NodeToolsForVisualStudio https://github.com/Microsoft/nodejstools

### Description:
Solution contains 2 projects: NodeServer and ServerJsSc.
* ServerJsSc: is the main logic of the node app. It imports npm modules, defines routes and starts the server. When compiled, it's output ("server.js") is put in "NodeServer\server" folder.
* NodeServer: is the Node (by NodeToolsVS) itself. It loads "server.js" (the output of ServerJsCs) and runs it. This is where you put your views, npm modules and static content.

### Setup & Run:
1. npm install
2. restore nuget packages
3. F5 in VS or "node server\server.js"

### Debugging straight from Visual Studio:
![image](https://cloud.githubusercontent.com/assets/246724/11441618/9d8d9142-9516-11e5-98c3-8a6136c3ea13.png)

### Actuall page in browser, run by node:
![image](https://cloud.githubusercontent.com/assets/246724/11441565/f985ccb8-9515-11e5-8bfb-39097ead37fd.png)

### Future:
Must of the code is used with "dynamic" due to lack of C# definitions of npm modules. Unfortunately DuoCode is not popuplar as Typescript is, therefore there are no definitions available yet.
So the plan is to add some definitions, or even create a repository just like https://github.com/DefinitelyTyped/DefinitelyTyped.
Also add angular module and controllers to the pages directly with c#.
