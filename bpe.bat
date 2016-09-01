@echo off

rem
rem ブロックプログラミング環境の起動
rem

rem 設定事項
rem set HOGE="変数の値"

rem このバッチのPIDを設定する
set PID_VAL=0

rem このバッチが存在するフォルダをカレントに
cls

rem Run Board mangaer by background process
start .\BoardManager.exe /b

rem このバッチのタイトルを@@@に変更してtasklistから@@@(自分)のPIDを取得する
for /f "tokens=2 delims=," %%i in ('title @@@^&tasklist /v /fo csv /nh /fi "windowtitle eq @@@"') do set PID_VAL=%%~i

rem echo %PID_VAL%

start /b /wait .\Block.exe .\ScratchSourceCode1.4.image

rem pause

rem 自分自身と子プロセス(BoardManager, Block)も引き連れてkillする
taskkill /t /f /pid %PID_VAL%

exit /b
