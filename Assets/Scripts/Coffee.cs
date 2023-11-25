using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coffee : MonoBehaviour
{
    string coffeeType;
    string coffeeSize;
    bool isHot; // Display hot/cold type of coffee
    public Text textDisplay;

    public string CoffeeType { get { return coffeeType; } set { coffeeType = value; } }
    public string CoffeeSize { get { return coffeeSize; } set { coffeeSize = value; } }
    public bool IsHot { get { return isHot; } set { isHot = value; } }

    public virtual void DisplayInfo()
    {
        DisplayInfo(CoffeeType);
    }

    public void DisplayInfo(string CoffeeType)
    {
        textDisplay.text = $"{CoffeeType}";
        if (CoffeeSize != null)
        {
            textDisplay.text += $" ({CoffeeSize})";
        }
    }

    private void OnMouseDown()
    {      
        DisplayInfo();
    }
}
