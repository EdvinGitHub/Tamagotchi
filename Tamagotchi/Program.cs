string svar = "";

Tamagorchi tama = new Tamagorchi();
Console.WriteLine("what you´re tamagorchi´S name?");

while (tama.GetAlive() == true)
{
    Console.WriteLine("what do you whant to do teach, feed, play or jerk off");
    tama.PrintStats();
    svar = Console.ReadLine();
    if(svar == "teach")
    {
        Console.WriteLine("What word do you want to teach it?");
        tama.Teach(Console.ReadLine());
    }
    if (svar == "feed")
    {

        tama.Feed();

    }
    // tama.Hunger();
    
    Console.Clear();
}

