using System.Diagnostics.CodeAnalysis;
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
int reputation = 0;
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
        if (inyN == "yes") {
            yN = inyN;
            name = inName;
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
            reputation = reputation+1;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"+1 Rep. You now have {reputation} Reputation.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You start to treck towards Jacksonville.");
            Thread.Sleep(2500);
            Console.WriteLine("...");
            Thread.Sleep(2000);
            Console.WriteLine("Suddenly, you see a small child on the side of the road.");
            Thread.Sleep(2500);
            Console.WriteLine("They seem hurt.");
            Thread.Sleep(1500);
            Console.WriteLine("Do you help them?");
            Thread.Sleep(1000);
            Console.WriteLine("1. Of course! It's a child!");
            Console.WriteLine("2. Check on their injuries, decide a course of action from there.");
            Console.WriteLine("3. Move the child. They are in my way.");
            Console.WriteLine("4. Kill the child.");
            Answer1 = Console.ReadLine();
            if (Answer1 == "1") {
                reputation = reputation+50;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"+50 Rep. You now have {reputation} Reputation.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You tend to the child's wounds, they stare up at you with a confused look on their face.");
                Thread.Sleep(3500);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"'What's wrong?', you ask.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(2500);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'Nothing. I just didn't expect anyone to help.', they said. 'Who are you?'");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(4500);
                if (name == "Miller Freiburg") {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'Miller, Miller Freiburg Thompson Carlst Thwernthorp Oculus Tavarnus II.', you command.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(5000);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("'Um... can I just... call you 'Miller Freiburg' for short?', they ask.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(5000);
                    Console.WriteLine("You stare up for a while, holding your waists as if to prepare for a heroic speech.");
                    Thread.Sleep(4000);
                    Console.WriteLine("The child stares back blankly.");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'No.'");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("'Oh.'");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(2000);
                    Console.WriteLine("...");
                    Thread.Sleep(5000);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("'Are... you gonna drag me up?', the child requested, still laying dormant on the floor.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(6000);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'Okay', you relented. You reach out a hand and drag the child up, meeting their weight with an accidental headbutt.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(6500);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("'Ow...'");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(2000);
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"'{name}, {name} Smith.', you reach out your hand. 'And you?'");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("'Charlie', they respond. Their hand reaching out to meet yours.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(3000);
                    Console.WriteLine("You drag them up from the floor. You and Charlie continue the treck towards Jacksonville.");
                    Thread.Sleep(4000);
                    Console.WriteLine("...");
                    Thread.Sleep(5000);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("'Hey... where are we even going, exactly?', said Charlie");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(3000);
                    Console.WriteLine("You stop abruptly, scratching your head and staring blankly at Charlie.");
                    Thread.Sleep(4000);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Er, well...");
                    Thread.Sleep(1000);
                    Console.WriteLine("1 --> 'I'm off to visit family at Jacksonville.'");
                    Console.WriteLine("2 --> 'I'm trying to get to Jacksonville as soon as possible.'");
                    Console.WriteLine("3 --> 'That's none of your business.'");
                    string RawAnswer2 = Console.ReadLine();
                    string Answer2 = RawAnswer2.ToLower();
                    if (Answer2 == "one") {
                        Answer2 = "1";
                    }
                    else if (Answer2 == "two") {
                        Answer2 = "2";
                    }
                    else if (Answer2 == "three") {
                        Answer2 = "3";
                    }
                    if (Answer2 == "1" || Answer2 == "2") {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"'Jacksonville? {name}, you do know that Jacksonville is across the Atlantic Ocean, right?', said Charlie");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(3000);
                        Console.WriteLine("You stop abruptly, staring blankly.");
                        Thread.Sleep(4000);
                        Console.WriteLine("You open your mouth as to speak, but stop before even a husk of noise can escape.");
                        Thread.Sleep(5000);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"{name}?");
                        Thread.Sleep(3000);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("'I have to go. Something really important came up.', you tell Charlie, and immediately start running back.");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Thread.Sleep(6000);
                        Console.WriteLine($"'{name}?!', Charlie screams after you.");
                        Thread.Sleep(2000);
                        Console.WriteLine("'You do know where Jacksonville (...)'");
                        Thread.Sleep(2000);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("The voice blends in with the surrounding noise, becoming naught but a whisper in the sea of voices.");
                        Thread.Sleep(6000);
                        reputation = reputation-1;
                    }
                }
            }
        }
    }
}

if (reputation == 50) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("You close the door to your humble abode.");
    Thread.Sleep(2000);
    Console.WriteLine("Your journey's finally come to an end.");
    Thread.Sleep(2000);
    Console.WriteLine("Unluckily, you didn't manage to reach your location.");
    Thread.Sleep(2000);
    Console.WriteLine("But, perhaps the true Journey were the friends we made along the way.");
    Thread.Sleep(2000);
    Console.WriteLine("Or maybe not.");
    Thread.Sleep(2000);
    Console.WriteLine("Maybe you're just stupid.");
    Thread.Sleep(2000);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("DESTINATION OUT OF REACH ENDING");
    Console.ReadLine();
}