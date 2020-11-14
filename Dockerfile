FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /app

# Restore
COPY ["src/MyWebApp/*.csproj", "./"]
RUN dotnet restore

# Build
COPY src/MyWebApp/ ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "MyWebApp.dll"]

