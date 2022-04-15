using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

while (true)
{
    Console.WriteLine("Please enter the diet that wish to do:");
    DietFactory sample = new DietFactory();
    IBasicDiet diet = sample.GetDiet(Console.ReadLine());
    if (diet != null)
        diet.PrintMenu();
    else
        Console.WriteLine("Unknown diet");
}

public class DietFactory
{
    public IBasicDiet GetDiet(string input)
    {
        if (input == "ve")
        {
            return new VeganDiet();
        }
        else if (input == "vt")
        {
            return new VegeterianDiet();
        }
        else if (input == "om")
        {
            return new OmnivoreDiet();
        }
        return null;
    }
}

public interface IBasicDiet
{
    public void PrintMenu();
}

class VeganDiet : IBasicDiet
{
    public void PrintMenu()
    {
        string[] VeganMenu = { "Fruits", "Vegetables", "Grains", "Nuts" };
        foreach (string v in VeganMenu)
        {
            Console.WriteLine(v);
        }

    }
}

class VegeterianDiet : IBasicDiet
{
    public void PrintMenu()
    {
        string[] VegeterianMenu = { "Fruits", "Vegetables", "Grains", "Nuts", "Dairy", "Eggs"};
        foreach (string v in VegeterianMenu)
        {
            Console.WriteLine(v);
        }

    }
}

class OmnivoreDiet : IBasicDiet
{
    public void PrintMenu()
    {
        string[] OmnivoreMenu = { "Fruits", "Vegetables", "Grains", "Nuts", "Dairy", "Eggs", "Meat", "Fish"};
        foreach (string o in OmnivoreMenu)
        {
            Console.WriteLine(o);
        }

    }
}