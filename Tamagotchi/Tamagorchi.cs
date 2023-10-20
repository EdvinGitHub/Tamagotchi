
using System.Runtime.CompilerServices;

public class Tamagorchi
{
    private bool isAlive = true;
    private int hunger = 1;

    private int boredom = 4;
    private List<string> words = new List<string>() {"hello"};

    public string name = "";
    private Random generator;

    public void Feed()
    {   
        hunger -= 4;
        
    
    }

    public void Hi()
    {
        
    }
    public void PrintStats()
    {
        Console.WriteLine(hunger);
        Console.WriteLine(boredom);
        if(boredom <= 0 && hunger <= 0)
        { isAlive = false;}
    }
    public void Teach(string word)
    {
        words.Add(word);
        Console.WriteLine("Now your tamagotchi knows these words:");
        Console.WriteLine(String.Join(", ", words));
        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        boredom =-2;
       
    }
    public void Tick()
    {

    }
    
    public bool GetAlive()
    {
        return true;
    }
    
}