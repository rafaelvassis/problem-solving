# 02 - Check Permutation

## Problem

Given two strings, determine whether one is a permutation of the other.

A permutation means both strings contain:
- the same characters
- with the same frequencies
- possibly in a different order

---

## Goal

Compare two strings and verify whether they are permutations of each other.

All implementations in this repository perform:
- case-insensitive comparison
- character normalization using lowercase conversion

---

## Solution 1 — Brute Force

### Approach

For each character in the first string:
- count how many times it appears in the first string
- count how many times it appears in the second string
- compare both frequencies

If any frequency differs:
- the strings are not permutations.

### Complexity

- Time: O(n²)
- Space: O(1)

### Advantages

- Simple and straightforward.
- Does not require additional data structures.

### Disadvantages

- Recalculates frequencies repeatedly.
- Inefficient for large inputs.

---

## Solution 2 — Improved Brute Force

### Approach

Improves the brute-force strategy by tracking already processed characters.

This avoids recalculating frequencies for repeated characters.

### Complexity

- Time: O(n²)
- Space: O(n)

### Advantages

- Reduces unnecessary repeated work.
- Demonstrates incremental optimization thinking.

### Disadvantages

- Overall asymptotic complexity remains O(n²).
- Additional memory is required.

---

## Solution 3 — Frequency Array

### Approach

Uses a fixed-size frequency array to count character occurrences.

Steps:
1. Increment frequencies using the first string.
2. Decrement frequencies using the second string.
3. If any frequency becomes negative:
   - the strings are not permutations.

This implementation assumes an extended ASCII / byte-range character set.

### Complexity

- Time: O(n)
- Space: O(1)

### Advantages

- Very fast.
- Constant-time access.
- Memory efficient for fixed-size character sets.

### Disadvantages

- Depends on a limited character set.
- Less flexible for full Unicode support.

---

## Solution 4 — HashMap

### Approach

Uses a HashMap to dynamically store character frequencies.

Unlike the frequency-array solution:
- this approach does not depend on a fixed-size character set.

### Complexity

- Time: O(n)
- Space: O(n)

### Advantages

- Flexible and scalable.
- Supports dynamic character sets.
- Cleaner for generic frequency counting problems.

### Disadvantages

- Uses additional memory.
- Slightly more overhead compared to array indexing.

---

## Solution 5 — Sorting

### Approach

Sort both strings and compare their sorted representations.

If two strings are permutations:
- their sorted versions must be identical.

### Complexity

- Time: O(n log n)
- Space: O(n)

### Advantages

- Easy to understand.
- Elegant and concise.

### Disadvantages

- Sorting introduces additional computational cost.
- Slower than frequency-counting approaches.

---

## Solution Comparison

| Approach | Time | Space | Notes |
|---|---|---|---|
| Brute Force | O(n²) | O(1) | Simplest implementation |
| Improved Brute Force | O(n²) | O(n) | Avoids redundant recalculations |
| Frequency Array | O(n) | O(1) | Fastest with fixed character set |
| HashMap | O(n) | O(n) | Flexible and scalable |
| Sorting | O(n log n) | O(n) | Clean and intuitive approach |

---

## Key Learnings

- Character frequency counting techniques.
- Trade-offs between time and space complexity.
- Difference between fixed-size arrays and dynamic hash tables.
- Early return optimization.
- Comparing algorithmic approaches for the same problem.
- String manipulation and sorting techniques.
- Differences between Java and C# string handling.

---

## Project Structure

```txt
csharp/
├── SolutionBruteForce.cs
├── SolutionImprovedBruteForce.cs
├── SolutionFrequencyArray.cs
├── SolutionDictionary.cs
└── SolutionSorting.cs

java/
├── SolutionBruteForce.java
├── SolutionImprovedBruteForce.java
├── SolutionFrequencyArray.java
├── SolutionHashMap.java
└── SolutionSorting.java