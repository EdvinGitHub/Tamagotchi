﻿using System.Diagnostics;

string svar = "";
int ba;

Tamagorchi tama = new Tamagorchi();
Console.WriteLine("what you´re tamagorchi´S name?");
tama.name = Console.ReadLine(); 

while (tama.GetAlive() == true)
{
   ba = Random.Shared.Next(2);
    if(ba == 0)
    {
        tama.Hi();
    }
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
    if (svar == "jerk off")
    {
        Console.WriteLine("wtf are you doing?"); 
       
    }
    tama.Tick();
    // tama.Hunger();
    Console.WriteLine("press ENTER to continue");
    Console.ReadLine();
    Console.Clear();
}
if (tama.GetAlive() == false)
{
    Console.WriteLine("you lost");
    Console.ReadLine();
}

