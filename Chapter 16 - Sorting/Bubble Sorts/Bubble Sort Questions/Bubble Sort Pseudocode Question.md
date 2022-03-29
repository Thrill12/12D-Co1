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

# 1.1 Describe **two** changes that could be made to this bubble sort algorith mtaht would be likely to result in fewer comparisons being made when sorting the list L. The algorithm should still be a bbuble sort algorithm if your suggested changes were made.

Add a flag variable set to true if a swap is made and reset to false at the start of each pass, and change the while loop so it doesn't keep repeatinhg if no swaps have been made.

After the inner loop, subtract 1 from N for upper limit, by subtracting count1 from N.