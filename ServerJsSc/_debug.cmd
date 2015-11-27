@SET NDS=%APPDATA%\npm\node-debug.cmd
@IF EXIST %NDS% (
%NDS% %*
) ELSE (
ECHO Node Inspector was not found
ECHO.
ECHO "%NDS%" script is missing
ECHO.
ECHO For more information: http://github.com/node-inspector/node-inspector
ECHO.
ECHO If you already installed NODE.JS, run this command in cmd:
ECHO ^> npm install -g node-inspector
ECHO.
ECHO or run the project in RELEASE configuration.
ECHO.
PAUSE
)
