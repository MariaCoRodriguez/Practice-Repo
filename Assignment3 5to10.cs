// See https://aka.ms/new-console-template for more information

//5 [boolean expressions]
//5.a. Fill in the blanks to determine if a character is a vowel: bool isVowel = ……………; 

/*
Console.WriteLine("Assignment3, Number 5.a: ");

Console.WriteLine("Enter a character");
char c1 = Char.ToLower(Convert.ToChar(Console.ReadLine()));
bool isVowel11 = c1 == 'a' || c1 == 'e' || c1 == 'i' || c1 == 'o' || c1 == 'u';

if (isVowel11 == true)
{
	Console.WriteLine("It is a vowel!");
}
else
{
	Console.WriteLine("It is not a vowel");
}


//char c2 = char.ToLower(Convert.ToChar(Console.ReadLine()));
//bool isVowel1 = c2 == 'a' || c2 == 'e' || c2 == 'i' || c2 == 'o' || c2 == 'u';
//string theEnglishVowels = "aeiou";
//bool isVowel2 = theEnglishVowels.Contains(c2);
//bool isVowel3 = "aeiou".Contains(c2);
//Console.WriteLine(isVowel3);


//5.b Fill in the blanks to determine if a number is even or odd: bool isOdd = …………., isEven = …………….; 
Console.WriteLine("Assignment3, Number 5.b: ");

int num = 5;

bool isEven = num % 2 == 0;
bool isOdd = num % 2 != 0; // num%2 == 1; 

if (isEven == true)
{
	Console.WriteLine("The number is Odd.");
}
else
{
	Console.WriteLine("The number is even.");
}

// 6. Prompt the user for a 4-digit year and let him/her know if it’s a leap year.

Console.WriteLine("Assignment3, Number 6: ");
Console.WriteLine("Prompt the user for a 4-digit year: ");

int year = Convert.ToInt32(Console.ReadLine());
bool isLeap = year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
Console.WriteLine("This is a Leap year: " + isLeap);


// 7. Prompt the user for a month m, a day d and a 4 digit year y, and let him/her know what day
// of the week his input corresponds to. Use the following formulas: 

Console.WriteLine("Assignment3, Number 7: ");

Console.WriteLine("Enter a month (1 to 12): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a day (1 to 31): ");
int d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a 4-digit year: ");
int y = Convert.ToInt32(Console.ReadLine());

int y0 = y - (14 - m) / 12;
int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
int m0 = m + 12 * ((14 - m) / 12) - 2;
int d0 = (d + x + (31 * m0) / 12) % 7;

switch (d0)
{
	case 0:  // In days 0 is Sunday C# read 0 as Sunday
		Console.WriteLine("Sunday");
		break;
	case 1:
		Console.WriteLine("Monday");
		break;
	case 2:
		Console.WriteLine("Tuesday");
		break;
	case 3:
		Console.WriteLine("Wednesday");
		break;
	case 4:
		Console.WriteLine("Thursday");
		break;
	case 5:
		Console.WriteLine("Friday");
		break;
	case 6:
		Console.WriteLine("Saturday");
		break;
	default:
		Console.WriteLine("Out of range");
		break;
}

		//Console.WriteLine("" + d0);

//string[] daysOfWeek = { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

//Console.WriteLine($"The date {m}/{d}/{y} falls on a {daysOfWeek[d0]}.");


//8. Prompt the user for a month m and a day d and let him/her know the season. 

Console.WriteLine("Assignment3, Number 8: ");

Console.WriteLine("Enter a month (1 to 12): ");
int month = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a day (1 to 31): ");
int day = Convert.ToInt32(Console.ReadLine());

switch (month)
{
	case 12:
		if (day >= 21)
			Console.WriteLine("Winter");
		else
			Console.WriteLine("Autum");
		break;
	case 11:
		Console.WriteLine("Autum");
		break;
	case 10:
		Console.WriteLine("Autum");
		break;
	case 9:
		if (day >= 21)
			Console.WriteLine("Autum");
		else
			Console.WriteLine("Summer");
		break;
	case 8:
		Console.WriteLine("Summer");
		break;
	case 7:
		Console.WriteLine("Summer");
		break;
	case 6:
		if (day >= 21)
			Console.WriteLine("Summer");
		else
			Console.WriteLine("Spring");
		break;
	case 5:
		Console.WriteLine("Spring");
		break;
	case 4:
		Console.WriteLine("Spring");
		break;
	case 3:
		if (day >= 21)
			Console.WriteLine("Spring");
		else
			Console.WriteLine("Winter");
		break;
	case 2:
		if (day >= 21)
			Console.WriteLine("Winter");
		else
			Console.WriteLine("Winter");
		break;
	case 1:
		if (day <= 31 && day > 0)
			Console.WriteLine("Winter");
		else
			Console.WriteLine("Please review the day entered");
		break;
	default:
		Console.WriteLine("Out of range");
		break;
}
*/


