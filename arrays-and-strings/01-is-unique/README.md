# 01 - Is Unique

## Problem

Determine if a string has all unique characters.

Extra challenge:
- Solve the problem without using additional data structures.

---

## Goal

Check whether all characters in a string are unique.

---

## Solution 1 — Brute Force

### Approach

Compare each character with every following character in the string.

### Complexity

- Time: O(n²)
- Space: O(1)

### Advantages

- Does not require additional data structures.
- Simple and straightforward.

### Disadvantages

- Inefficient for large strings.

---

## Solution 2 — HashSet

### Approach

Store already seen characters in a HashSet.

If a character already exists in the set:
- the string does not contain unique characters.

### Complexity

- Time: O(n)
- Space: O(n)

### Advantages

- Much faster lookup.
- Cleaner and more scalable solution.

### Disadvantages

- Requires additional memory.

---

## Key Learnings

- Trade-offs between time and space complexity.
- Using HashSet for O(1) average lookup.
- Early return to avoid unnecessary processing.
- Difference between brute force and optimized approaches.

---

## Project Structure

```txt
csharp/
├── SolutionBruteForce.cs
└── SolutionHashSet.cs

java/
├── SolutionBruteForce.java
└── SolutionHashSet.java
```