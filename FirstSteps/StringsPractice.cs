using System;
// Following along with the Microsoft tutorials for C# at docs.microsoft.com
public class StringsPractice
{
    public StringsPractice()
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
}