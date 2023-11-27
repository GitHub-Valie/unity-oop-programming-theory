using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LatteMacchiato : Coffee
{
    void Start()
    {
        CoffeeType = "Latte Macchiato";
        Ingredients();
    }
    public override void Ingredients() // Polymorphism
    {
        CoffeeIngredients = new string[] {"Espresso", "Steamed milk", "Milk foam"};
    }
}
