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
int threadSleepfr = 500;
static void Print(string text, int speed = 35){
    foreach (char c in text){
        Console.Write(c);
        System.Threading.Thread.Sleep(speed);
    }
    Console.WriteLine();
}

Console.WriteLine($"Welcome, User.");
Thread.Sleep(threadSleepfr * 4);
Console.WriteLine($"Are you okay with the name '{name}'?");
string? RawyN = Console.ReadLine();
string yN = RawyN.ToLower();
while (yN != "yes" && yN != "no" && yN != "debug" && yN != "debugmiller") {
    Console.WriteLine($"Invalid Response. Answer must be 'yes' or 'no', not '{yN}'");
    string? inyN = Console.ReadLine();
    if (inyN == "yes" || inyN == "no") {
        yN = inyN;
        Console.WriteLine(yN);
        Console.ReadLine();
        break;
    }
}
if (yN == "debug") {
    threadSleepfr = 1;
    name = "Frederick";
}
if (yN == "debugmiller") {
    threadSleepfr = 1;
    name = "Miller Freiburg";
}
Console.WriteLine($"> {yN}");
if (yN == "no") {
    Console.WriteLine("Okay.");
    ExcludeList.Add(name);
    Thread.Sleep(threadSleepfr);
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
    Thread.Sleep(threadSleepfr*5);
    Console.WriteLine("I gave you");
    Thread.Sleep(threadSleepfr);
    Console.WriteLine("FIF");
    Thread.Sleep(threadSleepfr);
    Console.WriteLine("TEEN");
    Thread.Sleep(threadSleepfr);
    Console.WriteLine("names, and you didn't pick a single one.");
    Thread.Sleep(threadSleepfr*8);
    Console.WriteLine("Have fun in your paradise of nameless heathens.");
    Thread.Sleep(threadSleepfr*9);
    Console.WriteLine("God damn heretic.");
    Thread.Sleep(threadSleepfr*3);
}

else if (yN == "yes") {
    Console.WriteLine("Good.");
    Thread.Sleep(threadSleepfr*2);
    Console.WriteLine("Then we shall begin.");
    Thread.Sleep(threadSleepfr*4);
}

