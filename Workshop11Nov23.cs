// See https://aka.ms/new-console-template for more information
//Workshop
//Do While
// boolean isValid
/*
byte num; // for do you don't need to give it a value
bool isValid;

do
{
    Console.WriteLine("Enter a number 1-10");
    num = Convert.ToByte(Console.ReadLine());
    isValid = (num <= 1 || num <= 10);
} while (isValid == true);
*/
/* boolean 
byte num;
bool isInvalid;

do
{
    Console.WriteLine("Enter a number 1-10");
    num = Convert.ToByte(Console.ReadLine());
    isInvalid = (num < 1 || num > 10);
} while (isInvalid == false);
*/

/* another boolean with isInvalid
byte num;
bool isInvalid;

do
{
    Console.WriteLine("Enter a number 1-10");
    num = Convert.ToByte(Console.ReadLine());
    isInvalid = (num <= 1 || num <= 10);
} while (isInvalid == true);
*/


//while (num < 1 || num > 10);  // without boolean
//while (!(num >= 1 && num <= 10));

//char ans;
//bool isValid;

//do
//{
//    Console.WriteLine($"Do you want coffee? (y/n) ");
//    ans = Convert.ToChar(Console.ReadLine());
//    isValid = ans == 'y' || ans == 'n'; // ans!= 'y' && ans!='n'; 
//} while (!isValid);

// another way to do it with is not valid

//bool isInvalid;
//do
//{
//    Console.WriteLine($"Do you want coffee? (y/n) ");
//    ans = Convert.ToChar(Console.ReadLine());
//    isInvalid = (ans != 'y' && ans != 'n');
//} while (isInvalid);

//Console.WriteLine();
//Console.ReadLine();
//Convert.ToInt32(Console.ReadLine());


//{
//    int i = 0;
//}

//Console.WriteLine(i);


/*
 * 
int n = 0;

switch ()
{
    case 0:

        break;
    case 1:

        break;
    default:

        break
}
*/
/*
int grade = 90;



if (grade >= 90)
{
    Console.WriteLine($"The grade is: A");
}
else if (grade >= 80 || grade < 90)
{
    Console.WriteLine($"The grade is: B");
}
else if (grade >= 70 || grade < 80)
{
    Console.WriteLine($"The grade is: C");
}
else if (grade >= 60 || grade < 70)
{
    Console.WriteLine($"The grade is: D");
}
else
{

}

*/
/*
if ()
{

}
else if ()
{

}
else if()
{

}
*/

/*
do
{

} while ();

while ()
{

};
*/
/*
for (int i = 0; i < 10; i++)
{

}
*/

char ans;
bool isValid;
/*
do
{
    Console.WriteLine("Welcome");
    do
    {
        Console.WriteLine($"Do you want a coffee? (y/n) ");
        ans = Convert.ToChar(Console.ReadLine());
        isValid = ans == 'y' || ans == 'n'; // ans!= 'y' && ans!='n'; 
    } while (!isValid);

    do
    {
        Console.WriteLine($"Do you want a cookie? (y/n) ");
        ans = Convert.ToChar(Console.ReadLine());
        isValid = ans == 'y' || ans == 'n'; 
    } while (!isValid);

    do
    {
        Console.WriteLine($"Do you want to continue ordering? (y/n) ");
        ans = Convert.ToChar(Console.ReadLine());
        isValid = ans == 'y' || ans == 'n';
    } while (!isValid);

} while (ans =='y');
*/
//
do
{
    Console.WriteLine("Welcome");
    do
    {
        do
        {
            Console.WriteLine($"Do you want a coffee? (y/n) ");
            ans = Convert.ToChar(Console.ReadLine());
            isValid = ans == 'y' || ans == 'n'; // ans!= 'y' && ans!='n'; 
        } while (!isValid);

        do
        {
            Console.WriteLine($"Do you want a cookie? (y/n) ");
            ans = Convert.ToChar(Console.ReadLine());
            isValid = ans == 'y' || ans == 'n';
        } while (!isValid);

        do
        {
            Console.WriteLine($"Do you want to continue ordering? (y/n) ");
            ans = Convert.ToChar(Console.ReadLine());
            isValid = ans == 'y' || ans == 'n';
        } while (!isValid);
    } while (ans == 'y');
} while (true);
