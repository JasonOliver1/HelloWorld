namespace HelloWorld;
using System;

public class Number1:Pizza {
    public Number1() : base("normal", new List<string>{"tomato", "cheese"}) {
    }
    public override int Price() {
            return 45;
        }
}

public class Family:Pizza {
    public Family(string size, List<string> toppings) : base("family", toppings) {
    }

    public override int Price() {
        int total = 20;
        int antal_toppings = Toppings.Count;
        total += antal_toppings * 18;
        return total;
    }

}