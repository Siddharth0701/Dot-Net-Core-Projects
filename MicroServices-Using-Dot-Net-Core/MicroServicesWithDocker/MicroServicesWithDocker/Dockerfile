FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["MicroServicesWithDocker/MicroServicesWithDocker.csproj", "MicroServicesWithDocker/"]
RUN dotnet restore "MicroServicesWithDocker/MicroServicesWithDocker.csproj"
COPY . .
WORKDIR "/src/MicroServicesWithDocker"
RUN dotnet build "MicroServicesWithDocker.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MicroServicesWithDocker.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MicroServicesWithDocker.dll"]