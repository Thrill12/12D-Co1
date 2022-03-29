## Pseudocode below shows sort algorithm represented using pseudo-code. The algorithm sorts the data in a list.

Procedure BubbleSort(L)
    N = LEN(L) - 2
    count1 = 0

    WHILE count1 < LEN(L) - 1
        FOR count2 < 0 To N
            IF L[count2] > L[count2 + 1] THEN
                temp = L[count2]
                L[count2] = L[count2 + 1]
                L[count2 + 1] = temp
            ENDIF
        ENDFOR
        count1 = count1
    ENDWHILE

ENDPROCEDURE

**1.1 Describe **two** changes that could be made to this bubble sort algorith mtaht would be likely to result in fewer comparisons being made when sorting the list L. The algorithm should still be a bbuble sort algorithm if your suggested changes were made.**

Add a flag variable set to true if a swap is made and reset to false at the start of each pass, and change the while loop so it doesn't keep repeatinhg if no swaps have been made.

After the inner loop, subtract 1 from N for upper limit, by subtracting count1 from N.

**1.2 "Sorting a list becomes an intractable problem when the size of the list is very large - it is a tractable problem when the size of the list is small."**

**Explain why this statement is wrong.**

Each sorting algorithm will have a worst case formula with which we can estimate a worst time, so it is tractable even when there is a lot of data.

**1.3 Explain what approach(es) a programmer might take if asked to "solve" an intractable problem.**

Use of heuristic - the algorithm will make a guess using previous knowledge, that provides a close-to-optimal solution, or relax some ofthe constraints on the solution - solve a simpler version of the problem. We could also reduce the size of the search space, essentially looking through a smaller range of potential answers.