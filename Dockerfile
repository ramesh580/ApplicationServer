#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY Services.API/Services.API.csproj ./Services.API/
COPY Services.API.Core/Services.API.Core.csproj ./Services.API.Core/
COPY Services.API.DataAccess/Services.API.DataAccess.csproj ./Services.API.DataAccess/
COPY Services.API.DataModel/Services.API.DataModel.csproj ./Services.API.DataModel/
RUN dotnet restore

# copy everything else and build app
COPY Services.API/. ./Services.API/
COPY Services.API.Core/. ./Services.API.Core/
COPY Services.API.DataAccess/. ./Services.API.DataAccess/
COPY Services.API.DataModel/. ./Services.API.DataModel/
WORKDIR /app/
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app
COPY --from=build /app/Services.API/out ./
ENTRYPOINT ["dotnet", "Services.API.dll"]
