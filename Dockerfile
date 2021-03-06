﻿FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
 
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["test2.csproj", "."]
RUN dotnet restore "test2.csproj"
COPY . .
RUN dotnet build "test2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "test2.csproj" -c Release -o /app/publish


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "test2.dll"]