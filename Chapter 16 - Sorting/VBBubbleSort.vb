Dim sortArray(9) As Integer
sortArray(0) = 100
sortArray(1) = 20
sortArray(2) = 30
sortArray(3) = 70
sortArray(4) = 10
sortArray(5) = 40
sortArray(6) = 90
sortArray(7) = 80
sortArray(8) = 60
sortArray(9) = 50
Dim holdInt As Integer
For i = 0 To UBound(sortArray)                                  'Ubound gives you the total length of the array
    For x = UBound(sortArray) To i + 1 Step -1
        If sortArray(x) < sortArray(i) Then
            holdInt = sortArray(x)
            sortArray(x) = sortArray(i)
            sortArray(i) = holdInt
        End If
    Next x
Next i
For i = 0 To UBound(sortArray)
    Console.WriteLine(sortArray(i))
Next