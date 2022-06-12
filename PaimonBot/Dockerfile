FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PaimonBot/PaimonBot.csproj", "PaimonBot/"]
RUN dotnet restore "PaimonBot/PaimonBot.csproj"
COPY . .
WORKDIR "/src/PaimonBot"
RUN dotnet build "PaimonBot.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PaimonBot.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PaimonBot.dll"]
