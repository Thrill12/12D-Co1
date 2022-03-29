PROCEDURE merge_sort(items)
   
    // Base case for recursion:
    // The recursion will stop when the list has been divided into single items
    IF LEN(items) < 2 THEN 
	RETURN
    ELSE
        midpoint = (LEN(items) - 1) DIV 2  // Calculate midpoint
        left_half = items[0:midpoint]  // Create left half list
        right_half = items[midpoint+1:LEN(items)-1]  // Create right half list

        merge_sort(left_half)  // Recursive call on left half
        merge_sort(right_half)  // Recursive call on right half
        
        merge(items, left_half, right_half)  // Call procedure to merge both halves
    ENDIF 
ENDPROCEDURE 