# TalentoHumanoApi
Web API desarrollada en .NET Core 6 que gestiona la información de empleados, departamentos, subdepartamentos, roles de empleados y sueldos.

## Requisitos
1. .Net 6
2. Sql Server


## Installation
1. Crear la base de datos ejecutando el script DBNTS.sql
2. Descargar el proyecto
```
git clone https://github.com/Lovelace13/TalentoHumanoApi.git
cd ./TalentoHumanoApi
```
3. Configurar la cadena de conexion a la base de datos en el archivo appsettings.json. (El nombre de la base es NTS)
```
  "ConnectionStrings": {
    "DBConnection": "data source={COLOCAR SU SERVER};initial catalog=NTS;trusted_connection=true;Integrated Security=True"
  }
```

Si no tiene instalado el ef core 6 globalmente ejecutar el siguiente comando
```
dotnet tool install --global dotnet-ef --version 6.*
```

4. Actualizar las dependencias
```
dotnet restore
```

4. Actualizar la base de datos con la migracion que viene en el repositorio 
```
dotnet ef database update
```
3. Ejecutar el proyecto
 ```
dotnet run --project TalentoHumanoApi
```

## Documentacion Swagger
![alt text](https://github.com/Lovelace13/TalentoHumanoApi/blob/master/ApiSwagger.png)

## Creación de Empleado
>URL: /NTS/Empleados/NuevoEmpleado'
>
>Método: POST
>
>Descripción: Crea un nuevo empleado en la base de datos.
>
>Cuerpo de la solicitud: Debe ser un JSON que contenga los siguientes campos:
>
>nombre: Nombre del empleado (string, requerido)
>
>apellido: Apellido del empleado (string, requerido)
>
>fechaContratacion: Fecha de contratación del empleado (datetime, requerido)
>
>departamentoID: ID del departamento al que pertenece el empleado (int, requerido)
>
>subdepartamentoID: ID del subdepartamento al que pertenece el empleado (int, requerido)
>
>rolID: ID del rol del empleado (int, requerido)
>

```json
{
  "nombre": "Katiuska",
  "apellido": "Marín",
  "fechaContratacion": "2024-05-16T01:24:50.986Z",
  "departamentoID": 1,
  "subdepartamentoID": 3,
  "rolID": 2
}
```
