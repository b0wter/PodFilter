FROM microsoft/aspnetcore-build:2.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.sln ./
COPY ./PodfilterCore/*.csproj ./PodfilterCore/
COPY ./PodfilterWeb/*.csproj ./PodfilterWeb/
COPY ./PodfilterRepository/*.csproj ./PodfilterRepository/
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY --from=build-env /app/PodfilterWeb/out .
ENTRYPOINT ["dotnet", "PodfilterWeb.dll"]