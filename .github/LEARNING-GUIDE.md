# Learning C# with Copilot — Your Personal Toolkit

This workspace is set up with custom prompts and agents to help you learn C# step by step. Here's how to use everything.

---

## Quick Start

In any Copilot Chat window, type `/` to see all available commands. Pick one and add your topic after it.

---

## Prompts (slash commands)

### `/explain` — Learn a new concept

Use this when you encounter something new or want to understand how a C# feature works.

**How to use:**
1. Open Copilot Chat
2. Type `/explain` followed by the concept
3. Read the explanation, try the example, then experiment

**Examples:**
- `/explain switch statements`
- `/explain what is a method`
- `/explain difference between == and =`
- `/explain string interpolation`

**Best for:** Before starting a new exercise topic.

---

### `/exercise` — Practice with a new exercise

Use this when you're ready to practice a concept hands-on. It creates a new exercise file with starter code and TODOs for you to complete.

**How to use:**
1. Type `/exercise` followed by the topic
2. Read the instructions it gives you
3. Fill in the TODO sections in the generated `.cs` file
4. Run with `dotnet run` in the terminal to test

**Examples:**
- `/exercise switch statements`
- `/exercise for loops`
- `/exercise methods with return types`
- `/exercise arrays`

**Best for:** After you've understood a concept with `/explain`.

---

### `/review` — Get feedback on your code

Use this when you've finished an exercise and want to know how you did.

**How to use:**
1. Open the `.cs` file you want reviewed
2. Type `/review`
3. Read the feedback — it starts with what you did well

**Examples:**
- `/review` (reviews the file you have open)
- `/review IfElseExercise`

**Best for:** After completing an exercise, before moving on.

---

### `/debug` — Get help with errors

Use this when your code doesn't compile or behaves unexpectedly. Instead of just fixing it for you, it teaches you to understand the error.

**How to use:**
1. Open the file with the problem
2. Type `/debug` and describe what's happening
3. Answer its guiding questions to find the fix yourself

**Examples:**
- `/debug I get a red squiggly on line 12`
- `/debug the output is wrong, I expected 10 but got 0`
- `/debug CS0029 Cannot implicitly convert type`

**Best for:** When you're stuck and want to learn, not just get a fix.

---

### `/quiz` — Test your knowledge

Use this to check your understanding of a topic. It asks 5 interactive questions and waits for your answers.

**How to use:**
1. Type `/quiz` followed by the topic
2. Answer each question one at a time
3. Read the explanations after each answer
4. Review the summary at the end

**Examples:**
- `/quiz if/else`
- `/quiz variables and types`
- `/quiz mixed` (random topics based on what you've done)

**Best for:** Before moving to the next topic — make sure you've got the current one solid.

---

### `/refactor` — Improve your code step by step

Use this when your code works but you want to learn how to make it cleaner. It walks you through each improvement and names the pattern.

**How to use:**
1. Open the file you want to improve
2. Type `/refactor` and optionally describe what kind of improvement
3. Follow along as it explains each change

**Examples:**
- `/refactor IfElseExercise`
- `/refactor simplify the logic`
- `/refactor extract methods`

**Best for:** After your code works and has been reviewed.

---

## Agents

You can also switch to a specialized agent in the chat agent picker (the dropdown at the top of the chat).

### `@tutor`
Your teaching companion. Explains concepts, creates exercises, helps you debug with guiding questions. Most prompts (`/explain`, `/exercise`, `/quiz`, `/debug`, `/refactor`) use this agent automatically.

### `@reviewer`
A read-only code reviewer. Analyzes your code, runs it, and gives structured feedback. The `/review` prompt uses this agent automatically.

---

## Suggested Learning Workflow

Here's a recommended flow for each new topic:

```
/explain <topic>          ← Understand the concept
    ↓
/exercise <topic>         ← Practice it hands-on
    ↓
  dotnet run              ← Run your code in the terminal
    ↓
/debug <problem>          ← If something's wrong, learn to fix it
    ↓
/review                   ← Get feedback on your solution
    ↓
/refactor                 ← Learn to improve your working code
    ↓
/quiz <topic>             ← Test your understanding
    ↓
  Move to next topic!
```

## Your Learning Progression

Based on your exercises so far, here's where you are and what's next:

- [x] Variables, types, Console.WriteLine
- [x] Math operations, type casting (`MathExercise.cs`)
- [x] If/else, conditional logic (`IfElseExercise.cs`)
- [ ] Switch statements
- [ ] Loops (for, while, foreach)
- [ ] Methods (parameters, return types)
- [ ] Arrays and collections
- [ ] Classes and objects
- [ ] Properties, constructors
- [ ] Inheritance, interfaces

**Next up:** Try `/explain switch statements` to start the next topic!

---

## Terminal Commands

Two commands you'll use constantly:

```bash
dotnet build     # Compile — checks for errors without running
dotnet run       # Compile and run — see your output
```
