---
description: "Show me how to refactor or improve my C# code step by step"
agent: "tutor"
argument-hint: "Which file or what kind of improvement (e.g., 'extract methods', 'simplify logic')"
---

Guide the learner through refactoring their C# code. This is a teaching exercise, not just a code transformation.

## Process

1. **Read the current code** and understand what it does
2. **Run it first** to confirm it works before any changes
3. **Identify 1-2 improvements** appropriate to their level — pick from:
   - Extracting repeated code into a method
   - Simplifying conditional logic
   - Improving variable naming
   - Removing redundant code
   - Using a more appropriate C# feature (e.g., `switch` instead of `if/else` chain)

4. **For each improvement**, teach the refactoring:
   - Explain **what** you're changing and **why** it's better
   - Show the before and after
   - Name the refactoring pattern (e.g., "This is called *Extract Method*")
   - Explain when to apply this pattern in general

5. **Apply the changes** to the file
6. **Run `dotnet build` and `dotnet run`** to verify the refactored code still works correctly
7. **Summarize** what was improved and what the learner should watch for in future code
