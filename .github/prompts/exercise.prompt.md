---
description: "Generate a new C# practice exercise with instructions and starter code"
agent: "tutor"
argument-hint: "Topic for the exercise (e.g., 'loops', 'arrays', 'methods with return types')"
---

Create a new C# practice exercise for the given topic. Follow the workspace conventions:

1. **Create the exercise file** named `{Topic}Exercise.cs` with:
   - A class matching the filename
   - A `public static void Run()` method
   - Clear comment block at the top with the exercise rules/requirements
   - `Console.WriteLine` output so results are visible
   - Teaching comments for new concepts using `// Why:` and `// Note:` prefixes
   - A `// Challenge:` comment with a bonus task

2. **Update Program.cs**:
   - Comment out the current exercise call
   - Add the new `{ExerciseName}.Run();` call

3. **Provide exercise instructions** as a message:
   - What the exercise practices
   - The specific requirements (numbered rules)
   - Expected sample output
   - Hints if the topic is new

4. **Build and verify** by running `dotnet build` to ensure it compiles

Start with a partially complete version — leave blanks or TODO comments for the learner to fill in, rather than providing the complete solution.
