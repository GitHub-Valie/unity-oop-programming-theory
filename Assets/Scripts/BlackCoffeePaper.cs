using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCoffeePaper : BlackCoffee
{
    void Start()
    {
        CoffeeType = "Black Coffee";
        CoffeeContainer = "Paper";
        Ingredients();
    }
}
