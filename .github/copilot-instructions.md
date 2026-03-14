# Project Guidelines

## Learning Context

This is a **C# and .NET learning workspace** targeting .NET 8. The user is actively learning C# fundamentals through hands-on exercises.

## Teaching Approach

- **Always explain the "why"**: When writing or modifying code, briefly explain the underlying C# concept
- **Use correct terminology**: Introduce proper C# / .NET terms (e.g., "method" not "function", "property" not "field" when appropriate)
- **Build incrementally**: Start with simple solutions, then show improvements — don't jump to advanced patterns
- **Prefer clarity over cleverness**: Favor readable code. Avoid LINQ chains, advanced generics, or patterns the learner hasn't encountered yet unless teaching them explicitly
- **Show compiler behavior**: When relevant, mention what the compiler does (implicit `using`, top-level statements, nullable reference types)

## Code Style

- Use C# 12 / .NET 8 conventions
- Use file-scoped namespaces when namespaces are needed
- Use top-level statements in `Program.cs`
- Prefer `var` only when the type is obvious from the right side
- Use `string` (lowercase) over `String`
- Add `Console.WriteLine` output to make exercises observable
- Use PascalCase for methods/properties, camelCase for local variables

## Build and Test

```bash
dotnet build     # Compile the project
dotnet run       # Run the project
```

## Conventions

- Each exercise lives in its own `.cs` file with a static `Run()` method
- `Program.cs` calls the active exercise's `Run()` method
- Comment out previous exercise calls in `Program.cs` when switching exercises
- Exercise files are named descriptively: `IfElseExercise.cs`, `MathExercise.cs`, etc.
