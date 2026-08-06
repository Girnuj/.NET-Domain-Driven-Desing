# Domain-Driven Design in .NET

This repository contains a practical exercise on Domain-Driven Design (DDD) implemented in .NET 10, centered around the context of a veterinary clinic.

The idea of this project is to demonstrate, in a simple but structured way, how to apply DDD principles in a realistic solution by clearly separating responsibilities between the domain, infrastructure, and presentation layers. The use case is inspired by a management system for a veterinary clinic, where concepts such as patients, medical records, appointments, and care processes are modeled.

But first, let's review some key concepts to better understand this DDD practice.

## What is DDD?

Domain-Driven Design, or DDD as it's also known from its acronym, is very simple to explain. In fact, it's so easy to explain that it might raise some eyebrows after hearing what I'm about to tell you. But don't worry. It's certainly a simple yet very powerful concept.
Domain-Driven Design is a set of practices and tools focused on understanding business needs to create software that truly delivers value and aligns with the business. This is achieved through mutual understanding between the people considered experts within the business and those who build the software. I told you, it's a simple concept, right? However, in the software industry, we often encounter an obsession with complicating things. For that reason, I must tell you that Domain-Driven Design is not a type or style of software architecture, nor a design or architectural pattern, much less a software development methodology. On the other hand, this concept is nothing new, as Domain-Driven Design was coined and popularized by Eric Evans in 2003 through his famous blue book, "Domain-Driven Design: Tackling Complexity in the Heart of Software." This last phrase could be translated as "addressing complexity at the heart of software," which is precisely the essence of this concept. As you can see, Domain-Driven Design is closely related to collaboration and understanding between people and has very little to do with specific software architectures or technologies.

## Domains and Their Modeling

A domain is the area of ​​knowledge, influence, or activity present in any organization and to which the software we build is directed. For example, the domain of a veterinary hospital is animal health. This is what I was referring to earlier when I described why building the right software is not an easy task. The most critical complexity of most software projects is understanding their domain. Perhaps you're thinking, "But that's obvious! That's why we first need to carry out an analysis process." Well, yes, but it's a bit more complex than that. So let me clarify this point. We now have the definition of a domain. The issue with a domain is that it is generally too large and complex to be fully understood as a single concept or unit. To understand a domain, we need one or more models that allow us to understand only those parts that are relevant to our purposes or requirements. We can define a model as a system of abstractions that describes selected aspects of a domain and can be used to solve problems related to that domain.

You're probably wondering, "A model? What's that?" Well, let me explain. In our daily lives, we find many models that abstract the thing they're based on. For example, if you want to know the geography of your country, you use a map that models that geographic space. You agree that the map isn't actually the country, but an abstract representation of it, right? Furthermore, that map only includes some relevant aspects and not every single thing related to the country. Here's another example. What happens when you go to a land or subway transportation system and want to know its different lines and stations to find out how to get to your destination? For that, you use a completely different map than the one I mentioned at the beginning. This other map only includes the aspects that are useful for its purpose. In other words, you probably won't find the names of rivers or mountains, but you will find the names of stations, their locations, and the names of adjacent streets and avenues. So, as you can see, a good model benefits from what we intentionally consider, but also from what we deliberately choose to ignore. Therefore, in Domain-Driven Design, it is extremely important to create one or more domain models that reflect the most relevant business concepts and processes for the software we are going to develop, omitting anything that is not useful.

## What are subdomains in Domain-Driven Design?

Domains are generally too large and complex to understand as a whole. Let's take the veterinary hospital as an example again and try to imagine all the things that happen in this business. Clients bring their pets in for scheduled or unscheduled appointments for a consultation with a veterinarian, where medication can be administered as needed. The business also sells items or accessories that clients can purchase on-site or online. Sales are recorded to keep the accounting up-to-date. The business can also receive payments at the clinic or online. Additionally, pets can be hospitalized, if necessary, and receive other medications or undergo other procedures such as X-rays or surgery. Finally, the business can send emails with news or discount coupons through marketing campaigns to its existing client base or potential clients. As you can see, there are a large number of processes and activities that can occur within this business, and it would be extremely complicated to try to understand them all at once. For this reason, we need to apply the famous phrase "divide and conquer" by identifying the subdomains that make up the main domain.
Subdomains, therefore, represent different areas of interest or functionality within the main domain. For example, based on the description I just gave you, there are some subdomains we can immediately identify, such as e-commerce, sales and collections, marketing, veterinary consultations, hospital management, customer administration, and several others. It's vitally important to mention that we don't design the subdomains, nor do we decide which ones exist. In other words, we don't choose which subdomains exist within a domain. What we do is discover them, since they are pre-existing.

## Purpose

