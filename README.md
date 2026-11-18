# StudentCodeFirst

A basic C# Console Application using Entity Framework 6 Code-First.

## What is Code-First?

Code-First is an Entity Framework approach where the developer creates C# model classes first. Entity Framework uses those classes and the DbContext configuration to create the database schema.

## Project files

- `Student.cs` - Student entity/model class.
- `StudentContext.cs` - Database context derived from `DbContext`, with a `DbSet<Student>`.
- `Program.cs` - Adds one student, saves the change, and reads students back.
- `App.config` - LocalDB connection string and Entity Framework provider configuration.

## Requirements

- Visual Studio with .NET Framework 4.7.2 targeting pack
- SQL Server LocalDB
- Entity Framework 6.4.4 (restored from NuGet)

## Run

1. Open `StudentCodeFirst.csproj` in Visual Studio.
2. Restore NuGet packages.
3. Build the project.
4. Run the console application.

Entity Framework Code-First creates `StudentCodeFirstDB` in LocalDB when the context first accesses the database. The program inserts a sample student named John Smith.

Note: Running the program again inserts another sample row. This is a simple demonstration of adding a student.

## Research references

- Microsoft Learn, **Code First to a New Database (EF6)**:
  https://learn.microsoft.com/en-us/ef/ef6/modeling/code-first/workflows/new-database
- Microsoft Learn, **Working with DbContext (EF6)**:
  https://learn.microsoft.com/en-us/ef/ef6/fundamentals/working-with-dbcontext
- Entity Framework Tutorial, **What is Code First?**:
  https://www.entityframeworktutorial.net/code-first/what-is-code-first.aspx

The EF6 workflow defines model classes first, creates a context derived from `DbContext`, exposes model sets through `DbSet<TEntity>`, and uses the context to save and query records.
