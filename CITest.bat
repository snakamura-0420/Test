rem 余計なファイルの削除
git clean -df

rem 変更の取り消し
git checkout .

rem 最新の取得
git checkout -b develop origin/develop

rem コンソールビルド
call Build.bat

pause