@echo off
git status
git add .
echo Changes added to commit
set /p m="Enter commit message: "
git commit -m "%m%"
git push origin master
pause