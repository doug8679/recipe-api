#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
WORKDIR /src
COPY ["src/recipe-api/recipe-api.csproj", "src/recipe-api/"]
RUN dotnet restore "src/recipe-api/recipe-api.csproj"
COPY . .
WORKDIR "/src/src/recipe-api"
RUN dotnet build "recipe-api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "recipe-api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "recipe-api.dll"]