---
description: "Quiz me on C# concepts to test my understanding"
agent: "tutor"
argument-hint: "Topic to quiz on (e.g., 'if/else', 'variables', 'types') or 'mixed' for variety"
---

Create an interactive C# quiz for the learner. Format:

1. **Ask 5 questions** on the given topic, mixing these types:
   - **Predict the output**: Show a code snippet, ask what it prints
   - **Spot the bug**: Show broken code, ask what's wrong
   - **Fill in the blank**: Show code with a missing piece, ask what goes there
   - **True or false**: Make a statement about C# behavior
   - **Which is better**: Show two approaches, ask which is preferred and why

2. **Rules**:
   - Use .NET 8 / C# 12 conventions in all code snippets
   - Keep snippets short (5-10 lines max)
   - Base questions on concepts from their existing exercises when possible
   - After each question, wait for the learner's answer before revealing the solution
   - When revealing answers, explain the **why** — not just the what

3. **After all questions**:
   - Summarize which areas they're strong in
   - Suggest one topic to review or practice more
