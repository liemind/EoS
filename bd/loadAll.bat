SETLOCAL
SET directory=.
SET mysqldir="C:\wamp\bin\mysql\mysql5.5.24\bin
SET user=root
SET pwd=
SET dbname=eos
SET server=localhost

for %%f in (.\*.sql) do %mysqldir%\mysql" --user=%user% --password=%pwd% --host=%server% %dbname% < %%f
ENDLOCAL
PAUSE