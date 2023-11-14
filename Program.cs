// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b = 10;  // assign a literal value
int c = 20;
char d = 'e';

a = 5; // assign a literal value
a = 10;
a = b; // assign a variable 
a = b + 5; // assignment   an arithmetic expression
a = (b + 5) + c*10 + d/2; // assign a mixed expression (var only, var and literal

a = 0;
a = a + 1;
a = a + 5;
a += 5; // a = a+5; take a and increment/ add-on it by 5
a -= 1; // a = a - 1; take a and decrement it by 1
a *= 2; // a = a * 2; take a and multiply it by 2
a /= 3; // a = a/3;
a %= 2; // a = a%2;

int x = 0;
x = x + 1;

Console.WriteLine($"x = {x}");
Console.WriteLine($"x = {x+1}"); // this doesnot change the value of x

//x + 1; =< x = x+1
Console.WriteLine($"x = {x=x+1}"); // this doesnt chage the value of x
Console.WriteLine($"x = {x}");

// post increment   -- the increment happen after  --1. use the orig value of x 2. increment x by 1
x = 0;
Console.WriteLine($"x++ = " + x++);
Console.WriteLine($"x = {x}");

x = 1;
int y = x++ + 5; // y = x + 5 = 1 +5 = 6 ; x = x + 1;
int z = ++x + 5; // x = x+1; y = x + 5 = 3 + 5 = 8

Console.WriteLine($"y = {y}");
Console.WriteLine($"z = {z}");



x = 0;
x++;
Console.WriteLine($"x = {x}");

// pre increment   -- the increment happen prior --1. increment   2 give the new value of x
x = 0;
Console.WriteLine($"x++ = " + ++x);
Console.WriteLine($"x = {x}");


x = 0;
++x;
Console.WriteLine($"x = {x}");

int z1 = 0;
z1 = ++z1 + 5;
Console.WriteLine("z1 = {0}", z1);

int m1 = 0;
z1 = m1++ + 5;
Console.WriteLine("m1 = {0}", m1);

int z2 = 0;
z2 = ++z2;
Console.WriteLine("z2 = {0}", z2);


