@echo off

echo - 备份到上一级目录 请耐心等待 / Copying Web Files ...

set date0=%date:~0,10%

xcopy  *.* G:\版本\%date0%\ /s /y /q

