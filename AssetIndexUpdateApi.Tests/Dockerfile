FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ARG LBHPACKAGESTOKEN
ENV LBHPACKAGESTOKEN=$LBHPACKAGESTOKEN

WORKDIR /app

# Copy csproj and nuget config and restore as distinct layers
COPY ./AssetIndexUpdateApi.sln ./
COPY ./AssetIndexUpdateApi/AssetIndexUpdateApi.csproj ./AssetIndexUpdateApi/
COPY ./AssetIndexUpdateApi.Tests/AssetIndexUpdateApi.Tests.csproj ./AssetIndexUpdateApi.Tests/
COPY /NuGet.Config /root/.nuget/NuGet/NuGet.Config

RUN dotnet restore ./AssetIndexUpdateApi/AssetIndexUpdateApi.csproj
RUN dotnet restore ./AssetIndexUpdateApi.Tests/AssetIndexUpdateApi.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out AssetIndexUpdateApi.Tests/AssetIndexUpdateApi.Tests.csproj

CMD dotnet test
