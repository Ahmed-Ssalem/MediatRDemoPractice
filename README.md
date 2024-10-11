# Mediator Pattern and CQRS Demo

This repository contains a demo project implementing the **Mediator Pattern** and **CQRS (Command Query Responsibility Segregation)** in .NET. It demonstrates how to use the Mediator to decouple business logic from controllers and services while separating read and write operations.

## Technologies Used
- **.NET 5**
- **MediatR** for implementing the Mediator pattern
- **CQRS** for separating commands (write) and queries (read)
- Blazor Server App
- **ASP.NET Core Web API** for creating REST services

## Key Concepts
- **Mediator Pattern:** A design pattern that facilitates communication between objects by encapsulating requests, responses, and notifications within a mediator object, reducing direct dependencies between components.
- **CQRS:** A pattern that separates read and write operations into different models, ensuring scalability, performance, and flexibility for handling different use cases.

## Features
- **Command Handlers** for creating and updating resources.
- **Query Handlers** for fetching resources.
- Integration with **MediatR** to handle the interaction between commands/queries and handlers.
- **Basic CRUD Operations** for demonstrating the CQRS pattern.
  
## Getting Started

### Prerequisites
- **.NET SDK 5** or later


### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/Ahmed-Ssalem/MediatRDemoPractice.git
