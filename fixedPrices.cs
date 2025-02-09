namespace HelloWorld;
using System;
using System.Drawing;

public class Number1:Pizza {
    public Number1(string size, List<string> toppings) : base(size, toppings) {
    
        if (string.IsNullOrEmpty(size)){
            Size = "normal";
        }
        if (Toppings.Count==0){
            Toppings = new() {"tomato", "cheese"};
        }
    }
    public override int Price() {
            return 45;
        }
}