// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.IO.Pipes;
string name;
do
{
    Console.WriteLine($"*******Welcome to B.Hive*************\n ");

    Console.WriteLine($"Please enter your name: ");
    name = Convert.ToString(Console.ReadLine());

    char product;
    int countOfTC = 0;   // count of  turkish
    int countOfDE = 0, countOfSL = 0;  // count of latte, double
    float TCPrice = 3.35f;
    float DEPrice = 3.25f;
    float SLPrice = 4.80f;
    float WCPrice = 0.75f;
    char ans, ans1, ans2;
 
    do
    {
        Console.WriteLine($"What can I get you {name}.\n" +
            $"a. Turkish coffee (3.35$)\n" +
            $"b. Double Espresso (3.25$)\n" +
            $"c. Spanish Latte (4.80$)");
        product = Convert.ToChar(Console.ReadLine());

        switch (product)
        {
            case 'a':
                do
                {
                    Console.WriteLine("How many Turkish Coffees would you like? (1-5)");
                    countOfTC = Convert.ToInt16(Console.ReadLine());
                } while (countOfTC < 1 || countOfTC > 5);  // is or nor and
                break;
            case 'b':
                countOfDE++;
                Console.WriteLine("Adding a Double Espresso to your order");
                Console.WriteLine($"Would you like some Whipped Cream with it? (y/n) ");
                ans1 = Convert.ToChar(Console.ReadLine());
                switch (ans1)
                {
                    case 'y':
                        do
                        {
                            Console.WriteLine("That'll be an extra 0.75$. Do you want to proceed with the extra charge? (y/n)");
                        } while (Convert.ToChar(Console.ReadLine()) == 'n');
                        break;
                }
                do
                {
                    Console.WriteLine("Would you like to add another Double Espresso?");
                } while (Convert.ToChar(Console.ReadLine()) == 'y');
                break;
            case 'c':
                do
                {
                    Console.WriteLine("Adding a Spanish Latte to your order");
                    countOfSL++;
                    Console.WriteLine($"Would you like to add another Spanish Latte? (y/n) ");
                    ans2 = Convert.ToChar(Console.ReadLine());
                } while (ans2 == 'y');
                Console.WriteLine($"You have added {countOfSL} Spanish Lattes to your order.");
                break;
        }

        do
        {
            Console.WriteLine("Would you like to add another beverage to your order? (y/n)");
            ans = Convert.ToChar(Console.ReadLine());
            if (ans != 'y' && ans != 'n')
            {
                Console.WriteLine($"Sorry, I don't recognize this answer");
            }
        } while (ans != 'y' && ans != 'n');
    } while (ans == 'y');

    Console.WriteLine($"Your order summary: ");
    float t = Convert.ToSingle(countOfTC * TCPrice);
    Console.WriteLine($"{countOfTC} Turkish Coffees @ {t}$");
    float s = Convert.ToSingle(countOfSL * SLPrice);
    Console.WriteLine($"{countOfSL} Spanish Latte @ {s}$");
    float d = Convert.ToSingle((countOfDE * DEPrice) + (countOfDE * WCPrice));
    Console.WriteLine($"{countOfDE} Double Espresso with Whipped Cream @ {d}$");
    string total = Convert.ToString($"{t + d + s}");
    Console.WriteLine($"Total {total}$");

    Console.WriteLine("Please enter you 16-digits credit card number: ");
    string ccardNum = Convert.ToString(Console.ReadLine());

    byte month, year;
    bool isValidExpiration;

    do
    {
        Console.WriteLine("Please enter the month (MM) and year (YY) of expiration - on separate lines:");
        month = Convert.ToByte(Console.ReadLine());
        year = Convert.ToByte(Console.ReadLine());
       
        isValidExpiration = year == 23 && (month == 11 || month == 12) ||
                            (year >= 24 && year <= 27) && (month >= 1 || month <= 12) ||
                            year == 28 && (month >= 1 && month <= 11);
        if (!isValidExpiration)
        {
            Console.WriteLine("Sorry, this is invalid.");
        }
    } while (!isValidExpiration);

    short cvv;
    do
    {
        Console.WriteLine("Please enter your 3-digits CVV: ");
        cvv = Convert.ToInt16(Console.ReadLine());
    } while (cvv < 100 || cvv > 999);

    Console.WriteLine("Thank you for visiting B.Hive, Michelle! We will call your name when your order is ready. Have a great day!");

} while (name != "");

