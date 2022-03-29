# Merge Sort

## A divide and conquer algorithm

O(n log n)

### Step-By-Step:

- Splits the list in half

- Keep splitting lists until all sublists contain one item

- Merge pairs of sublists so they are double

- At each merge, the items are sorted

- Continue until all are merged and sorted

## Advantages:

- More efficient and quicker than bubble and insertion sort for large lists.

- Consistent running time regardless of how ordered the times are in the original list (O(n log n) time)

## Disadvantages:

- Slow for small lists

- Even if list is already sorted, it will split and merge every item

- Uses more memory than other sorting agorithms due to creating sublists