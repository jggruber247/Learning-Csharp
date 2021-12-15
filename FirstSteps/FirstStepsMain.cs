using System;

public class FirstSteps
{
	public static void StringsPractice()
    {
        // Hello World and String interpolation
        Console.WriteLine("Hello, World!");
        string strOne = "World!";
        Console.WriteLine($"Hello, {strOne}");
        strOne = "everyone!";
        Console.WriteLine($"Hello, {strOne}");

        // Working with Strings: Length method
        string firstFriend = "Maria";
        string secondFriend = "Sage";
        Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
        Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
        Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

        // Do more with strings: Trim methods
        string greeting = "      Hello World!      ";
        Console.WriteLine($"[{greeting}]");
        string trimmedGreeting = greeting.TrimStart();
        Console.WriteLine($"[{trimmedGreeting}]");
        trimmedGreeting = greeting.TrimEnd();
        Console.WriteLine($"[{trimmedGreeting}]");
        trimmedGreeting = greeting.Trim();
        Console.WriteLine($"[{trimmedGreeting}]");

        // Do more with strings: Replace, ToUpper, and ToLower methods
        string sayHello = "Hello World!";
        Console.WriteLine(sayHello);
        sayHello = sayHello.Replace("Hello", "Greetings");
        Console.WriteLine(sayHello);
        Console.WriteLine(sayHello.ToUpper());
        Console.WriteLine(sayHello.ToLower());

        // Do more with strings: Contains method
        string songLyrics = "You say goodbye, and I say hello";
        Console.WriteLine(songLyrics.Contains("goodbye"));
        Console.WriteLine(songLyrics.Contains("greetings"));

        // Challenge 1: Modify the previous example to use StartsWith and EndsWith instead of Contains
        //      Search for "You" or "goodbye" at the beginning of a string.
        Console.WriteLine(songLyrics.StartsWith("You"));
        Console.WriteLine(songLyrics.StartsWith("goodbye"));
        //      Search for "hello" or "goodbye" at the end of a string.
        Console.WriteLine(songLyrics.EndsWith("hello"));
        Console.WriteLine(songLyrics.EndsWith("goodbye"));
    }
	
	public static void NumbersPractice()
	{
        // Explore integer math
        int a = 18;
        int b = 6;
        int c = a + b;
        Console.WriteLine("18 + 6 = " + c);
        c = a - b;
        Console.WriteLine("18 - 6 = " + c);
        c = a * b;
        Console.WriteLine("18 * 6 = " + c);
        c = a / b;
        Console.WriteLine("18 / 6 = " + c);

        // Explore order of operations
        a = 5;
        b = 4;
        c = 2;
        int d;
        d = a + b * c;
        Console.WriteLine("5 + 4 * 2 = " + d);
        d = (a + b) * c;
        Console.WriteLine("(5 + 4) * 2 = " + d);
        d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
        Console.WriteLine("(5 + 4) - 6 * 2 + (12 * 4) / 3 + 12 = " + d);
        a = 7;
        c = 3;
        d = (a + b) / c;
        Console.WriteLine("(7 + 4) / 3 = " + d);

        // Explore integer precision and limits
        a = 7;
        b = 4;
        c = 3;
        d = (a + b) / c;
        int e = (a + b) % c;
        Console.WriteLine($"quotient: {d}");
        Console.WriteLine($"remainder: {e}");
        int max = int.MaxValue;
        int min = int.MinValue;
        Console.WriteLine($"The range of integer is {min} to {max}");
        int what = max + 3;
        Console.WriteLine($"An example of overflow: {what}");

        // Work with the double type
        double aa = 5;
        double bb = 4;
        double cc = 2;
        double dd = (aa + bb) / cc;
        Console.WriteLine(dd);
        aa = 19;
        bb = 23;
        cc = 8;
        dd = (aa + bb) / cc;
        Console.WriteLine(dd);
        double dmax = double.MaxValue;
        double dmin = double.MinValue;
        Console.WriteLine($"The range of double is {dmin} to {dmax}");
        double third = 1.0 / 3.0;
        Console.WriteLine(third);

        // Challenge 2: Try other calculations with large numbers, small numbers, multiplication, and division using the double type.
        aa = -4.5;
        bb = 200;
        cc = 7.62;
        dd = 5.56;
        double ee = (aa + bb) / (cc * dd) - (cc + aa) * bb;
        Console.WriteLine(ee);

        // Work with decimal types
        decimal decmin = decimal.MinValue;
        decimal decmax = decimal.MaxValue;
        Console.WriteLine($"The range of the decimal type is {decmin} to {decmax}");
        double decA = 1.0;
        double decB = 3.0;
        Console.WriteLine(decA / decB);
        decimal decC = 1.0M;
        decimal decD = 3.0M;
        Console.WriteLine(decC / decD);

        // Challenge 3: Now that you've seen the different numeric types, write code that calculates the area of a circle whose radius is 2.50 centimeters. 
        double radius = 2.50;
        double area = Math.PI * radius * radius;
        Console.WriteLine(area);
    }

    public static void BranchesAndLoops()
    {
        // Make decisions using the if statement
        int g = 5;
        int h = 6;
        if (g + h > 10) //true
            Console.WriteLine("The answer is greater than 10.");
        int f = 3;
        if (g + f > 10) //false
            Console.WriteLine("The answer is greater than 10.");

        // Make if and else work together
        if (g + f > 10)
            Console.WriteLine("The answer is greater than 10.");
        else
            Console.WriteLine("The answer is not greater than 10.");
        h = 4;
        if ((g + h + f > 10) && (g == h)) //and
        {
            Console.WriteLine("The answer is greater than 10");
            Console.WriteLine("And the first number is equal to the second");
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine("Or the first number is not equal to the second");
        }
        if ((g + h + f > 10) || (g == h)) //or
        {
            Console.WriteLine("The answer is greater than 10");
            Console.WriteLine("Or the first number is equal to the second");
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine("And the first number is not equal to the second");
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("<<< Strings Practice >>>");
        StringsPractice();
        Console.WriteLine();
        Console.WriteLine("<<< Numbers Practice >>>");
        NumbersPractice();
        Console.WriteLine();
        Console.WriteLine("<<< Branches and Loops >>>");
        BranchesAndLoops();
        Console.WriteLine();
    }
}
