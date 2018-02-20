rem Unityのパス
set UNITY_PATH=D:\Unity\Unity2017.2.0p1\Editor

rem プロジェクトパス
set PROJECT_PATH=%~dp0

rem Buildパス
set BUILD_PATH=%PROJECT_PATH%\Build\Android

rem ビルドログのパス
set BUILD_LOG=%PROJECT_PATH%\Build\Android\build.log

rem ビルド関数の指定
set BUILD_METHOD=monaka.BuildClass.BuildAndroid

rem Androidビルド実行
mkdir %BUILD_PATH%
%UNITY_PATH%\Unity.exe -batchmode -quit -logFile %BUILD_LOG% -projectPath %PROJECT_PATH% -executeMethod %BUILD_METHOD%

rem ビルド終了!
pause
