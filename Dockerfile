#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/MyHouse.API/MyHouse.API.csproj", "src/MyHouse.API/"]
RUN dotnet restore "src/MyHouse.API/MyHouse.API.csproj"
COPY . .
WORKDIR "/src/src/MyHouse.API"
RUN dotnet build "MyHouse.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyHouse.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyHouse.API.dll"]