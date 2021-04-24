FROM mcr.microsoft.com/dotnet/aspnet:3.1

WORKDIR /home/app 

COPY bin/Release/netcoreapp3.1/publish .

ENTRYPOINT ["dotnet", "WebApi.dll"]