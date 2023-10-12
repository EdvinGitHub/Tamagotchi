
int hp = 1;
string svar = "";

Tamagorchi tama = new Tamagorchi();
Console.WriteLine("what you´r tamagorchi´S name?");

while (hp > 0)
{
    Console.WriteLine("what do you whant to do Teach, feed, play and ");
    svar = Console.ReadLine();
    if (svar == "Feed")
    {

        tama.Feed();

        Console.WriteLine(tama);
    }
    tama.Hunger();


}

