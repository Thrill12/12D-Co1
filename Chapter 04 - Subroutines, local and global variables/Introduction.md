## Introduction

In programming, a subroutine is a named block of programming code that performs a specific task. All programs therefore are made up of a series of subroutines. They provide structure to programs in the same way that chapters provide structure to a book. Subroutines are also called procedures, subprograms or routines.

Subroutines use variables that can either be local or global.

## Subroutines

A subroutine is self-contained and it carries out one or more related processes. These are sometimes called algorithms, which in turn are made up of lines of code. Subroutines have to be given unique name identifiers, which means that once written we can call them from whichever scope can access their file.

Breaking down a program like this has many benefits:

- They can be called at any time using the subroutine's unique name
- They allow you to gain an overview about how the program is put together
- You can use a top-down approach to develop the whole project
- The program is easier to test and debug because each subroutine is self-contained
- Very large projects can be developed by more than one programmer

## Functions

Functions are similar to subroutines however they return a value.

## Parameteres and arguments

In order for a subroutine or function to operate efficiently you need a way to control the data that it akes in. This is usually done by using parameters and arguments. A parameter works like a variable in that it identifies the data you want a subroutine to take in and use. The argument is the actual value being passed to the subroutine.

## Local and global variables

It is good practice to use local variables wherever possible and using them has a number of advantages:

- You cannot inadvertently change the value being stored somewhere else in the program
- You could use the same variable name in different sections, and each could be treated as a separate variable
- You free up memory as each time a local variable is finished with, it is removed from memory

