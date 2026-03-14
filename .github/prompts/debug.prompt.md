---
description: "Help debug a C# error or unexpected behavior with a teaching approach"
agent: "tutor"
argument-hint: "Describe the error or unexpected behavior you're seeing"
---

Help the learner debug their C# code. Follow this teaching approach:

1. **Read the code** in the current or specified file
2. **Build the project** with `dotnet build` to see compiler errors
3. **If it compiles**, run with `dotnet run` to observe runtime behavior
4. **Identify the issue** but don't fix it immediately

Instead of directly fixing:
1. **Explain what the error message means** in plain language
2. **Point to the relevant line(s)** and explain what the code is actually doing vs. what was intended
3. **Ask a guiding question** to help them find the fix themselves
4. **If they need more help**, show the fix with a clear explanation of *why* it works
5. **Teach the pattern** — explain how to recognize and avoid this type of bug in the future

Common beginner issues to watch for:
- Off-by-one errors in conditions
- Wrong operator (`=` vs `==`, `&&` vs `||`)
- Variable scope issues
- Integer division truncation
- Missing `break` in switch statements
- String comparison gotchas
