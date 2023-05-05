FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/LibraryApplicationSystem.Web.Mvc/LibraryApplicationSystem.Web.Mvc.csproj", "src/LibraryApplicationSystem.Web.Mvc/"]
COPY ["src/LibraryApplicationSystem.Web.Core/LibraryApplicationSystem.Web.Core.csproj", "src/LibraryApplicationSystem.Web.Core/"]
COPY ["src/LibraryApplicationSystem.Application/LibraryApplicationSystem.Application.csproj", "src/LibraryApplicationSystem.Application/"]
COPY ["src/LibraryApplicationSystem.Core/LibraryApplicationSystem.Core.csproj", "src/LibraryApplicationSystem.Core/"]
COPY ["src/LibraryApplicationSystem.EntityFrameworkCore/LibraryApplicationSystem.EntityFrameworkCore.csproj", "src/LibraryApplicationSystem.EntityFrameworkCore/"]
WORKDIR "/src/src/LibraryApplicationSystem.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/LibraryApplicationSystem.Web.Mvc", "src/LibraryApplicationSystem.Web.Mvc"]
COPY ["src/LibraryApplicationSystem.Web.Core", "src/LibraryApplicationSystem.Web.Core"]
COPY ["src/LibraryApplicationSystem.Application", "src/LibraryApplicationSystem.Application"]
COPY ["src/LibraryApplicationSystem.Core", "src/LibraryApplicationSystem.Core"]
COPY ["src/LibraryApplicationSystem.EntityFrameworkCore", "src/LibraryApplicationSystem.EntityFrameworkCore"]
WORKDIR "/src/src/LibraryApplicationSystem.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "LibraryApplicationSystem.Web.Mvc.dll"]
