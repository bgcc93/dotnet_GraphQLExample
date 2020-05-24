#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 801
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["API_Inventory/API_Inventory.csproj", "API_Inventory/"]
COPY ["Bootstrapper_Inventory/Bootstrapper_Inventory.csproj", "Bootstrapper_Inventory/"]
COPY ["Infra_Inventory/Infra_Inventory.csproj", "Infra_Inventory/"]
COPY ["Business_Inventory/Business_Inventory.csproj", "Business_Inventory/"]
COPY ["Domain_Inventory/Domain_Inventory.csproj", "Domain_Inventory/"]
RUN dotnet restore "API_Inventory/API_Inventory.csproj"
COPY . .
WORKDIR "/src/API_Inventory"
RUN dotnet build "API_Inventory.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API_Inventory.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API_Inventory.dll"]