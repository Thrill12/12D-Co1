# Merge Sort vs Bubble Sort

**Two other sorting algorithms the programer could have used are a merge sort and bubble sort.**

**The worst case scenario for Merge is O(n log n) and for Bubble is O(n ^ 2).**

**Compare the use of a merge sort and a bubblesort on this array, evaluating the performance of each sort, making reference to the worse case Big O notation.**

### Andrei's Answer:

The largest difference in the two is their memory usage and their time complexity. 

Referring to the time complexity, merge sort has a linear Big O notation, which would rise a lot slower than the bubble sort, which has an exponential increase in Big O. For example, with 10 items the merge sort worst case scenario would get to 1 second, however the bubble could get to 100 seconds as 10^2 is 100. This is a worst case scenario, but by being so far out from the merge sort, bubble is clearly inferior in longer lists. Use a merge sort for longer lists where speed is key, but be mindful of memory usage.

Merge sort uses more memory because it has to split up the array into many sublists in order to be ordered, and these sublists can also be split as well. This causes the memory usage of the merge sort to skyrocket, whereas the bubble sort will remain constant because it is not creating as many new variables as the merge sort and keeps to the same original list - the most the memory would increase with the bubble sort would be creating a single, temporary variable which wouldn't affect the total memory usage as much as the inefficiency of it in a long list.

Merge sort also has a consistent linear time, which means that we can easily predict and manage the worst case scenario. Due to bubble sort being exponentially increasing complexity wise, the times will appear to be erratic and hard to predict, and in a real world scenario this would cause strain on other systems depending on the query.
