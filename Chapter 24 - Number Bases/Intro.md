# Computers process data in digital form. This means that the data is represented as discrete values, in the form of ones and zeros. This known as binary data and in this chapter you will discover how binary is used and how it relates to other **number bases** such as decimal or hexadecimal

### The bit

Computers use microprocessors, also referred to as chips or silicon chips. A chip is a small piece of silicon implanted with millions of electronic circuits. The chip rececives pulses of electricity that are passed around these microscopic circuits in a way that allows the computers to represent text, numbers, sounds, and graphics.

A **bit** is a binary digit. The processor can only handle electricity in a simple way - either electricity is flowing or it is not. This is often referred to as two states, hence the name binary. 
A computer translates these sequences of 1s and 0s into something readable for humans by having different sequences mean something else.

Computers string together zeros and ones in a similar way to represent text, numbers, sound, video and everything else that we get to use our computers for.
The clock speed of your computer indicates the speed at which signals are sent around the processor. In simple terms, a clock speed of **2GHz** means that it will receive 2 billion of these on/off pulses per second.

### The Byte

A single byte is a string of 8 bits.

- 1 bit = 2 permutations
- 2 bit = 4 permutations
- 3 bit = 8 permutations
- n bits = 2^n permutations

## Units

|Binary             |Decimal            |
|kibibyte Ki 2^10   |Kilobyte KB 10^3   |
|mebibyte Mi 2^20   |megabyte MB 10^6   |
|gibibyte Gi 2^30   |gigabyte GB 10^9   |
|tebibyte Ti 2^40   |terabyte TB 10^12  |

## Number Bases

A number base indicates how many different digits are available when using a particular number system. For example, a decimal is number base 10 because there are 10 different numbers or tools we can use to make up each number in the base. Binary is base 2 because we can only use 0 and 1.

Some aspects of computing involve number base 16 which is referred to as hexadecimal. Different number bases are sometimes used when we need to represent large numbers in an easy way, such as colours or memory addresses in HEX.

### Hexadecimal

Main advantage of Hex is that two digits can represent one byte.

Consider the number 11010011. This is an 8-bit code which when converted to decimal equals 211. The same number in Hex is D3. This basic example shows that an 8-bit code in binary can be represented as a two-digit code in hex.

As Hex is base number 16, it uses 16 digits to form its codes:

- 0
- 1
- 2
- 3
- 4
- 5
- 6
- 7
- 8
- 9
- A - 10
- B - 11
- C - 12
- D - 13
- E - 14
- F - 15

Going from 0 to 15.

### Working with number bases

When performing calculations, humans use number base 10 probably because we have ten digits on our hands.

In decimal terms, the number 2098 is easy to understand.

- 2 x 1000
- 0 x 100
- 9 x 10
- 8 x 1

Binary is base 2 and works on exactly the same principle.

In binary, the number 135 will be represented by teh code 10000111:

- 1 x 128
- 0 x 64
- 0 x 32
- 0 x 16
- 0 x 8
- 1 x 4
- 1 x 2
- 1 x 1

### Binary to decimal converters

- Write down a binary number
- Above the number, starting from the least significant bit on the left, write number 1
- For each subsequent number, double the previous number. This gives you each column
- Wherever there is a 1 in the code, add the column heading to the final value.

## Decimal to binary converters

- Write down the power of 2 sequence.
- Starting from the MSB put a 1 or 0 in each column as necessary to add up the final numbers to the number you wish to translate.

Another way of carrying out this calculation is to carry out repeated divisions on the decimal number (98) as follows:

- 98 / 2 = 49 remainder 0
- 49 / 2 = 24 remainder 1
- 24 / 2 = 12 remainder 0
- 12 / 2 = 6 remainder  0
- 6 / 2 = 3 remainder   0
- 3 / 2 = 1 remainder   1
- 1 / 2 = 0 remainder   1

We divide the number by two until we get 0 truncated. At this point, we read backwards the list of remainders, eventually getting 1100010 (reading from the bottom up).