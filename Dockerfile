# 1. Imagen base con .NET 8
FROM mcr.microsoft.com/dotnet/runtime:8.0 AS runtime

# 2. Establece el directorio de trabajo dentro del contenedor
WORKDIR /app

# 3. Copia el ejecutable al contenedor
COPY ProyectoFargate/bin/Release/net8.0/ ./

# 4. Especifica el comando de inicio
CMD ["dotnet", "ProyectoFargateNet8.dll"]
