echo Start build solution

echo - Restore nuget package 
dotnet restore 
echo - Complete restore nuget package

echo - Build Lottery.Infrastructure project
dotnet build src/Lottery.Infrastructure
echo - Build Lottery.Infrastructure project done

echo - Build Lottery.Entity project
dotnet build src/Lottery.Entity
echo - Build Lottery.Entity project done

echo - Build Lottery.Crawler project
dotnet build src/Lottery.Crawler
echo - Build Lottery.Crawler project done

echo - Build Lottery.Repository project
dotnet build src/Lottery.Repository
echo - Build Lottery.Repository project done

echo - Build Lottery.Repository.EntityFramework project
dotnet build src/Lottery.Repository.EntityFramework
echo - Build Lottery.Repository.EntityFramework project done

echo - Build Lottery.Prediction project
dotnet build src/Lottery.Prediction
echo - Build Lottery.Prediction project done

echo - Build Lottery.Service project
dotnet build src/Lottery.Service
echo - Build Lottery.Service project done

echo - Build Lottery.Web.Infrastructure project
dotnet build src/Lottery.Web.Infrastructure
echo - Build Lottery.Web.Infrastructure project done

echoECHO - Build Lottery.Web.Api project
dotnet build src/Lottery.Web.Api
echo - Build Lottery.Web.Api project done

echo - Complete build application
