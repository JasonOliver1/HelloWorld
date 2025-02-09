namespace HelloWorld;
using System;
public class Pizza {
    public string Size{
        get;
        set;
    }
    public List<string> Toppings{
        get;
        set;
    }
    public Pizza(string size, List<string> toppings){
        Size = size;
        Toppings = toppings;
    }
    public virtual int Price(){ // virtual accpets overwrites from other classes
        int total;
        int antal_toppings = Toppings.Count;

        if (Size == "normal"){
            total = 20;
            total += antal_toppings * 15;
        }
        else {
            total = 30;
            total += antal_toppings * 18;
        }
        return total;
    }
    public void AddTopping(string addTopping){
        Toppings.Add(addTopping);
    }
    public override string ToString() {
        return $"Pizza Size: {Size}, Toppings: {string.Join(", ", Toppings)}, Price: {Price()}";
    }
    
}





class Program {
    static void Main(string[] args) {
        List<string> normToppings = new() {"tomato", "cheese"}; // giver en list.
        List<string> bigToppings = new() {"tomato", "cheese", "peperroni"};

        Pizza normPizza = new ("normal", normToppings);
        Pizza bigPizza = new ("family ", bigToppings);
        Number1 number1 = new ("", new List<string>());


        Console.WriteLine("Din pizza størrelse er " + normPizza.Size); 
        Console.WriteLine("Toppings: " + string.Join(", ", normToppings));
        // Burger ToString method.
        Console.WriteLine(normPizza.ToString());
        Console.WriteLine(bigPizza.ToString());
        //Ændre pizzaen med mere toppings
        bigPizza.AddTopping("chili");
        Console.WriteLine(bigPizza.ToString());
        // Prøver fixedPrices.cs
        Console.WriteLine(number1.ToString());


    }
}
