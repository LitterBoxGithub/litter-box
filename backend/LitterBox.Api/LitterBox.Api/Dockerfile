# FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
# WORKDIR /app
# EXPOSE 80
# EXPOSE 443

# FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
# WORKDIR /src
# COPY ["LitterBox.Api/LitterBox.Api.csproj", "LitterBox.Api/"]
# RUN dotnet restore "LitterBox.Api/LitterBox.Api.csproj"
# COPY . .
# WORKDIR "/src/LitterBox.Api"
# RUN dotnet build "LitterBox.Api.csproj" -c Release -o /app/build

# FROM build AS publish
# RUN dotnet publish "LitterBox.Api.csproj" -c Release -o /app/publish

# FROM base AS final
# WORKDIR /src
# COPY --from=publish /src/publish .
# ENTRYPOINT ["dotnet", "LitterBox.Api.dll"]

# Base image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

# Set the working directory
WORKDIR /src

# Copy the project file and restore dependencies
COPY LitterBox.Api.csproj .
RUN dotnet restore

# Copy the rest of the backend source code
COPY . .

# Publish the ASP.NET backend
RUN dotnet publish -c Release -o publish

# Base image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime

# Set the working directory
WORKDIR /src

# Copy the published output of the ASP.NET backend
COPY --from=build /src/publish .

ENV ASPNETCORE_URLS "http://10.0.0.0:5000"
ENV ASPNETCORE_ENVIRONMENT "Development"

# Expose port 5001 for HTTPS
EXPOSE 80:80
EXPOSE 443:443
EXPOSE 5000:5000
EXPOSE 5001:5001

# Set the command to start the ASP.NET backend
CMD ["dotnet", "LitterBox.Api.dll"]