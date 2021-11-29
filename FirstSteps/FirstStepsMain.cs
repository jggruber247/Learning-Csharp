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

    }

	public static void Main(string[] args)
    {
        Console.WriteLine("<<<Strings Practice>>>");
        StringsPractice();
        Console.WriteLine();
        Console.WriteLine("<<<Numbers Practice>>>");
        NumbersPractice();
        Console.WriteLine();
    }
}
