TITLE 'Build Lottery project'

ECHO 'BEGIN Build'

call src/Lottery.Infrastructure/build-window.bat
call src/Lottery.Entity/build-window.bat
call src/Lottery.Repository/build-window.bat
call src/Lottery.Repository.EntityFramework/build-window.bat
call src/Lottery.Prediction/build-window.bat
call src/Lottery.Service/build-window.bat
call src/Lottery.Web.Infrastructure/build-window.bat
call src/Lottery.Web.Api/build-window.bat

ECHO OFF
