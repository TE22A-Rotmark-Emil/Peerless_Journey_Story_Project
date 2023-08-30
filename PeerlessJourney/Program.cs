string? name = null;

Random generator = new Random();
int nameRNG = generator.Next(10);
if (nameRNG == 0) {
    string? inName = "Jason";
    name = inName;
}
else if (nameRNG == 1) {
    string? inName = "Jenny";
    name = inName;
}
else if (nameRNG == 2) {
    string? inName = "Fredrick";
    name = inName;
}
else if (nameRNG == 3) {
    string? inName = "Freya";
    name = inName;
}
else if (nameRNG == 4) {
    string? inName = "Gregory";
    name = inName;
}
else if (nameRNG == 5) {
    string? inName = "Gabriella";
    name = inName;
}
else if (nameRNG == 6) {
    string? inName = "Kohl";
    name = inName;
}
else if (nameRNG == 7) {
    string? inName = "Kassie";
    name = inName;
}
else if (nameRNG == 8) {
    string? inName = "Miller";
    name = inName;
}
else if (nameRNG == 9) {
    string? inName = "Maya";
    name = inName;
}

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