# Proyecto ASP.NET Web API
Este es un proyecto de ejemplo desarrollado con ASP.NET Web API. A continuación, se describen los pasos necesarios para clonar y poner en marcha este proyecto en tu entorno local.

# Requisitos
Antes de empezar, asegúrate de tener instalados los siguientes componentes:

Visual Studio 2019 o superior,
.NET SDK 8.0,
MySql

# Pasos para clonar y ejecutar el proyecto

1. Clonar el repositorio
Primero, clona el repositorio del proyecto desde GitHub:

bash
Copiar código
git clone https://github.com/cheetos00s/API-ASP.NET.git

2. Abrir el proyecto en Visual Studio
Abre Visual Studio.
Selecciona File > Open > Project/Solution.
Navega a la carpeta donde clonaste el repositorio y selecciona el archivo de solución (.sln).

3. Restaurar los paquetes NuGet
Una vez abierto el proyecto en Visual Studio, ve a herramientas, administrar paquetes NuGet y descarga: 
Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.Tools, MySql.EntityFrameworkCore

4. Configurar la cadena de conexión a la base de datos
Abre el archivo appsettings.json.
Configura la cadena de conexión a tu instancia de SQL Server. Debería verse algo así:
json
Copiar código
"ConnectionStrings": {
  "connection": "Server=tu-servidor;Database=tu-base-de-datos;User Id=tu-usuario;Password=tu-contraseña;"
}

5. Aplicar las migraciones de la base de datos
Abre la Package Manager Console en Visual Studio (Tools > NuGet Package Manager > Package Manager Console).
Ejecuta el siguiente comando para aplicar las migraciones a la base de datos:
bash
Copiar código
Update-Database

6. Ejecutar el proyecto
Selecciona el proyecto de inicio en el Solution Explorer (generalmente es el proyecto que contiene los controladores).
Haz clic en el botón Run (o presiona F5) para iniciar el proyecto.

# Estructura del Proyecto

El proyecto está estructurado de la siguiente manera:

Controllers/: Contiene los controladores de la API.
Models/: Contiene los modelos de datos.
Context/: Contiene el contexto de la base de datos y las migraciones.

# Contribuir
Si deseas contribuir a este proyecto, por favor sigue los siguientes pasos:

Haz un fork del repositorio.
Crea una rama (git checkout -b feature/nueva-funcionalidad).
Realiza tus cambios y haz commits (git commit -am 'Añadir nueva funcionalidad').
Sube los cambios a tu fork (git push origin feature/nueva-funcionalidad).
Abre un Pull Request en GitHub.

# Contacto
Si tienes alguna pregunta o sugerencia, no dudes en contactarme en dcardenaspe@unbosque.edu.co.
