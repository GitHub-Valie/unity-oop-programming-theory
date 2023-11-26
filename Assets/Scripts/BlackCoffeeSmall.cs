using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCoffeeSmall : BlackCoffee
{
    void Start()
    {
        CoffeeType = "Black Coffee";
        CoffeeSize = "Small";
        Ingredients(); // Call method inherited from BlackCoffee
    }

    /* Because a BlackCoffeeSmall has the same ingredients as a regular BlackCoffee 
    (parent class), no need to override the Ingredients() method here */
}
