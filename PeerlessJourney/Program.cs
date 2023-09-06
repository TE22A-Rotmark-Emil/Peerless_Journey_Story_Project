﻿using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO.Pipes;

Random generator = new Random();
int nameRNG = generator.Next(10);
string[] names = {"Jason", "Jenny", "Frederick", "Freya", "Gregory", "Gabriella", "Kohl", "Kassie", "Miller Freiburg", "Maya"};
var name = names[nameRNG];
List<string> ExcludeList = new List<String>();
int pis = names.Count();
int pis2 = ExcludeList.Count();
int progression = 0;
int insanity = 0;

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
    ExcludeList.Add(name);
    Thread.Sleep(500);
    while (yN == "no" && pis != pis2) {
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
            int inPis2 = ExcludeList.Count();
            pis2 = inPis2;  
        }
    }
}

if (pis == pis2) {
    Console.WriteLine("Wow, you really are insufferable.");
    Thread.Sleep(2500);
    Console.WriteLine("I gave you");
    Thread.Sleep(500);
    Console.WriteLine("FIF");
    Thread.Sleep(500);
    Console.WriteLine("TEEN");
    Thread.Sleep(500);
    Console.WriteLine("names, and you didn't pick a single one.");
    Thread.Sleep(4000);
    Console.WriteLine("Have fun in your paradise of nameless heathens.");
    Thread.Sleep(4500);
    Console.WriteLine("God damn heretic.");
    Thread.Sleep(1750);
}

else if (yN == "yes") {
    Console.WriteLine("Good.");
    Thread.Sleep(1000);
    Console.WriteLine("Then we shall begin.");
    Thread.Sleep(2000);
}

if (pis != pis2) {
    Console.WriteLine($"You are {name}.");
    Thread.Sleep(1500);
    Console.WriteLine($"You live in the wonderful and mystical land of Birmingham (all rights reserved)");
    Thread.Sleep(3500);
    Console.WriteLine($"Where will you go?");
    Thread.Sleep(1000);
    Console.WriteLine($"1. Nowhere");
    Console.WriteLine($"2. Towards Jacksonville");
    Console.WriteLine($"3. Towards Nairobi");
    Console.WriteLine($"4. Towards Kyiv");
    string Answer1 = Console.ReadLine();
    if (Answer1 == "2" || Answer1 == "3" || Answer1 == "4") {
        if (Answer1 == "2") {
            Console.WriteLine("You start to treck towards Jacksonville.");
            Thread.Sleep(2500);
            Console.WriteLine("...");
            Thread.Sleep(2000);
            Console.WriteLine("Suddenly, you see a small child on the side of the road.");
            Thread.Sleep(2500);
            Console.WriteLine("They seem hurt.");
            Thread.Sleep(1500);
            Console.WriteLine("Do you help them?");
            Thread.Sleep(500);
            
        }
    }
}