Before implementing anything, it is important to reflect on whether this practice is worthwhile for the real problem. Domain-Driven Design can bring many advantages, but it also involves some cost.

### Advantages

- It helps model the domain of a veterinary clinic more effectively in this case, such as patients, pets, medical records, and appointments.
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

## What are Bounded Contexts?

Remember that we don't choose which subdomains exist within a domain. What we can do is choose how to define their boundaries. In other words, "Bounded Contexts" are deliberately designed. These bounded contexts are a semantic and contextual boundary that has its own vocabulary, that is, its own ubiquitous language. This means that within this boundary, its concepts have a certain meaning and behavior and only make sense within these limits. An analogy for this is a country, which has its own language and customs. The country would then be the "Bounded Context," the language is the ubiquitous language, and the customs are the functionality of the modeled concepts. It's important to note that "Bounded Contexts" and subdomains often have a one-to-one relationship, but this isn't always the case. There are times when a "Bounded Context" can include several subdomains, as long as their ubiquitous language is common, and vice versa. A subdomain can be referenced in multiple bounded contexts. Furthermore, once bounded contexts are explicitly designed for our software, they can serve as ownership and responsibility boundaries for teams. Ideally, each bounded context should be implemented and maintained by only one team. Of course, a team could implement and maintain different bounded contexts. Along the same lines, it's suggested that each bounded context have its own source code repository to strengthen the sense of ownership for a single team. And since we're talking about boundaries, we can use a bounded context as the physical boundary for its related code project. For example, if we're using the microservices architectural style, each bounded context would be implemented as a microservice. Keep in mind that this isn't a hard and fast rule, but it's a good starting point. Bounded contexts are definitely extremely important in domain-driven design, but there are times when teams don't know when to stop adding concepts to their bounded context domain models. With too many concepts, the ubiquitous language becomes confusing. Consequently, the resulting project is usually a big ball of mud, as it's known in English. This term is a metaphor describing a system with little or no structure, difficult to maintain, and with very tangled, spaghetti-like code. To avoid this terrible situation, always remember to properly define the boundaries of your bounded contexts and include only concepts that are useful for their purpose in the related domain model.

## Context Mapping

The Bounded Contexts we design will almost always need to interact and communicate with each other to achieve the desired functionality in the software we are building. We call this interaction "context mapping." If we return to the analogy that a Bounded Context is similar to a country, then the mapping between Bounded Contexts would be similar to the international relations that exist between nations. Sometimes, in these relationships, there is a dominant country and a weaker one. At other times, they collaborate closely, and at still other times, they simply choose to go their separate ways in every respect. Therefore, we could say that context mapping establishes the clear rules for the integration of Bounded Contexts, as well as the dynamics that must exist between the teams responsible for these contexts. Don't forget that in each Bounded Context, there is a ubiquitous language, and therefore, some kind of translation between these languages ​​must exist to prevent conflicts. As a result of mapping all the contexts, we will obtain a context map. This map is a visual representation of the "Bounded Contexts" and the relationships between them, helping teams understand exactly what to expect from each other. The method or technique for creating this map isn't really relevant. You can use paper and pencil or a diagramming application. What matters most here is the content, not the form. And, above all, the map should be easily accessible to any team member. Also, keep in mind that the map should reflect the current situation, not the desired future state. Of course, there will always be the opportunity to return and update the map as the software project progresses. There are three main categories of mapping in Domain-Driven Design. First, we have cooperative mappings. Here we find "Partnership" and "Shared Kernel" mappings. As the name suggests, this category of mappings seeks a win-win relationship between contexts. Second, we have client-provider mappings. In this category, we have the following: "Customer Supplier," "Conformist," "Anticorruption Layer," and "Open Host Service." As the name suggests, this type of mapping seeks to establish a client-supplier relationship, where the supplier provides a service to the client. To help clarify which of the "Bounded Contexts" is the supplier and which is the client on the map, we generally use the terms "upstream" and "downstream," respectively. These terms are analogous to a river flowing from the top (upstream) to the bottom (downstream). In other words, an upstream "Bounded Context" positively or negatively impacts a downstream one. Finally, we have the separate ways category. Here, we find a mapping called "Separate Ways," which aims to indicate that there is no integration between contexts for one reason or another. Don't forget: having a context map will be a great help in your Domain-Driven Design projects, just like having a map in hand when you are in a city you don't know.

## Solution Structure

The solution is organized into several projects to keep responsibilities clearly separated:

- Wpm.Clinic.Api and Wpm.Management.Api: application entry points
- Wpm.Clinic.Domain and Wpm.Management.Domain: business logic and domain models
- Wpm.SharedKernel: shared components and cross-cutting utilities
- Wpm.Clinic.Domain.Test and Wpm.Management.Domain.Test: domain unit tests

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
