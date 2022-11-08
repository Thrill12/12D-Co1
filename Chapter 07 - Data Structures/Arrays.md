## Arrays

A list or table of data that has a variable name that identifies the list or table. Each item is caled an element.

Each array can have many dimensions but most are 1 or 2 dimensional. This 2D array can be visualized as a two-dimensional table.

In some programming languages, arrays have to be defined with their size at the start, meaning their size cannot be modified after creation.

In a two dimensional array, the axis are not labeled so it is up to the programmer to remember which axis represents which data.
An example could be storing the results of a classes' results in exams, where we store the user identifier as the first number then the numbers after
that following.

Array allows you to share multiple items of the same data types under a common name. eg.

    array students(5)
    students[0] = 5
    students[1] = 4
    students[2] = 3
    students[3] = 2
    students[4] = 1
    print(students[3])

    array students[5,3]
    print(students[3,33])

- 2D array as table
- 3D array as cube

Arrays are static. They cannot change in size once they have been declared

## Records

A structure is used to group together a collection of related fields under the same name.
A record is allowed to contain multiple data types

First have to define the structure, then we can declare new variables of our datatypes then assign to them.

    Structure TStudent
        Dim firstName As String
        Dim surname As String
        Dim depositPaid As Double
        Dim datePaid As Date
    End Structure

    Dim student1, student2 As TStudent

    student1.firstName = "Jeff"
    student2.firstName = "Craig"
    student2.surname = "Sargent"

Records are often used in conjunction with arrays.

    Dim students(500) As TStudent

    Now we can store different variables with different data types within the TStudent.

    students(5).firstName = "Jack"

## Lists and Tuples

Tuple - Immutable, can't be changed once created
List  - Mutable, can be edited after creation

    animals = ['cat', 'dog']
    print(animals)
    cat, dog
    animals.append['bat']
    ^^ Lists

    point = (3,7)
    print(point)
    3,7

    point[1] = 4
    Traceback (most recent call last):
    File "", line 1, in 
    TypeError: 'Tuple' object does not support item assignment

