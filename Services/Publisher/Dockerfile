#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Services/Publisher/Publisher.csproj", "Services/Publisher/"]
RUN dotnet restore "Services/Publisher/Publisher.csproj"
COPY . .
WORKDIR "/src/Services/Publisher"
RUN dotnet build "Publisher.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Publisher.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Publisher.dll"]
