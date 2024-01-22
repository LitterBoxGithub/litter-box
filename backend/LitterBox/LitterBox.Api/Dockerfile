# Base image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Set the working directory
WORKDIR /src

# Copy the project file and restore dependencies
COPY LitterBox.Api.csproj .

# Restore
RUN dotnet restore

# Copy the rest of the backend source code
COPY . .

# Restore and migrate
ENV PATH="$PATH:/root/.dotnet/tools"
RUN dotnet tool install --global dotnet-ef && dotnet ef migrations add InitialCreate --verbose && dotnet ef database update

# Build the application
RUN dotnet build -c Release -o /app

# Publish the ASP.NET backend
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app .
EXPOSE 7902
ENTRYPOINT ["dotnet", "LitterBox.Api.dll", "--urls", "http://+:7902"]