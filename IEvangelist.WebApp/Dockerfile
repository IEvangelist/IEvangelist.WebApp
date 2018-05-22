FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 50895
EXPOSE 44339

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY IEvangelist.WebApp/IEvangelist.WebApp.csproj IEvangelist.WebApp/
RUN dotnet restore IEvangelist.WebApp/IEvangelist.WebApp.csproj
COPY . .
WORKDIR /src/IEvangelist.WebApp
RUN dotnet build IEvangelist.WebApp.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish IEvangelist.WebApp.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "IEvangelist.WebApp.dll"]
