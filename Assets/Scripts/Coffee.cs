using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Coffee : MonoBehaviour
{
    string coffeeType; // i.e BlackCoffee, Cappucino ...
    string coffeeSize; // i.e Small
    string[] coffeeIngredients; // i.e Coffee, Milk, Sugar ...
    string coffeeContainer; // i.e Plastic, Paper
    public Text coffeeText;
    public Text coffeeIngredientsText;

    public string CoffeeType { get { return coffeeType; } set { coffeeType = value; } } // Encapsulation
    public string CoffeeSize { get { return coffeeSize; } set { coffeeSize = value; } }
    public string[] CoffeeIngredients { get { return coffeeIngredients; } set { coffeeIngredients = value; }}
    public string CoffeeContainer { get { return coffeeContainer; } set { coffeeContainer = value; } }

    public void DisplayInfo()
    {
        DisplayInfo(CoffeeType);
    }

    public abstract void Ingredients(); // Polymorphism: coffeeIngredients must be overriden because each subclass has its own ingredients

    public void DisplayInfo(string CoffeeType) // Abstraction: instead of copy-pasting this method in all subclasses, write it once in parent class
    {
        // Manages how the coffeeType is displayed regardless of the subclass
        coffeeText.text = $"{CoffeeType}";

        /* If statements to process the display of the few special cases (small size, paper/plastic container) 
        If you have many different properties to process, you'd be better off making this method virtual and overriding it in the appropriate subclasses */
        if (CoffeeSize != null)
        {
            coffeeText.text += $" ({CoffeeSize})";
        }
        if (CoffeeContainer != null)
        {
            coffeeText.text += $" ({CoffeeContainer})";
        }

        // Manages how the contents of string[] coffeIngredients are displayed, regardless of the subclass/child class
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
