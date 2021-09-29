# DotNet5-ConsoleApp-BinToDec
Converts a binary value to decimal.

[![author](https://img.shields.io/badge/author-sandredossantos-blue.svg)](https://www.instagram.com/sandredossantos)
[![tier](https://img.shields.io/badge/tier-beginner-purple.svg)](https://github.com/florinpop17/app-ideas/blob/master/Projects/1-Beginner/Bin2Dec-App.md)
[![MIT license](https://img.shields.io/badge/License-MIT-red.svg)](https://opensource.org/licenses/MIT)

# Context
The project has as its core the conversion of a binary value into its decimal equivalent.

# Binary to decimal conversion
To convert a binary number to its decimal equivalent, simply multiply each bit by its position value and add the results.
- Position value is a power where the exponent is the bit position in descending order of reading the binary and the base is the number 2.
- The sum of all position values ​​results in the decimal equivalent.

As an example, we will convert the value 1101

| Binary                              | 1| 1| 0| 1|
|-------------------------------------|--|--|--|--|
| PositionValue                       |2³|2²|2¹|1|
| Calculation                         |(2³)1 = 8|(2²)1 = 4|(2¹)0 = 0|(1)1 = 1|

- Equivalent decimal value: 8 + 4 + 0 + 1 = 13
 

# Technologies
- **NET 5.0**
- **xUnit**

# User Stories
- User can enter up to 8 binary digits in one input field.
- User must be notified if anything other than a 0 or 1 was entered.
- User views the results in a single output field containing the decimal (base 10) equivalent of the binary number that was entered.

Thanks for reading!:thumbsup:
