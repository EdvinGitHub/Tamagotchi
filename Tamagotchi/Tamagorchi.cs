
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
        hunger -= 3;
    }
    public void ReduceBordom()
    {
        boredom -= 3;
    }
    public void Hi()
    {
        Console.WriteLine(words[Random.Shared.Next(words.Count)]);
    }
    public void PrintStats()
    {
        Console.WriteLine(hunger);
        Console.WriteLine(boredom);
        // if(boredom <= 0 && hunger <= 0)
        // { isAlive = false;}
    }
    public void Teach(string word)
    {
        words.Add(word);
        Console.WriteLine("Now your tamagotchi knows these words:");
        Console.WriteLine(String.Join(", ", words));
      
        ReduceBordom();
       
    }
    public void Tick()
    {
        hunger += 1;
        boredom += 2;
        if (hunger >= 10)
        {
            isAlive = false;
        }
        if (boredom >= 10)
        {
            isAlive = false;
        }
    }
    
    public bool GetAlive()
    {
        return true;
    }
    
}