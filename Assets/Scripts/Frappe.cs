using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frappe : Coffee
{
    void Start()
    {
        CoffeeType = "Frappé";
        CoffeeContainer = "Plastic";
        Ingredients();
    }

    public override void Ingredients()
    {
        CoffeeIngredients = new string[] {"Coffee", "Sugar", "Cream", "Ice"};
    }
}
