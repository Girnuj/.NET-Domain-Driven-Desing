# Domain-Driven Design in .NET

This repository contains a practical exercise on Domain-Driven Design (DDD) implemented in .NET 10, centered around the context of a veterinary clinic.

The idea of this project is to demonstrate, in a simple but structured way, how to apply DDD principles in a realistic solution by clearly separating responsibilities between the domain, infrastructure, and presentation layers. The use case is inspired by a management system for a veterinary clinic, where concepts such as patients, medical records, appointments, and care processes are modeled.

## Purpose

Before implementing anything, it is important to reflect on whether this practice is worthwhile for the real problem. Domain-Driven Design can bring many advantages, but it also involves some cost.

### Advantages

- It helps model the domain of a veterinary clinic more effectively, such as patients, pets, medical records, and appointments.
- It promotes a cleaner and more maintainable architecture, with business logic isolated from data access and the user interface.
- It improves communication between technical and business teams, since the language of the domain becomes more explicit.
- It makes it easier to scale the solution if the system grows in complexity.

### Disadvantages

- It can be excessive for small projects or systems with simple requirements.
- It requires time for analysis and design, which can increase the initial development cost.
- In some cases, implementation can become more complex if the domain is not clearly understood.

This project serves as a practical exercise to explore concepts such as:

- Aggregates and domain entities
- Value Objects
- Business rules encapsulated in the domain
- Separation between the domain and infrastructure layers
- Domain-oriented architecture in .NET applications

## Solution Structure

The solution is organized into several projects to keep responsibilities clearly separated:

- Wpm.Clinic.Api and Wpm.Management.Api: application entry points
- Wpm.Clinic.Domain and Wpm.Management.Domain: business logic and domain models
- Wpm.SharedKernel: shared components and cross-cutting utilities
- Wpm.Clinic.Domain.Test and Wpm.Management.Domain.Test: domain unit tests

## Requirements

- .NET 10 SDK
- An editor such as Visual Studio 2026 or Visual Studio Code

## How to run the solution

1. Clone the repository
2. Restore dependencies:
   ```bash
   dotnet restore
   ```
3. Build the solution:
   ```bash
   dotnet build
   ```
4. Run the API projects from Visual Studio or by using `dotnet run` on the desired project

## Notes

This repository is not intended to be a complete enterprise application, but rather a practical example of how to organize a solution following the principles of Domain-Driven Design in .NET.

## Educational goal

The main objective of this practical exercise is to better understand how to model the domain, isolate business logic, and build a more maintainable, scalable solution aligned with DDD principles.
