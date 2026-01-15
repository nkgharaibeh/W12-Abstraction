# W12 – Abstraction (Part 1) | Abstract Classes & Methods (C#)

This repository contains the **first part of Week 12: Abstraction**, focusing on **Abstract Classes and Abstract Methods** in C#.

It follows the OOP sequence we built in previous labs:
- **Lab 5: Inheritance**
- **Lab 6: Polymorphism**
- **Week 12 (this repo): Abstraction (Abstract) → next: Interface**

---

## Why Abstraction?
Abstraction means:
> Hide the internal implementation and expose only the essential behavior.

Real-life example (from slides):
- **ATM machine**: users know *how to operate it*, not *how it works internally*.

In C#, abstraction can be achieved using:
- **Abstract Classes**
- **Interfaces** (next part)

---

## Virtual vs Abstract (Key Slide Notes)
- `virtual` method:
  - Has a default implementation
  - Overriding is optional
  - Gives flexibility

- `abstract` method:
  - Has NO body (no implementation)
  - Must be implemented by the derived class
  - Exists only inside an abstract class
  - Abstract methods are **implicitly virtual** (so we do not use `virtual` with them)

---

## Examples (as in the slides: Example 01 → Example 05)

Each example below includes:
- The main concept
- The expected output behavior
- A direct link to the code file inside this repository

> Repository link: https://github.com/nkgharaibeh/W12-Abstraction

### ✅ Example 01 – Abstract Method (Basic Concept)
**Idea:** Abstract method forces the derived class to provide implementation (`override` is mandatory).

➡️ Code: [Example 01 – Abstract Method (Basic Concept).cs](https://github.com/nkgharaibeh/W12-Abstraction/blob/main/Example%2001%20%E2%80%93%20Abstract%20Method%20%28Basic%20Concept%29.cs)

---

### ✅ Example 02 – Abstract Class with Get/Set Property
**Idea:** Abstract property enforces a contract; child class decides how to implement `get` and `set`.

➡️ Code: [Example 02 – Abstract Class with Get_Set Property.cs](https://github.com/nkgharaibeh/W12-Abstraction/blob/main/Example%2002%20%E2%80%93%20Abstract%20Class%20with%20Get_Set%20Property.cs)

---

### ✅ Example 03 – Constructor in Abstract Class
**Idea:** Abstract classes can have constructors. Base constructor runs before derived constructor.

➡️ Code: [Example 03 – Constructor in Abstract Class.cs](https://github.com/nkgharaibeh/W12-Abstraction/blob/main/Example%2003%20%E2%80%93%20Constructor%20in%20Abstract%20Class.cs)

---

### ✅ Example 04 – One Abstract Method, Multiple Implementations
**Idea:** Same abstract method, different implementations in multiple derived classes.
This reinforces abstraction + polymorphism together.

➡️ Code: [Example 04 – Abstract Method with Multiple Classes.cs](https://github.com/nkgharaibeh/W12-Abstraction/blob/main/Example%2004%20%E2%80%93%20Abstract%20Method%20with%20Multiple%20Classes.cs)

---

### ✅ Example 05 – Shape Example (Classic Abstract Example)
**Idea:** Base reference can point to derived object.
Behavior is decided at runtime (polymorphism).

➡️ Code: [Example 05 – Shape Example (Classic Abstract Example).cs](https://github.com/nkgharaibeh/W12-Abstraction/blob/main/Example%2005%20%E2%80%93%20Shape%20Example%20%28Classic%20Abstract%20Example%29.cs)

---

## Advantages of Abstraction (From Slides)
- Achieves better **security**
- Reduces **complexity**
- Avoids **code duplication**
- Increases **reusability**
- Shows only important details and hides unnecessary implementation details

---

## What’s Next? (Part 2 – Interfaces)
In the next step, we will move to **Interfaces**, which:
- Provide **100% abstraction**
- Support **multiple inheritance of behavior** (a key limitation in C# classes)
- Are essential for real software engineering practices:
  - SOLID principles (especially DIP & ISP)
  - Dependency Injection
  - Clean Architecture patterns

✅ After understanding Abstract Classes, Interfaces will feel natural:
- Abstract Class = partial contract + shared base implementation
- Interface = pure contract (what to do, not how)

---

## How to Run
Open any `.cs` file in Visual Studio / Rider / VS Code, run it, and compare output with the slide expectations.

---

**Author / Instructor Repo**
nkgharaibeh – W12-Abstraction
