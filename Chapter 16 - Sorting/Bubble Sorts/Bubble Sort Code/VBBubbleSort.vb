Dim sortArray(5) As Integer
sortArray(0) = 100
sortArray(1) = 20
sortArray(2) = 30
sortArray(3) = 70
sortArray(4) = 10
sortArray(5) = 40
Dim holdInt As Integer
'Ubound gives you the total length of the array
For i = 0 To UBound(sortArray)                      'Loops from the start until the end of the array
    For x = UBound(sortArray) To i + 1 Step -1      'Loops from the end of the array to one after i, going backwards 1
        If sortArray(x) < sortArray(i) Then         'Compares the two, if i is larger than x it swaps them
            holdInt = sortArray(x)
            sortArray(x) = sortArray(i)
            sortArray(i) = holdInt
        End If
    Next x
Next i
For i = 0 To UBound(sortArray)
    Console.WriteLine(sortArray(i))
Next