/*

//ansuwer with WG
Console.WriteLine("Enter a month (1 to 12): ");
int month = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a day (1 to 31): ");
int day = Convert.ToInt32(Console.ReadLine());

if (month == 12 && day >= 21)
{
	Console.WriteLine("It is Winter");
}
else if (month == 12)
{
	Console.WriteLine("It is Autum");
}
if (month == 3 && day >= 21)
{
	Console.WriteLine("It is Spring");
}
else if (month == 3)
{
	Console.WriteLine("It is Winter");
}
if (month == 6 && day >= 21)
{
	Console.WriteLine("It is Summer");
}
else if (month == 6)
{
	Console.WriteLine("It is Spring");
}
if (month == 9 && day >= 21)
{
	Console.WriteLine("It is Autum");
}
else if (month == 9)
{
	Console.WriteLine("It is Summer");
}
if (month == 1 || month == 2)
{
	Console.WriteLine("It is Winter");
}
if (month == 4 || month == 5)
{
	Console.WriteLine("It is Spring");
}
if (month == 7 || month == 8)
{
	Console.WriteLine("It is Summer");
}
if (month == 10 || month == 11)
{
	Console.WriteLine("It is Autum");
}
*/
/*
//bool Winter = "December 21 – March 20";
//bool Spring = "March 21 – June 20";
//bool Summer = "June 21 – October 20";
//bool Autum = "October 21 – December 20";

if (month == 12 && day >= 21) || (month <= 3 && month >= 1) || (month == 3 && day <= 20);
{
	Console.WriteLine("Is Winter");
}
else if (month == 3 && day >= 21) || (month <= 6 && month >= 3) || (month == 6 && day <= 20);
{
	Console.WriteLine("Is Spring");
}


Console.WriteLine("Assignment3, Number 9: ");

Console.WriteLine("Please enter a character: ");
char myChar = Convert.ToChar(Console.ReadLine());
bool isDigit = myChar >= 48 && myChar <= 57;
Console.WriteLine($"{myChar} is a digit: {isDigit}" );




//#10 [research] What is the ternary operator and how does it work? Come up with different
//examples & run them to guarantee you understood.


//Console.WriteLine("Assignment3, Number 10: ");
Console.WriteLine("Conditional operator: ");

int a2 = 9;
int w2 = 12;


//if (a2 >= 9)
//{
//	Console.WriteLine(w2=10);
//}
//else if (a2 < 9)
//{
//	Console.WriteLine(w2=11);
//}

Console.WriteLine(w2 = (a2 >= 9) ? 10 : 11);
*/
/*
int a1 = 6;
string w1 = 12;

//if (a1 >= 9)
//{
//	Console.WriteLine("It is Autum");
//}
//else if (a1 >= 12)
//{
//	Console.WriteLine("It is Winter");
//}

Console.WriteLine(w1 = (a1 >= 9) ? 12 : 9);
*/


int maxTemp = 0;
int minTemp = 0;
int maxDay = 0;
int minDay = 0;
int temp = 0;

