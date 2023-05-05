FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/LibraryApplicationSystem.Web.Host/LibraryApplicationSystem.Web.Host.csproj", "src/LibraryApplicationSystem.Web.Host/"]
COPY ["src/LibraryApplicationSystem.Web.Core/LibraryApplicationSystem.Web.Core.csproj", "src/LibraryApplicationSystem.Web.Core/"]
COPY ["src/LibraryApplicationSystem.Application/LibraryApplicationSystem.Application.csproj", "src/LibraryApplicationSystem.Application/"]
COPY ["src/LibraryApplicationSystem.Core/LibraryApplicationSystem.Core.csproj", "src/LibraryApplicationSystem.Core/"]
COPY ["src/LibraryApplicationSystem.EntityFrameworkCore/LibraryApplicationSystem.EntityFrameworkCore.csproj", "src/LibraryApplicationSystem.EntityFrameworkCore/"]
WORKDIR "/src/src/LibraryApplicationSystem.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/LibraryApplicationSystem.Web.Host", "src/LibraryApplicationSystem.Web.Host"]
COPY ["src/LibraryApplicationSystem.Web.Core", "src/LibraryApplicationSystem.Web.Core"]
COPY ["src/LibraryApplicationSystem.Application", "src/LibraryApplicationSystem.Application"]
COPY ["src/LibraryApplicationSystem.Core", "src/LibraryApplicationSystem.Core"]
COPY ["src/LibraryApplicationSystem.EntityFrameworkCore", "src/LibraryApplicationSystem.EntityFrameworkCore"]
WORKDIR "/src/src/LibraryApplicationSystem.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "LibraryApplicationSystem.Web.Host.dll"]
