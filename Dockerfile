FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build-env

WORKDIR /app

COPY *.sln .
COPY *.csproj ./
RUN dotnet restore

COPY . ./

RUN dotnet publish TransferenciaNFC/API.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

COPY --from=build-env /app/out .

ENTRYPOINT ["dotnet", "API.dll"]