ECHO OFF
ECHO Start build solution

ECHO - Restore nuget package 
dotnet restore 
ECHO - Complete restore nuget package

ECHO - Build Lottery.Infrastructure project
dotnet build src\Lottery.Infrastructure
ECHO - Build Lottery.Infrastructure project done

ECHO - Build Lottery.Entity project
dotnet build src\Lottery.Entity
ECHO - Build Lottery.Entity project done

ECHO - Build Lottery.Crawler project
dotnet build src\Lottery.Crawler
ECHO - Build Lottery.Crawler project done

ECHO - Build Lottery.Repository project
dotnet build src\Lottery.Repository
ECHO - Build Lottery.Repository project done

ECHO - Build Lottery.Repository.EntityFramework project
dotnet build src\Lottery.Repository.EntityFramework
ECHO - Build Lottery.Repository.EntityFramework project done

ECHO - Build Lottery.Prediction project
dotnet build src\Lottery.Prediction
ECHO - Build Lottery.Prediction project done

ECHO - Build Lottery.Service project
dotnet build src\Lottery.Service
ECHO - Build Lottery.Service project done

ECHO - Build Lottery.Web.Infrastructure project
dotnet build src\Lottery.Web.Infrastructure
ECHO - Build Lottery.Web.Infrastructure project done

ECHO - Build Lottery.Web.Api project
dotnet build src\Lottery.Web.Api
ECHO - Build Lottery.Web.Api project done

ECHO - Complete build application

PAUSE