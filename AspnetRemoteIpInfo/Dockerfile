FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 62379
EXPOSE 44391

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY AspnetRemoteIpInfo/AspnetRemoteIpInfo.csproj AspnetRemoteIpInfo/
RUN dotnet restore AspnetRemoteIpInfo/AspnetRemoteIpInfo.csproj
COPY . .
WORKDIR /src/AspnetRemoteIpInfo
RUN dotnet build AspnetRemoteIpInfo.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish AspnetRemoteIpInfo.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AspnetRemoteIpInfo.dll"]
