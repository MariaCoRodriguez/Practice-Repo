// See https://aka.ms/new-console-template for more information
//Assignment2 Number1
//Declare a variable for each of the following:
/*
Console.WriteLine("Assignment2, Number 1: ");
Console.WriteLine("Declare a variable for each of the following: ");

float currentTemp = 23;
Console.WriteLine("a. The current temperature is: " + currentTemp);

char letterGrade = 'A';
Console.WriteLine("b. The letter grade is: " + letterGrade);

float apAverage = 8.2f;
Console.WriteLine("c. Your final AP average is: " + apAverage);

int studNumber = 16;
Console.WriteLine("d. The number of students in a class: " + studNumber);

string favColour = "Verde";
Console.WriteLine("e. Your favorite colour is: " + favColour);

int tempBakingBan = 220;
Console.WriteLine("f. The temperature required for baking a banana cake is: " + tempBakingBan);

char middleInitial = 'C';
Console.WriteLine("g. Your middle initial is: " + middleInitial);

int studentID = 2320001;
Console.WriteLine("h. Your 7-digit student ID is: " + studentID);

string mobileNumber = "5148855260";
Console.WriteLine("i. Your 10-digit mobile number  is: " + mobileNumber);

float piNumber = 3.1416f;
Console.WriteLine("j. PI  is: " + piNumber);

string nameBank = "CIBC";
Console.WriteLine("k. The name of your bank is: " + nameBank);

Boolean yesNoQs = true;
Console.WriteLine("l.A yes/no answer to a question is: " + yesNoQs);
//Console.WriteLine("If you are a woman write true if not write false: ");
//yesNoQs = Convert.ToSingle(Console.ReadLine());

/* [explicit casting]
2 a. Declare a(n) ________ variable and cast it into a(n) ________ variable. 
 * Print the latter. What do you observe in each case?


Console.WriteLine("Assignment2, Number 2.a: ");
Console.WriteLine("Declare a(n) ________ variable and cast it into a(n) ________ variable: ");

int aNum1 = 10;
float bNum1 = (float) aNum1;
Console.WriteLine("i. integer: " + aNum1 + " float: " + bNum1);

float aNum2 = 10.5f;
int bNum2 = (int) aNum2;
Console.WriteLine("ii. float: " + aNum2 + " integer: " + bNum2);

float cNumb3 = 105.653f;
double dNumb3 = (double)cNumb3;
Console.WriteLine("iii. Float " + cNumb3 +  " double: " + dNumb3);

char aChar1 = '1';
int aNum4 = (int)aChar1;
Console.WriteLine("iv. char: " + aChar1 + " integer: " + aNum4);

char aChar2 = '2';
float aNum5 = (float)aChar2;
Console.WriteLine("v. char: " + aChar2 + " float: " + aNum5);

int aNum6 = '3';
char aChar3 = (char)aNum6;
Console.WriteLine("vi. int: " + aNum6 + " char: " + aChar3);

float aNum7 = 3.23f;
char aChar4 = (char)aNum7;
Console.WriteLine("vii. float: " + aNum7 + " char: " + aChar4);



// Ex.2b
// Repeat the exercise: instead of explicit casting, use the Convert.To…() syntax.
// What is the difference between explicit casting and conversion?

Console.WriteLine("Assignment2, Number 2.b: ");
Console.WriteLine("Repeat the exercise: instead of explicit casting, use the Convert.To…() syntax.");

int aaNum1 = 10;
float bbNum1 = Convert.ToSingle(aaNum1);
Console.WriteLine("i. integer: " + aaNum1 + " float: " + bbNum1);

float aaNum2 = 10.5f;
int bbNum2 = Convert.ToInt16(aaNum2);
Console.WriteLine("ii. float: " + aaNum2 + " integer: " + bbNum2);

float ccNumb3 = 105.653f;
double ddNumb3 = Convert.ToDouble(ccNumb3);
Console.WriteLine("iii. Float " + ccNumb3 + " double: " + ddNumb3);

char aaChar1 = '1';
int aaNum4 = Convert.ToInt16(aaChar1);
Console.WriteLine("iv. char: " + aaChar1 + " integer: " + aaNum4);

char aaChar2 = 'b';
int aaNum5 = Convert.ToInt16(aaChar2);
float aaNum55 = Convert.ToSingle(aaNum5);
Console.WriteLine("v. char: " + aaChar2 + " float: " + aaNum55);

int aaNum6 = '3';
char aaChar3 = Convert.ToChar(aaNum6);
Console.WriteLine("vi. int: " + aaNum6 + " char: " + aaChar3);

float aaNum7 = 3.23f;
int aaNum8 = Convert.ToInt16(aaNum7);
char aaChar4 = Convert.ToChar(aaNum8);
Console.WriteLine("vii. float: " + aaNum7 + " char: " + aaChar4);

//Ex. 3 implicit casting
//Prompt the user for a float, save it into a float var using Convert.ToSingle(),
//and then save the var in an integer.Print the integer. What do you observe?
Console.WriteLine("Assignment2, Number 3: ");

float ExampleA = 5.152f;
float ExampleB = Convert.ToSingle(ExampleA);
int ExampleC = Convert.ToInt16(ExampleB);
Console.WriteLine("3.a integer: " + ExampleC);

//Prompt the user for an integer, save it into an integer var using Convert.ToInt32(),
//and then save the var into a float. Print the float. What do you observe?

int ExampleD = 25;
int ExampleE = Convert.ToInt32(ExampleD);
float ExampleF = Convert.ToSingle(ExampleE);
Console.WriteLine("3.b float: " + ExampleF);

//Prompt the user for an integer or a float. This time, save it in the right variable type.
//Print the variable. Anything ?

float ExampleG = 39.24f;
float ExampleH = Convert.ToSingle(ExampleG);
Console.WriteLine("3.c float: " + ExampleH);

//Ex. 4 [logic]
//Come up with 4 or 8 pairs of statements that would allow you to understand how && and || operate.

Console.WriteLine("Assignment2, Number 4.a: ");

int edad1 = 2;
int edad2 = 14;
bool result1 = (edad1 > 0) && (edad2 <= 4); // result1 will be False
Console.WriteLine(result1);

int edad3 = 5;
int edad4 = 12;
bool result2 = (edad3 >= 5) || (edad4 <= 12);  // result2 will be True
Console.WriteLine(result2);

//second pair

bool mes1 = true;
bool mes2 = true;
bool result3 = (mes1 && mes2); // result3 will be True
Console.WriteLine(result3);

bool mes3 = false;
bool mes4 = false;
bool result4 = (mes3 || mes4); // result4 will be False
Console.WriteLine(result4);

//third pair

bool mes5 = true;
bool mes6 = false;
bool result5 = (mes5 && mes6); // result5 will be false
Console.WriteLine(result5);

bool mes7 = false;
bool mes8 = true;
bool result6 = (mes7 || mes8); // result6 will be False
Console.WriteLine(result6);

//fourth pair

int num3 = 2;
int num4 = 14;
bool result7 = (num3 == 2) && (num4 <= 15); // result7 will be True
Console.WriteLine(result7);

int num5 = 5;
int num6 = 12;
bool result8 = (num5 >= 6) || (num6 < 12);  // result8 will be False
Console.WriteLine(result8);


//4.b Throw a third statement S3 in the mix. Let S3 be true, then let it be false. What happens?

Console.WriteLine("Assignment2, Number 4.b: ");

int num7 = 100;
int num8 = 1000;
bool result9 = (num7 >= 90) && (num8 == 1000); //result9 will be True
Console.WriteLine(result9);

int num9 = 50;
int num10 = -10;
bool result10 = (num9 >= 60) || (num10 >= 60); //result9 will be False
Console.WriteLine(result10);

//5 [boolean expressions]

//a. Fill in the blanks to determine if a character is a vowel: bool isVowel = ……………; 

Console.WriteLine("Assignment2, Number 5.a: ");

bool vowel1 = a;
bool vowell = c;
bool result11 = (vowel1 || vowell);

*/















