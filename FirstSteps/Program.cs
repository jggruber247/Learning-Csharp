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

// Do more with strings: Replace method
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);