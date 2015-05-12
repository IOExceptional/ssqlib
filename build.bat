@REM
@REM Build with msbuild
@REM

IF NOT DEFINED WORKSPACE SET WORKSPACE=.

IF DEFINED ProgramFiles(x86) GOTO WinX64
echo 32bit OS
SET MSBUILD="%ProgramFiles%\MSBuild\12.0\Bin\MSBuild.exe"

GOTO exec

:WinX64
echo 64bit OS
SET MSBUILD="%ProgramFiles(x86)%\MSBuild\12.0\Bin\MSBuild.exe"

GOTO exec

:exec

%MSBUILD% "SSQLib\SSQLib.sln" /t:Rebuild /p:Configuration="Release" /p:Platform="Any CPU" 


if %ERRORLEVEL% NEQ 0 exit /b %ERRORLEVEL%


".nuget\nuget.exe" pack "SSQLib\SSQLib.csproj" -Prop Configuration=Release

if %ERRORLEVEL% NEQ 0 exit /b %ERRORLEVEL%

@REM
@REM Copy output to artifacts dir
@REM
MKDIR "%WORKSPACE%\Artifacts"
MKDIR "%WORKSPACE%\Artifacts\bin"

xcopy /F /R /Y /I "*.nupkg" "%WORKSPACE%\Artifacts\"

for /D %%D in (SSQLib*) do (

	MKDIR "%WORKSPACE%\Artifacts\bin\%%D"
	xcopy /E /F /R /Y /I "%%D\obj\Release\*" "%WORKSPACE%\Artifacts\bin\%%D"
)


