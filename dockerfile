#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see http://aka.ms/containercompat 
#
#FROM microsoft/dotnet:2.2-aspnetcore-runtime-nanoserver-1803 AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM microsoft/dotnet:2.2-sdk-nanoserver-1803 AS build
#WORKDIR /src
#COPY *.sln ./
#COPY Services\Services.API\Services.API.csproj Services\Services.API\
#COPY ["Services\Services.API.DataModel\Services.API.DataModel.csproj", "Services\Services.API.DataModel\"]
#COPY ["Services/Services.API.Core/Services.API.Core.csproj", "Services/Services.API.Core/"]
#COPY ["Services/Services.API.DataAccess/Services.API.DataAccess.csproj", "Services/Services.API.DataAccess/"]
#RUN dotnet restore
#COPY . .
#WORKDIR /src/Services/Services.API
#RUN dotnet build -c Release -o /app
#
#FROM build AS publish
#RUN dotnet publish -c Release -o /app
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "Services.API.dll"]
#FROM microsoft/aspnetcore-build:2.0
#WORKDIR /app
#COPY . .
#RUN dotnet build -c release
#ENTRYPOINT ["dotnet", "Services.API.dll"]
#
#FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
#WORKDIR /app
#
## copy csproj and restore as distinct layers
#COPY *.sln .
##COPY */*.csproj ./aspnetapp/
#COPY Services.API/Services.API.csproj ./Services.API/
#COPY Services.API.DataModel/Services.API.DataModel.csproj ./Services.API.DataModel/ 
#COPY Services.API.Core/Services.API.Core.csproj ./Services.API.Core/ 
#COPY Services.API.DataAccess/Services.API.DataAccess.csproj ./Services.API.DataAccess/  
#RUN dotnet restore
#
## copy everything else and build app
#COPY . aspnetapp/
#WORKDIR /app/aspnetapp
#RUN dotnet publish -c Release -o out
#
#
#FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
#WORKDIR /app
#COPY --from=build /app .
#ENTRYPOINT ["dotnet", "Services.API.dll"]
FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Services.API/Services.API.csproj", "Services.API/"]
COPY ["Services.API.DataModel/Services.API.DataModel.csproj", "Services.API.DataModel/"]
COPY ["Services.API.Core/Services.API.Core.csproj", "Services.API.Core/"]
COPY ["Services.API.DataAccess/Services.API.DataAccess.csproj", "Services.API.DataAccess/"]
RUN dotnet restore "Services.API/Services.API.csproj"
COPY . .
WORKDIR "/src/Services.API"
RUN dotnet build "Services.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Services.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Services.API.dll"]