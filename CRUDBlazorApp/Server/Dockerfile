#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CRUDBlazorApp/Server/CRUDBlazorApp.Server.csproj", "CRUDBlazorApp/Server/"]
COPY ["CRUDBlazorApp/Client/CRUDBlazorApp.Client.csproj", "CRUDBlazorApp/Client/"]
COPY ["CRUDBlazorApp/Shared/CRUDBlazorApp.Shared.csproj", "CRUDBlazorApp/Shared/"]
RUN dotnet restore "CRUDBlazorApp/Server/CRUDBlazorApp.Server.csproj"
COPY . .
WORKDIR "/src/CRUDBlazorApp/Server"
RUN dotnet build "CRUDBlazorApp.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CRUDBlazorApp.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CRUDBlazorApp.Server.dll"]