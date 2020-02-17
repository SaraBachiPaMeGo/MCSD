# Indica la imagen (Linux) sobre la que montará la App 
FROM microsoft/dotnet:sdk AS build-env 

# Indica el directorio de la máquina Linux para nuestra aplicación 
WORKDIR /app 

# Copia el archivo CSPROJ con los NuGet relacionados que haya declarados 
COPY *.csproj ./ 

# Utiliza el comando RESTORE para resolver los packages de los NuGet 
RUN dotnet restore 

# Copia todo lo demás y publica la aplicación como versión final (Release) 
COPY . ./ 
RUN dotnet publish -c Release -o out 

# Construye la imagen basándose en la DLL de nuestra aplicación. 

FROM microsoft/dotnet:aspnetcore-runtime 

WORKDIR /app 

COPY --from=build-env /app/out . 

ENTRYPOINT ["dotnet", "PruebaDocker.dll"] 