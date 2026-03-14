---
description: "Use when creating, editing, or reviewing C# exercise files. Covers exercise structure, naming, teaching comments, and observable output patterns for .NET 8 learning exercises."
applyTo: "**/*.cs"
---

# C# Exercise File Standards

## Structure

Every exercise file follows this pattern:

```csharp
class ExerciseName
{
    public static void Run()
    {
        // Exercise logic here
        Console.WriteLine("Observable output");
    }
}
```

- One class per file, named to match the filename (e.g., `LoopExercise.cs` → `class LoopExercise`)
- Always include a `public static void Run()` entry point
- No namespace required — the project uses implicit global namespace
- Always print results with `Console.WriteLine` so the learner sees output

## Teaching Comments

- Add brief comments explaining **new concepts** the first time they appear
- Use `// Why:` prefix for conceptual explanations
- Use `// Note:` prefix for gotchas or important details
- Don't over-comment obvious code — let the code speak when it's simple

## When Introducing New Concepts

- Show the simplest working version first
- Add a `// Try this:` comment suggesting a modification the learner can experiment with
- If a concept builds on a previous exercise, reference it: `// This builds on MathExercise.cs`

## Program.cs Integration

When creating a new exercise, update `Program.cs`:
1. Comment out the previous exercise call
2. Add the new `ExerciseName.Run();` call

## Common Patterns for Exercises

- Use `Random` for dynamic output that changes each run
- Use `Console.ReadLine()` only when the exercise is about user input
- Prefer hardcoded test values over user input for most exercises
- Include edge cases in comments as challenges: `// Challenge: What happens if the value is negative?`
