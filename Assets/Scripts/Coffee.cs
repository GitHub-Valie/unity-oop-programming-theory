using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Coffee : MonoBehaviour
{
    string coffeeType;
    string coffeeSize;
    string[] coffeeIngredients;
    public Text coffeeText;
    public Text coffeeIngredientsText;

    public string CoffeeType { get { return coffeeType; } set { coffeeType = value; } } // Encapsulation
    public string CoffeeSize { get { return coffeeSize; } set { coffeeSize = value; } }
    public string[] CoffeeIngredients { get { return coffeeIngredients; } set { coffeeIngredients = value; }}

    public void DisplayInfo()
    {
        DisplayInfo(CoffeeType);
    }

    public abstract void Ingredients(); // Polymorphism: coffeeIngredients must be overriden because each subclass has its own ingredients

    public void DisplayInfo(string CoffeeType) // Abstraction
    {
        // Manages how the coffeeType is displayed regardless of the subclass
        coffeeText.text = $"{CoffeeType}";
        if (CoffeeSize != null)
        {
            coffeeText.text += $" ({CoffeeSize})";
        }

        // Manages how the contents of string[] coffeIngredients are displayed regardless of the subclass
        coffeeIngredientsText.text = "";
        if (CoffeeIngredients != null)
        {
            foreach (string ingredient in CoffeeIngredients)
            {
                coffeeIngredientsText.text += $" {ingredient}\n"; // \n : Line break
            }
        }
    }
}
