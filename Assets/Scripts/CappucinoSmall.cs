using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CappucinoSmall : Cappucino
{
    void Start()
    {
        CoffeeType = "Cappucino";
        CoffeeSize = "Small";
        Ingredients(); // Inheritance: Call method inherited from Cappucino
    }

    /* Because CappucinoSmall has the same ingredients as a regular Cappucino 
    (parent class), no need to override the Ingredients() method here */
}
