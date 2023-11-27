using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCoffee : Coffee
{
    void Start()
    {
        CoffeeType = "Black Coffee";
        Ingredients();
    }

    public override void Ingredients() // Polymorphism
    {
        CoffeeIngredients = new string[] {"Coffee"};
    }
}
