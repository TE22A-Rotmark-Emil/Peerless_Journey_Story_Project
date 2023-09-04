Random generator = new Random();
int nameRNG = generator.Next(10);
string[] names = {"Jason", "Jenny", "Frederick", "Freya", "Gregory", "Gabriella", "Kohl", "Kassie", "Miller Freiburg", "Maya"};
var name = names[nameRNG];

Console.WriteLine($"Welcome, User.");
Thread.Sleep(2000);
Console.WriteLine($"Are you okay with the name '{name}'?");
string? RawyN = Console.ReadLine();
string yN = RawyN.ToLower();
while (yN != "yes" && yN != "no") {
    Console.WriteLine($"Invalid Response. Answer must be 'yes' or 'no', not '{yN}'");
    string? inyN = Console.ReadLine();
    if (inyN == "yes" || inyN == "no") {
        inyN = yN;
        break;
    }
}
Console.WriteLine($"> {yN}");
if (yN == "no") {
    Console.WriteLine("Too bad, lmao.");
    Thread.Sleep(500);
}
else if (yN == "yes") {
    Console.WriteLine("Good.");
    Thread.Sleep(1000);
    Console.WriteLine("Then we shall begin.");
    Thread.Sleep(2000);
}

Console.WriteLine($"You live in an ancient land called {yN}");