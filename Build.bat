rem Unity�̃p�X
set UNITY_PATH=D:\Unity\Unity2017.2.0p1\Editor

rem �v���W�F�N�g�p�X
set PROJECT_PATH=%~dp0

rem Build�p�X
set BUILD_PATH=%PROJECT_PATH%\Build\Android

rem �r���h���O�̃p�X
set BUILD_LOG=%PROJECT_PATH%\Build\Android\build.log

rem �r���h�֐��̎w��
set BUILD_METHOD=monaka.BuildClass.BuildAndroid

rem Android�r���h���s
mkdir %BUILD_PATH%
%UNITY_PATH%\Unity.exe -batchmode -quit -logFile %BUILD_LOG% -projectPath %PROJECT_PATH% -executeMethod %BUILD_METHOD%

rem �r���h�I��!
pause
