FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/TryAbp.Web.Host/TryAbp.Web.Host.csproj", "src/TryAbp.Web.Host/"]
COPY ["src/TryAbp.Web.Core/TryAbp.Web.Core.csproj", "src/TryAbp.Web.Core/"]
COPY ["src/TryAbp.Application/TryAbp.Application.csproj", "src/TryAbp.Application/"]
COPY ["src/TryAbp.Core/TryAbp.Core.csproj", "src/TryAbp.Core/"]
COPY ["src/TryAbp.EntityFrameworkCore/TryAbp.EntityFrameworkCore.csproj", "src/TryAbp.EntityFrameworkCore/"]
WORKDIR "/src/src/TryAbp.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/TryAbp.Web.Host", "src/TryAbp.Web.Host"]
COPY ["src/TryAbp.Web.Core", "src/TryAbp.Web.Core"]
COPY ["src/TryAbp.Application", "src/TryAbp.Application"]
COPY ["src/TryAbp.Core", "src/TryAbp.Core"]
COPY ["src/TryAbp.EntityFrameworkCore", "src/TryAbp.EntityFrameworkCore"]
WORKDIR "/src/src/TryAbp.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "TryAbp.Web.Host.dll"]
