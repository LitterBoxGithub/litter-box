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

ENV ASPNETCORE_URLS "http://host.docker.internal:5000"
ENV ASPNETCORE_ENVIRONMENT "Development"

# Expose ports for http and https
EXPOSE 5000:5000
EXPOSE 5001:5001

# Set the command to start the ASP.NET backend
CMD ["dotnet", "LitterBox.Api.dll"]