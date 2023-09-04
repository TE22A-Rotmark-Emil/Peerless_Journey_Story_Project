using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Security.Cryptography;

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
        yN = inyN;
        Console.WriteLine(yN);
        Console.ReadLine();
        break;
    }
}
Console.WriteLine($"> {yN}");
if (yN == "no") {
    Console.WriteLine("Okay.");
    List<string> ExcludeList = new List<String>();
    ExcludeList.Add(name);
    Thread.Sleep(500);
    while (yN == "no") {
        int inNameRNG = generator.Next(10);
        var inName = names[inNameRNG];
        bool excluded = ExcludeList.Contains(inName);
        while (excluded == true) {
            inNameRNG = generator.Next(10);
            inName = names[inNameRNG];
            excluded = ExcludeList.Contains(inName);
            if (excluded == false) {
                break;
            }
        }
        Console.WriteLine($"Are you okay with the name '{inName}'?");
        string? inRawyN = Console.ReadLine();
        string inyN = inRawyN.ToLower();
        while (inyN != "yes" && inyN != "no") { // this script works perfectly and has no flaws
            Console.WriteLine($"Invalid Response. Answer must be 'yes' or 'no', not '{inyN}'");
            inyN = Console.ReadLine();
            if (inyN == "yes" || inyN == "no") {
                yN = inyN;
                break;
            }
            }
        if (inyN == "no") {
            ExcludeList.Add(inName);    
        }
    }
}
else if (yN == "yes") {
    Console.WriteLine("Good.");
    Thread.Sleep(1000);
    Console.WriteLine("Then we shall begin.");
    Thread.Sleep(2000);
}


Console.WriteLine($"You live in an ancient land called {yN}");