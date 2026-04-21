# Calculadora de Comisiones de Ventas

Proyecto desarrollado como una solución técnica para la automatización y gestión de comisiones por ventas, garantizando precisión y eficiencia en el proceso.

## Arquitectura del Sistema

El sistema ha sido construido siguiendo principios de Clean Architecture, dividiendo la lógica en tres capas fundamentales para asegurar la mantenibilidad y escalabilidad:

* Capa de Presentación: Interfaz desarrollada con Blazor Server (.NET 8) para la interacción del usuario.
* Capa de Aplicación: Contiene los servicios (CommissionService) que orquestan la lógica de negocio.
* Capa de Dominio: Alberga las reglas de cálculo e interfaces (ICommissionCalculator), manteniendo la lógica de negocio independiente de las tecnologías externas.

## Tecnologías Utilizadas

* Framework: .NET 8 / Blazor Server.
* Lenguaje: C#.
* Patrones: Inyección de Dependencias, Patrón Result, Clean Architecture.
* Estilos: CSS personalizado con diseño responsive.

## Cómo ejecutar el proyecto

1. Asegúrate de tener instalado el SDK de .NET 8.
2. Clona este repositorio: git clone \[URL-DE-TU-REPO]
3. Navega a la carpeta del proyecto.
4. Restaura las dependencias: dotnet restore
5. Ejecuta el comando: dotnet run
6. Abre tu navegador en https://localhost:7xxx (el puerto aparecerá en la consola).

