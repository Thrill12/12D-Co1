# Functional programming, yay

Domain - set of data of the same type which are the inputs of a function
Codomain - the set of values from which the outputs of a function must be drawn

### Questions

1. Describe the basic properties of a function.
1. A function maps an input set to an output set, a value being produced for each function call.
2. Define the functional programming paradigm
2. The functional programming paradigm each line of code is made up of calls to a functon, which in turn may be made up of other functions, or result in a value.
3. What are the main reasons for using funtional languages compared to procedural languages?
3. Functional languages' ability to parallelize pure functions is the main reason why you would use it. The code is easier for data analysis and tasks are easier to test and maintain with a functional programming paradigm. It is suitable for analyzing extensive data sets and machine learning, because for each data input there can only be one output.
4. What is a first-class object? Give two examples
4. A first class object is any object that can be used as an argument or result of a function call. Some examples are 2,1,3,4 in the set [1,2,3,4,5]
5. Show the full and partial application of the equation
- f(a,b,c) = a + b - c
- f(1,2,3) = 1 + 2 - 3 -> 0
- f(1,2,3): f1(2,3) -> f2(3) -> 0
6. Use function composition to combine the equation f(x) = x^3 with g(x) = x 3