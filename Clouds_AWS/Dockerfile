FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Clouds_AWS.csproj", ""]
RUN dotnet restore "./Clouds_AWS.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Clouds_AWS.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Clouds_AWS.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Clouds_AWS.dll"]
