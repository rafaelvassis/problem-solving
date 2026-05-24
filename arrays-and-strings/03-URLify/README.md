# 03 - URLify

## Problem

Replace all spaces in a string with `%20`.

Assume that:
- the string has sufficient extra space at the end to hold the additional characters;
- you are given the "true" length of the string.

Example:

```txt
Input:  "Mr John Smith    "
True Length: 13

Output: "Mr%20John%20Smith"
```

---

## Goal

Perform the transformation in-place without allocating another array for the final result.

---

## Solution 1 — In-Place Reverse Traversal

### Approach

This solution traverses the character array backwards using two pointers:

- one pointer reads characters from the end of the true content;
- another pointer writes characters from the end of the array.

When a space is found:
- it is replaced with `%20`.

By working backwards, the algorithm avoids overwriting characters that still need to be processed.

---

### Why Reverse Traversal?

A forward traversal would require repeatedly shifting characters to the right, causing unnecessary operations.

Reverse traversal allows:
- direct writing into the available buffer space;
- in-place modification;
- linear time complexity.

---

### Complexity

- Time: O(n)
- Space: O(1)

---

### Advantages

- Efficient and scalable.
- True in-place implementation.
- Avoids repeated character shifting.
- Demonstrates pointer/index manipulation skills.

---

### Disadvantages

- Slightly harder to reason about initially.
- Requires careful index management.

---

## Key Learnings

- Difference between mutable arrays and immutable strings.
- In-place array manipulation.
- Reverse traversal techniques.
- Two-pointer strategy.
- Trade-offs between simplicity and efficiency.
- Avoiding unnecessary data movement.

---

## Project Structure

```txt
csharp/
└── SolutionInPlace.cs

java/
└── SolutionInPlace.java
```

---

## Notes

In C#:
- `string` is immutable;
- therefore, the algorithm operates on a `char[]`.

In Java:
- the problem is also solved using a character array to allow in-place modification.