if (pis != pis2) {
    Console.WriteLine($"You are {name}.");
    Thread.Sleep(threadSleepfr*3);
    Console.WriteLine($"You live in the wonderful and mystical land of Birmingham (all rights reserved)");
    Thread.Sleep(threadSleepfr*7);
    Console.WriteLine($"Where will you go?");
    Thread.Sleep(threadSleepfr*2);
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
            Thread.Sleep(threadSleepfr*5);
            Console.WriteLine("...");
            Thread.Sleep(threadSleepfr*4);
            Console.WriteLine("Suddenly, you see a small child on the side of the road.");
            Thread.Sleep(threadSleepfr*5);
            Console.WriteLine("They seem hurt.");
            Thread.Sleep(threadSleepfr*3);
            Console.WriteLine("Do you help them?");
            Thread.Sleep(threadSleepfr*2);
            Console.WriteLine("1. Of course! It's a child!");
            Console.WriteLine("2. Check on their injuries, decide a course of action from there.");
            Console.WriteLine("3. Move the child. They are in my way.");
            Console.WriteLine("4. Kill the child.");
            Answer1 = Console.ReadLine();
            if (Answer1 == "1") {
                reputation = reputation+5;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"+5 Rep. You now have {reputation} Reputation.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You tend to the child's wounds, they stare up at you with a confused look on their face.");
                Thread.Sleep(threadSleepfr*7);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"'What's wrong?', you ask.");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(threadSleepfr*5);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("'Nothing. I just didn't expect anyone to help.', they said. 'Who are you?'");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(threadSleepfr*9);
                if (name == "Miller Freiburg") {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'Miller, Miller Freiburg Thompson Carlst Thwernthorp Oculus Tavarnus II.', you command.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(threadSleepfr*10);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("'Um... can I just... call you 'Miller Freiburg' for short?', they ask.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(threadSleepfr*10);
                    Console.WriteLine("You stare up for a while, holding your waists as if to prepare for a heroic speech.");
                    Thread.Sleep(threadSleepfr*8);
                    Console.WriteLine("The child stares back blankly.");
                    Thread.Sleep(threadSleepfr*4);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'No.'");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(threadSleepfr*4);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("'Oh.'");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(threadSleepfr*4);
                    Console.WriteLine("...");
                    Thread.Sleep(threadSleepfr*10);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("'Are... you gonna drag me up?', the child requested, still laying dormant on the floor.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(threadSleepfr*12);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'Okay', you relented. You reach out a hand and drag the child up, meeting their weight with an accidental headbutt.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(threadSleepfr*13);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("'Ow...'");
                    Thread.Sleep(threadSleepfr*4);
                    Console.WriteLine("'So... where are you going, then?', the child asked.");
                    Thread.Sleep(threadSleepfr*8);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("'I forgot.', you tell the child. 'Bye.' You turn around and journey home to your humble abode.");
                    Thread.Sleep(threadSleepfr*12);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("The child just stands there in confusion.");
                    Thread.Sleep(threadSleepfr*6);
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"'{name}, {name} Smith.', you reach out your hand. 'And you?'");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(threadSleepfr*6);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("'Charlie', they respond. Their hand reaching out to meet yours.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(threadSleepfr*6);
                    Console.WriteLine("You drag them up from the floor. You and Charlie continue the treck towards Jacksonville.");
                    Thread.Sleep(threadSleepfr*8);
                    Console.WriteLine("...");
                    Thread.Sleep(threadSleepfr*10);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("'Hey... where are we even going, exactly?', said Charlie");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(threadSleepfr*6);
                    Console.WriteLine("You stop abruptly, scratching your head and staring blankly at Charlie.");
                    Thread.Sleep(threadSleepfr*8);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Er, well...");
                    Thread.Sleep(threadSleepfr*2);
                    Console.WriteLine("1 --> 'I'm off to visit family in Jacksonville.'");
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
                    while (Answer2 != "1" && Answer2 != "2" && Answer2 != "3") {
                        Console.WriteLine("Invalid answer. Please type 1, 2, or 3.");
                        string rawInAnswer2 = Console.ReadLine();
                        string inAnswer2 = rawInAnswer2.ToLower();
                        if (inAnswer2 == "one") {
                            inAnswer2 = "1";
                        }
                        else if (inAnswer2 == "two") {
                            inAnswer2 = "2";
                        }
                        else if (inAnswer2 == "three") {
                            inAnswer2 = "3";
                        }
                        if (inAnswer2 == "1" || inAnswer2 == "2" || inAnswer2 == "3") {
                            Answer2 = inAnswer2;
                            break;
                        }
                    }
                    if (Answer2 == "1" || Answer2 == "2") {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"'Jacksonville? {name}, you do know that Jacksonville is across the Atlantic Ocean, right?', said Charlie");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(threadSleepfr*10);
                        Console.WriteLine("You stop abruptly, staring blankly.");
                        Thread.Sleep(threadSleepfr*8);
                        Console.WriteLine("You open your mouth as to speak, but stop before even a husk of noise can escape.");
                        Thread.Sleep(threadSleepfr*10);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"'{name}'?");
                        Thread.Sleep(threadSleepfr*4);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("'I have to go. Something really important came up.', you tell Charlie, and immediately start running back.");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Thread.Sleep(threadSleepfr*12);
                        Console.WriteLine($"'{name}?!', Charlie screams after you.");
                        Thread.Sleep(threadSleepfr*4);
                        Console.WriteLine("'You do know where Jacksonville (...)'");
                        Thread.Sleep(threadSleepfr*4);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("The voice blends in with the surrounding noise, becoming naught but a whisper in the sea of voices.");
                        Thread.Sleep(threadSleepfr*12);
                        reputation = reputation-1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"-1 Rep. You now have {reputation} Reputation.");
                        Thread.Sleep(threadSleepfr*4);
                    }
                    if (Answer2 == "3") {
                        reputation = reputation-1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"-1 Rep. You now have {reputation} Reputation.");
                        Thread.Sleep(threadSleepfr*4);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("'Oh... okay.', says Charlie.");
                        Thread.Sleep(threadSleepfr*6);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("You both continue walking, passing by a small shop by the side of the road.");
                        Thread.Sleep(threadSleepfr*10);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You have 5 gold.");
                        Thread.Sleep(threadSleepfr*4);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        insanity++;
                        Console.WriteLine($"Insanity increased to {insanity}.");
                        Thread.Sleep(threadSleepfr*2);
                        Console.BackgroundColor = ConsoleColor.White;
                        Print("Inside the store lay a disheveled man, he stares blankly, his eyes illuminating with a sickly shade of red.");
                        Thread.Sleep(threadSleepfr*2);
                        Print($"'{name}? Oh, it has been too long,' the man smiles unnaturally, his cheeks twisting in a deliberate, uncanny fashion.");
                        Thread.Sleep(threadSleepfr*2);
                        Print($"'Don't you recognize me, {name}?'");
                        Thread.Sleep(threadSleepfr*2);
                        Print($"'It's me. It's your best friend.");
                        Thread.Sleep(threadSleepfr*2);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("Wake ");
                        Thread.Sleep(threadSleepfr*2);
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write("Up.");
                        Thread.Sleep(threadSleepfr*2);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("");
                        Print("You shake your head.");
                        Thread.Sleep(threadSleepfr*2);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("'Is your friend alright?', in front of you lay a disheleved man, staring at Charlie with a patient smile.");
                        Thread.Sleep(threadSleepfr*12);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"'{name}! {name}, you're okay! Thank goodness,' Charlie sat hunched up next to you, tears in their eyes. ");
                        Thread.Sleep(threadSleepfr*12);
                        Console.WriteLine($"They wipe their tears with their sleeve and clear their throat. 'Um, were you gonna buy anything?'");
                        Thread.Sleep(threadSleepfr*11);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("...");
                        Thread.Sleep(threadSleepfr*2);
                        Console.WriteLine("1 --> Sure, I don't see why not.");
                        Console.WriteLine("2 --> I don't have the money.");
                        Console.WriteLine("3 --> I don't trust that man.");
                        string RawAnswer3 = Console.ReadLine();
                        string Answer3 = RawAnswer3.ToLower();
                        if (Answer3 == "one") {
                            Answer3 = "1";
                        }
                        else if (Answer3 == "two") {
                            Answer3 = "2";
                        }
                        else if (Answer3 == "three") {
                            Answer3 = "3";
                        }
                        while (Answer3 != "1" && Answer3 != "2" && Answer3 != "3") {
                            Console.WriteLine("Invalid answer. Please type 1, 2, or 3.");
                            string rawInAnswer3 = Console.ReadLine();
                            string inAnswer3 = rawInAnswer3.ToLower();
                            if (inAnswer3 == "one") {
                                inAnswer3 = "1";
                            }
                            else if (inAnswer3 == "two") {
                                inAnswer3 = "2";
                            }
                            else if (inAnswer3 == "three") {
                                inAnswer3 = "3";
                            }
                            if (inAnswer3 == "1" || inAnswer3 == "2" || inAnswer3 == "3") {
                                Answer3 = inAnswer3;
                                break;
                            }
                        }
                        if (Answer3 == "1") {
                            reputation+=5;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"+5 Rep. You now have {reputation} Reputation.");
                            Thread.Sleep(threadSleepfr*4);
                        }
                    }
                }
            }
        }
    }
}

if (reputation == 5 || name == "Miller Freiburg") {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("You close the door to your humble abode.");
    Thread.Sleep(threadSleepfr*4);
    Console.WriteLine("Your journey's finally come to an end.");
    Thread.Sleep(threadSleepfr*4);
    Console.WriteLine("Unluckily, you didn't manage to reach your location.");
    Thread.Sleep(threadSleepfr*4);
    Console.WriteLine("But, perhaps the true Journey were the friends we made along the way.");
    Thread.Sleep(threadSleepfr*4);
    Console.WriteLine("Or maybe not.");
    Thread.Sleep(threadSleepfr*4);
    Console.WriteLine("Maybe you're just stupid.");
    Thread.Sleep(threadSleepfr*4);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("DESTINATION OUT OF REACH ENDING");
    Console.ReadLine();
}