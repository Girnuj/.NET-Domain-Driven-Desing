
English [README.en.md](README.en.md)

# Domain-Driven Design en .NET
Este repositorio contiene una prueba práctica de Domain-Driven Design (DDD) implementada en .NET 10, centrada en el contexto de una veterinaria.

La idea de este proyecto es demostrar, de forma sencilla pero estructurada, cómo aplicar principios de DDD en una solución realista, separando claramente las responsabilidades del dominio, la infraestructura y la capa de presentación. El caso de uso está inspirado en un sistema de gestión para una clínica veterinaria, donde se modelan conceptos como pacientes, historias clínicas, citas y procesos de atención.

## Propósito

Antes de entrar en la implementación, es importante reflexionar si esta práctica tiene sentido para el problema real. Domain-Driven Design puede aportar muchas ventajas, pero también implica cierto costo.

### Ventajas

- Ayuda a modelar mejor el dominio de una veterinaria, como pacientes, mascotas, historias clínicas y citas.
- Favorece una arquitectura más limpia y mantenible, con la lógica de negocio aislada del acceso a datos y la interfaz.
- Facilita la comunicación entre equipo técnico y negocio, ya que el lenguaje del dominio se vuelve más explícito.
- Permite escalar la solución con mayor facilidad si el sistema crece en complejidad.

### Desventajas

- Puede resultar excesivo para proyectos pequeños o con requisitos simples.
- Requiere tiempo de análisis y diseño, lo que puede aumentar el coste inicial de desarrollo.
- En algunos casos, la implementación puede volverse más compleja si no existe una comprensión clara del dominio.

Este proyecto sirve como ejercicio práctico para explorar conceptos como:

- Agregados y entidades de dominio
- Value Objects
- Reglas de negocio encapsuladas en el dominio
- Separación entre capa de dominio e infraestructura
- Arquitectura orientada a dominio en aplicaciones .NET

## Estructura de la solución

La solución está organizada en varios proyectos para mantener una separación clara de responsabilidades:

- Wpm.Clinic.Api y Wpm.Management.Api: puntos de entrada de la aplicación
- Wpm.Clinic.Domain y Wpm.Management.Domain: lógica de negocio y modelos del dominio
- Wpm.SharedKernel: componentes compartidos y utilidades transversales
- Wpm.Clinic.Domain.Test y Wpm.Management.Domain.Test: pruebas unitarias del dominio

## Requisitos

- .NET 10 SDK
- Un editor como Visual Studio 2026 o Visual Studio Code

## Cómo ejecutar la solución

1. Clona el repositorio
2. Restaura las dependencias:
   ```bash
   dotnet restore
   ```
3. Compila la solución:
   ```bash
   dotnet build
   ```
4. Ejecuta los proyectos de API desde Visual Studio o mediante `dotnet run` sobre el proyecto deseado

## Notas

Este repositorio no pretende ser una aplicación empresarial completa, sino una muestra práctica de cómo organizar una solución siguiendo los principios de Domain-Driven Design en .NET.

## Objetivo educativo

El objetivo principal de esta prueba práctica es comprender mejor cómo modelar el dominio, aislar la lógica de negocio y construir una solución más mantenible, escalable y alineada con los principios de DDD.
