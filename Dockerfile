#.NET SDK Base Image
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

#Copy and restore dependencies
COPY CNA371.csproj .
RUN dotnet restore

#copy the rest of application files and build application
COPY . .
RUN dotnet publish -c Release -o out

#Create runtime Image
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app/out .

#Expose port and set entry point
ENTRYPOINT ["dotnet", "CNA371.dll"]