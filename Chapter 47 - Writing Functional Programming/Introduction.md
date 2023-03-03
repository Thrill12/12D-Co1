## Writing functional programming

Variables are immutable so programming is stateless

Major benefit is it makes code much easier to write correctly and easier to understand and predict how the program will behave. It is also less prone to bugs. 

Big data uses functional programming to its full extent because it allows much easier and faster data manipulation due to functional programming being much more focused on the mathematical functions behind the data.

This allows functional programming to take full advantage of parallel programming.

A function is a rule, that for each element of some set A of inputs, assigns an output chosen from set B, but without necessarily using every member of B.

Co-Domain mapping -> A -> B where f(x) = x^2

In functionmal programming a function is considered a first-class object.

A first class object is an object which may:
- be returned in a function call
- appear in expression
- be assigned to a variable
- be assigned in an argument

Examples:

- integers
- real/float/decimals
- characters
- strings

## Composition of functions

The idea that you can combine two functions in order to get a new function

L: A -> B
K: B -> C

K.L A -> C

Co domain of L must be the same as the domain of K

K
add :: integer -> integer -> integer
add x y = x + y
add 5 6     Output = 11

L
double :: integer -> integer
double s = 2 * s
double 10   Output = 20

L.K (composition of K and L)