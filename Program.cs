
using System.Net.Mail;

public class Program
{

    public static string numb;
    public static int number;

    public static string numb1;

    public static int number1;

    public static string numb2;

    public static int number2;

    public static string letter;

    public static string numbDay;

    public static int numberDay;
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(69); // Test FahrenheitToCelsius Function with a random value
        // Test your functions by calling them below:
        CheckForPositiveNegativeZero(); 
        IsDivisibleBy5();
        CheckEvenOrOdd();
        // CheckVowelOrConsonant();
        DisplayDayOfWeek();

    }

    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:

    public static void CheckForPositiveNegativeZero()
    {
        Console.WriteLine("Please give a random number");
        numb = Console.ReadLine();
        number = int.Parse(numb);

        if (number < 0) {
            Console.WriteLine("Your number is negative");
        } else if (number > -1 && number1 < 1) {
            Console.WriteLine("Your number is zero");
        } else if (number > 0) {
            Console.WriteLine("Your number is positive");
        }
    }

    public static void IsDivisibleBy5()
    {
        Console.WriteLine("Please give a second random number");
        numb1 = Console.ReadLine();
        number1 = int.Parse(numb1);

        if (number1 % 5 == 0) {
            Console.WriteLine(numb1 + " is divisible by 5");
        } else {
            Console.WriteLine(numb1 + " is not divisible by 5");
        }
    }

    public static void CheckEvenOrOdd()
    {
        Console.WriteLine("Please give a third random number");
        numb2 = Console.ReadLine();
        number2 = int.Parse(numb2);

        if (number2 % 2 == 0) {
            Console.WriteLine(numb2 + " is an even number");
        } else {
            Console.WriteLine(numb2 + " is an odd number");
        }
    }

    // public static void CheckVowelOrConsonant()
    // {
        // Console.WriteLine("Please give a random letter");
        // letter = Console.ReadLine();

        // switch (letter)
        // {
            // if (letter = "A")
        // }
    // }   

        public static void DisplayDayOfWeek()
        {
            Console.WriteLine("Please give a number 0-6 representing the day of the week");
            numbDay = Console.ReadLine();
            numberDay = int.Parse(numbDay);

            switch (numberDay)
            {
                case 0:
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
            }
        }
    
}
