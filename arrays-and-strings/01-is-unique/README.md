# 01 - Is Unique

## Problem

Determine if a string has all unique characters.

Extra challenge:
- Solve the problem without using additional data structures.

---

# Goal

Check whether every character in a string appears only once.

---

# Key Insight

The core of this problem is detecting duplicate characters efficiently.

A brute force solution compares every character against the others, while optimized approaches use additional data structures to reduce lookup time.

This problem is also a great introduction to the trade-off between:
- time complexity
- space complexity

---

# Approaches

## Solution 1 — Brute Force

### Idea

Compare each character with every following character in the string.

If two equal characters are found:
- the string is not unique.

### Complexity

- Time: O(n²)
- Space: O(1)

### Advantages

- Does not require additional memory.
- Simple and easy to understand.
- Satisfies the book's extra challenge.

### Disadvantages

- Inefficient for large inputs.
- Performs many repeated comparisons.

---

## Solution 2 — HashSet

### Idea

Store already seen characters in a HashSet.

If a character already exists in the set:
- the string contains duplicates.

### Complexity

- Time: O(n)
- Space: O(n)

### Advantages

- Much faster lookup.
- Cleaner and more scalable solution.
- Avoids unnecessary comparisons.

### Disadvantages

- Requires additional memory.
- Does not satisfy the "no additional data structures" constraint.

---

# Trade-offs

| Approach | Time | Space | Notes |
|---|---|---|---|
| Brute Force | O(n²) | O(1) | No extra memory required |
| HashSet | O(n) | O(n) | Faster lookup using additional memory |

---

# Key Learnings

- Trade-offs between time and space complexity.
- Difference between brute force and optimized solutions.
- Using HashSet for constant-time average lookup.
- Importance of early return to avoid unnecessary processing.
- How additional data structures can improve performance.

---

# Implementations

## C#

```txt
csharp/
├── SolutionBruteForce.cs
└── SolutionHashSet.cs
```

## Java

```txt
java/
├── SolutionBruteForce.java
└── SolutionHashSet.java
```

---

# Related Concepts

- Hash Tables
- Nested Loops
- Complexity Analysis
- Early Return
- Space-Time Trade-off