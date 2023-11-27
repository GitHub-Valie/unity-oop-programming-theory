using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cappucino : Coffee
{
    void Start()
    {
        CoffeeType = "Cappucino";
        Ingredients();
    }

    public override void Ingredients() // Polymorphism
    {
        CoffeeIngredients = new string[] {"Espresso", "Steamed milk"};
    }
}
