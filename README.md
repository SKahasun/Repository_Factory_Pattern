# Repository Factory Pattern in C#

A demonstration of the **Repository Pattern** combined with the **Factory Pattern** in C#. This project showcases how to implement a generic repository with factory-based instantiation for managing entities in a clean, maintainable, and scalable way.

## 📋 Table of Contents

- [Overview](#overview)
- [Design Patterns Used](#design-patterns-used)
- [Project Structure](#project-structure)
- [Features](#features)
- [Getting Started](#getting-started)
- [Usage Examples](#usage-examples)
- [Code Architecture](#code-architecture)

## 🎯 Overview

This project demonstrates a clean architecture approach to data management using two fundamental design patterns:

- **Repository Pattern**: Abstracts data access logic and provides a collection-like interface for accessing domain objects
- **Factory Pattern**: Encapsulates the creation logic of repository instances

The implementation uses generic types to create a flexible, reusable data access layer that works with any entity type.

## 🏗️ Design Patterns Used

### Repository Pattern
The Repository Pattern mediates between the domain and data mapping layers, acting like an in-memory collection of domain objects. Benefits include:
- Centralized data access logic
- Improved testability
- Separation of concerns
- Consistent API for data operations

### Factory Pattern
The Factory Pattern provides an interface for creating repository instances without specifying their concrete classes. Benefits include:
- Loose coupling
- Centralized object creation
- Easier dependency injection
- Improved maintainability

## 📁 Project Structure

```
Repository-Factory-Pattern/
│
├── Models/
│   ├── BaseEntity.cs          # Abstract base class for all entities
│   ├── Department.cs          # Department entity
│   └── Student.cs             # Student entity
│
├── Repositories/
│   ├── IRepo.cs               # Generic repository interface
│   └── GenericRepo.cs         # Generic repository implementation
│
├── Factories/
│   ├── IRepoFactory.cs        # Factory interface
│   └── RepoFactory.cs         # Factory implementation
│
├── DITest/
│   └── TastClass.cs           # Test/demonstration class
│
└── Program.cs                 # Application entry point
```

## ✨ Features

- **Generic Repository Implementation**: Works with any entity that inherits from `BaseEntity`
- **CRUD Operations**: Full Create, Read, Update, Delete functionality
- **In-Memory Storage**: Uses `IList<T>` for data storage (easily replaceable with database context)
- **Type Safety**: Strongly-typed operations with compile-time checking
- **Factory-Based Creation**: Centralized repository instantiation
- **Dependency Injection Ready**: Designed with DI principles in mind

## 🚀 Getting Started

### Prerequisites

- .NET Framework 4.x or higher (or .NET Core/5+)
- Visual Studio 2019 or later (or any C# IDE)

### Installation

1. Clone the repository:
```bash
git clone https://github.com/SKahasun/Repository_Factory_Pattern
```

2. Open the solution in Visual Studio:
```bash
cd Repository_Factory_Pattern
```

3. Build the solution:
```bash
dotnet build
```

4. Run the application:
```bash
dotnet run
```

## 💡 Usage Examples

### Creating a Repository

```csharp
// Initialize the factory
IRepoFactory factory = new RepoFactory();

// Create a repository for Department
IRepo<Department> deptRepo = factory.CreateRepo<Department>();

// Create a repository for Student
IRepo<Student> studentRepo = factory.CreateRepo<Student>();
```

### CRUD Operations

```csharp
// CREATE - Add single entity
var dept = new Department { Id = 1, name = "Computer Science" };
deptRepo.Add(dept);

// CREATE - Add multiple entities
deptRepo.AddRange(new Department[] {
    new Department { Id = 2, name = "Mathematics" },
    new Department { Id = 3, name = "Physics" }
});

// READ - Get all entities
var allDepartments = deptRepo.GetAll();

// READ - Get single entity by ID
var department = deptRepo.Get(1);

// UPDATE - Modify existing entity
department.name = "Computer Engineering";
deptRepo.Update(department);

// DELETE - Remove entity by ID
deptRepo.Delete(3);
```

## 🏛️ Code Architecture

### Base Entity

All entities inherit from `BaseEntity`, which provides a common `Id` property:

```csharp
public abstract class BaseEntity
{
    public int Id { get; set; }
}
```

### Generic Repository Interface

```csharp
public interface IRepo<T> where T : BaseEntity
{
    List<T> GetAll();
    T Get(int id);
    void Add(T entity);
    void AddRange(IEnumerable<T> entities);
    void Update(T entity);
    void Delete(int id);
}
```

### Repository Factory

The factory encapsulates the creation of repository instances:

```csharp
public interface IRepoFactory
{
    IRepo<T> CreateRepo<T>() where T : BaseEntity;
}
```

## 🎓 Learning Outcomes

By studying this project, you will learn:

- How to implement the Repository Pattern in C#
- How to use the Factory Pattern for object creation
- Generic programming with constraints in C#
- Separation of concerns in application architecture
- Dependency injection principles
- CRUD operation implementation

## 🔄 Extending the Project

This project can be extended in several ways:

1. **Database Integration**: Replace in-memory storage with Entity Framework or Dapper
2. **Async Operations**: Convert all operations to async/await pattern
3. **Unit Testing**: Add comprehensive unit tests using xUnit or NUnit
4. **Specification Pattern**: Add query filtering capabilities
5. **Unit of Work Pattern**: Implement transaction management
6. **Logging**: Add logging functionality using ILogger
7. **Validation**: Implement entity validation before CRUD operations


## 👤 Author

**Sheikh Ahasunul Islam**
- GitHub: [@SKahasunul](https://github.com/SKahasun)

## 🙏 Acknowledgments

- Design Patterns: Elements of Reusable Object-Oriented Software (Gang of Four)
- Microsoft .NET Documentation
- Clean Architecture principles by Robert C. Martin

---

⭐ If you found this project helpful, please consider giving it a star!
