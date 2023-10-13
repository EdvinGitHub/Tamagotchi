
int hp = 1;
string svar = "";

Tamagorchi tama = new Tamagorchi();
Console.WriteLine("what you´re tamagorchi´S name?");

while (hp > 0)
{
    Console.WriteLine("what do you whant to do teach, feed, play och jerk off");
    svar = Console.ReadLine();
    if (svar == "Feed")
    {

        tama.Feed();

        Console.WriteLine(tama);
    }
    // tama.Hunger();
    tama.PrintStats();
    
    Console.Clear();
}

