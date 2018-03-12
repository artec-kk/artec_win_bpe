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
start /b "" ".\BoardManager.exe" ja

rem このバッチのタイトルを@@@に変更してtasklistから@@@(自分)のPIDを取得する
for /f "tokens=2 delims=," %%i in ('title @@@^&tasklist /v /fo csv /nh /fi "windowtitle eq @@@"') do set PID_VAL=%%~i

rem echo %PID_VAL%

if "%1" == "" (
  start /b /wait .\Block.exe .\Block.image
) else (
  echo %1
  start /b /wait .\Block.exe %1
)
rem pause

rem 自分自身と子プロセス(BoardManager, Block)も引き連れてkillする
taskkill /t /f /pid %PID_VAL%

exit /b
