# --- Build stage ---
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution & project
COPY ["MyPCShop-.NET-CORE-MVC.sln", "./"]
COPY ["MyPCShop/MyPCShop.csproj", "MyPCShop/"]

# Restore
RUN dotnet restore "MyPCShop/MyPCShop.csproj"

# Copy all files
COPY . .

# Publish
WORKDIR "/src/MyPCShop"
RUN dotnet publish -c Release -o /app/publish

# --- Runtime stage ---
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "MyPCShop.dll"]
