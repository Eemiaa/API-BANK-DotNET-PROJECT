#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["API-BANK-DotNET-PROJECT/API-BANK-DotNET-PROJECT.csproj", "API-BANK-DotNET-PROJECT/"]
RUN dotnet restore "API-BANK-DotNET-PROJECT/API-BANK-DotNET-PROJECT.csproj"
COPY . .
WORKDIR "/src/API-BANK-DotNET-PROJECT"
RUN dotnet build "API-BANK-DotNET-PROJECT.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API-BANK-DotNET-PROJECT.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API-BANK-DotNET-PROJECT.dll"]