<h1> Removing Duplicates In Arrays </h1>

<h2>Summary of work</h2>

<p># Remove Duplicates from Sorted Array (C#)

This project demonstrates a C# solution to the classic problem of removing duplicates from a sorted array **in-place**, without using extra memory for another array.

---

## Problem Description

Given a sorted integer array `nums`, remove the duplicates **in-place** such that each element appears only once and return the new length `k`.

- Do not allocate extra space for another array.
- Modify the input array in-place.
- The first `k` elements should contain the unique values.

---

## Approach

This solution uses a **two-pointer technique**:

- `i` → scans through the array
- `k` → tracks the position of the next unique element

### Logic:
- Always keep the first element
- Compare each element with the previous one
- If it's different, place it at index `k` and increment `k`

</p>