for (int d = 1; d <= 7; d++)
{
	switch (d)
	{
		case 1:
			Console.WriteLine($"Enter the temperature (between -5 and +20) for 1. Monday: ");
			temp = Convert.ToInt16(Console.ReadLine());
            if ((temp >= -5) && (temp <= 20))
            {
                Console.WriteLine($"The temperature entered is valid");
                maxTemp = temp;
                minTemp = temp;
                maxDay = d;
                minDay = d;
            }
            else
            {
                Console.WriteLine($"The temperature you enter is invalid");
            }
            break;
		case 2:
            Console.WriteLine($"Enter the temperature (between -5 and +20) for 2. Tuesday: ");
            temp = Convert.ToInt16(Console.ReadLine());
            if ((temp >= -5) && (temp <= 20))
            {
                Console.WriteLine($"The temperature entered is valid");
                if (temp > maxTemp)
                {
                    maxTemp = temp;
                    maxDay = d;
                    minDay = minDay == 0 ? d : minDay;
                    minTemp = minTemp == 0 ? d : minTemp;
                }
                if (temp < minTemp)
                {
                    minTemp = temp;
                    minDay = d;
                }
            }
            else
            {
                Console.WriteLine($"The temperature you enter is invalid");
            }
			break;
		case 3:
            Console.WriteLine($"Enter the temperature (between -5 and +20) for 3. Wednesday: ");
            temp = Convert.ToInt16(Console.ReadLine());
            if ((temp >= -5) && (temp <= 20))
            {
                Console.WriteLine($"The temperature entered is valid");
                if (temp > maxTemp)
                {
                    maxTemp = temp;
                    maxDay = d;
                    minDay = minDay == 0 ? d : minDay;
                    minTemp = minTemp == 0 ? d : minTemp;
                }
                if (temp < minTemp)
                {
                    minTemp = temp;
                    minDay = d;
                }
            }
            else
            {
                Console.WriteLine($"The temperature you enter is invalid");
            }
            break;
		case 4:
            Console.WriteLine($"Enter the temperature (between -5 and +20) for 4. Thursday: ");
            temp = Convert.ToInt16(Console.ReadLine());
            if ((temp >= -5) && (temp <= 20))
            {
                Console.WriteLine($"The temperature entered is valid");
                if (temp > maxTemp)
                {
                    maxTemp = temp;
                    maxDay = d;
                    minDay = minDay == 0 ? d : minDay;
                    minTemp = minTemp == 0 ? d : minTemp;
                }
                if (temp < minTemp)
                {
                    minTemp = temp;
                    minDay = d;
                }
            }
            else
            {
                Console.WriteLine($"The temperature you enter is invalid");
            }
            break;
		case 5:
            Console.WriteLine($"Enter the temperature (between -5 and +20) for 5. Friday: ");
            temp = Convert.ToInt16(Console.ReadLine());
            if ((temp >= -5) && (temp <= 20))
            {
                Console.WriteLine($"The temperature entered is valid");
                if (temp > maxTemp)
                {
                    maxTemp = temp;
                    maxDay = d;
                    minDay = minDay == 0 ? d : minDay;
                    minTemp = minTemp == 0 ? d : minTemp;
                }
                if (temp < minTemp)
                {
                    minTemp = temp;
                    minDay = d;
                }
            }
            else
            {
                Console.WriteLine($"The temperature you enter is invalid");
            }
            break;
		case 6:
            Console.WriteLine($"Enter the temperature (between -5 and +20) for 6. Saturday: ");
            temp = Convert.ToInt16(Console.ReadLine());
            if ((temp >= -5) && (temp <= 20))
            {
                Console.WriteLine($"The temperature entered is valid");
                if (temp > maxTemp)
                {
                    maxTemp = temp;
                    maxDay = d;
                    minDay = minDay == 0 ? d : minDay;
                    minTemp = minTemp == 0 ? d : minTemp;
                }
                if (temp < minTemp)
                {
                    minTemp = temp;
                    minDay = d;
                }
            }
            else
            {
                Console.WriteLine($"The temperature you enter is invalid");
            }
            break;
        case 7:
            Console.WriteLine($"Enter the temperature (between -5 and +20) for 7. Sunday: ");
            temp = Convert.ToInt16(Console.ReadLine());
            if ((temp >= -5) && (temp <= 20))
            {
                Console.WriteLine($"The temperature entered is valid");
                if (temp > maxTemp)
                {
                    maxTemp = temp;
                    maxDay = d;
                    minDay = minDay == 0 ? d : minDay;
                    minTemp = minTemp == 0 ? d : minTemp;
                }
                if (temp < minTemp)
                {
                    minTemp = temp;
                    minDay = d;
                }
            }
            else
            {
                Console.WriteLine($"The temperature you enter is invalid");
            }
            break;
    }

} 
	
Console.WriteLine($"The day {maxDay} has the highest temperature of {maxTemp} and the day {minDay} has the lowest temperature of {minTemp}");

/*

Console.WriteLine($"Enter the temperature for the day between -5 and +20: ");
int temp = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Enter a day Monday to Sunday (1 to 7) : " +
    $"1. Monday" +
    $"2. Tuesday" +
    $"3. Wednesday" +
    $"4. Thursday" +
    $"5. Friday" +
    $"6. Saturday" +
    $"7. Sunday ");
int day = Convert.ToInt32(Console.ReadLine());
*/