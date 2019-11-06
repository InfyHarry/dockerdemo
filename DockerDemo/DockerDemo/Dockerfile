FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 5000

FROM microsoft/dotnet:2.1-sdk AS publish
WORKDIR /src
COPY . .
RUN dotnet publish "DockerDemo.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DockerDemo.dll"]