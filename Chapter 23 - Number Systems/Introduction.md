# A number is a unit of mathematical data used to count, quantify, label and measure. We are used to using standard number systems such as the decimal system and over the next few chapters you will learn about binary and hex too.
# This chapter will look at how different types or sets of numbers can be used in different ways in computing.

### Natural Numbers

These are the most recognizable: 0,1,2,3,4,5,6,7,8,9.
This is decimal, or base 10. Using a single-digit number we can represent a max value of 9.
We simply add a new digit to create the numbers 10-99.
Each extra digit we add is worth ten times as much as the previous digit.

Natural numbers go from 0 to infinity.

**N** is the mathematical symbol for the set of natural numbers

**N** = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, ...}

### Integer Numbers

An *integer* is a whole number which can be positive or negative. Zero is classed as an integer.
Different languages have different variations of the integer type. In VB, the *Integer* type uses four bytes allowing the range of:
- -2 147 483 648 to 2 147 483 638
It has another type called *long* to handle numbers outside this range.

The mathematical symbol for the set of integers is **Z**.

**Z** = {..., -3, -2, -1, 0, 1, 2, 3, ...}

### Rational Numbers

A *rational* number is one that can be expressed as a fraction. The ratio can be expressed as a decimal or a fraction. Eg. 1/2 is a half, or 0.5.
The top integer is the numerator, the bottom integer is the denominator.
Fractions can also result in the value of one (5/5 = 1, 8/8 = 1). This means by definition, all *integers* are *rational* numbers.

The only rule is that the denominator can be any integer apart from 0.

The mathematical symbol for rational numbers is **Q**.

### Irrational Numbers

An **irrational** number is any number that can't be represented as a ratio of integers because the decimal equivalent would go on forever.
A classic example is pi. As a fraction, a widely used approximation is 22/7.
In decimal form, the number is infinite so it has to be truncated to a set number of decimal places, for example 3.14.

Some square roots and cube roots are **irrational**.

A feature of an **irrational** number is that the values after the decimal place do not repeat in any pattern - there is no pattern to the numbers in pi.
Recurring decimals have a pattern and are therefore classified as rational numbers, eg. 1/3 = 0.33333333...

In computing, the programmer needs to decide on the precision needed when handling **irational** numbers and therefore how much memory to allocate to storing the value. Computers handle these numbers as floating point numbers.

### Real Numbers

A **real** number is any positive or negative value and can include a fractional part. Integers, rational numbers and irrational numbers are all real numbers. 
The defining feature of **real** numbers is that the fractional part can be any length, allowing teh number to represent a measurement to any level of precision and accuracy required.
**Real** numbers are used to measure continuous or infinitely changing values. For programmers, the issue is in defining how accurate and precise a number needs to be for the application.

### Ordinal numbers

**Ordinal** numbers define the position of something within a list, eg. first, second, third. They are often used with **Cardinal** numbers, which identify the size of the list, eg. third out of 20.

In computing, **ordinal** numbers are used to identify the position of data within a set.

A one-dimensional **array** called *Register* shows a list of names in a register:
Allen   Brown   Christie    Davali  Ennis
Ordinal numbers are used to assign the data as follows:
'''
Register(1) = "Allen"
Register(2) = "Brown"
'''