using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IrishCoffee : Coffee
{
    void Start()
    {
        CoffeeType = "Irish Coffee";
        Ingredients();
    }

    public override void Ingredients()
    {
        CoffeeIngredients = new string[] {"Coffee", "Whisky", "Sugar", "Cream"};
    }
}
