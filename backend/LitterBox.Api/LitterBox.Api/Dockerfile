#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LitterBox.Api/LitterBox.Api.csproj", "LitterBox.Api/"]
RUN dotnet restore "LitterBox.Api/LitterBox.Api.csproj"
COPY . .
WORKDIR "/src/LitterBox.Api"
RUN dotnet build "LitterBox.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LitterBox.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LitterBox.Api.dll"]