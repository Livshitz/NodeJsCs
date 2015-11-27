@WHERE node.exe
@IF %ERRORLEVEL%==0 (
node %*
) ELSE (
ECHO NODE.JS was not found
ECHO.
ECHO node.exe is missing
ECHO.
ECHO For more information: http://nodejs.org/
ECHO.
PAUSE
)