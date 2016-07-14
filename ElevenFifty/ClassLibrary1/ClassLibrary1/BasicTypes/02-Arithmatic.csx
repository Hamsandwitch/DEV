

var x = 1; // while value is a static 32-bit integer (int32), it can be manipulated after this simply using x = 1 etc. (must be within initial 16/32/64)

var sum = 32 + 10; // addition

var diff = 52 - 10; // subtraction

var prod = 21 * 2; // multiplication

var quot = 168 / 4; // division

var mod = 42 % 5; // modulus (








// Increment-Decrement operations

x++; // adds 1 to X, does not require value to X

++x; // adds 1 to X, after X's value has been determined

x--; // subtracts 1 from X, does not require value to X

--x; // subtract 1 from X, after X's value has been determined


x += 42; //

x -= 42; //

x *= 42; //

x /= 42; //








// Comparative functions

var eq = 10 == 5; // equal

var ne = 10 != 5; // not equal

var gt = 10 > 5; // greater than

var lt = 10 < 5; // less than

var gte = 10 >= 5; // greater-than or equal

var lte = 10 <= 5; // less-than or equal




var condition1 = true; //

var condition2 = false; //

var condition3 = false; //


var both = condition1 && condition2; // cond1 and cond2 must be the same value

var either = condition1 || condition2; // cond1 and cond2 must be 

var oneOf = condition1 ^ condition2; // cond1 and cond2 must be different values




// reference objects go on the heap.

// value objects go on the stack.


