using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    string shapeType;
    Color shapeColor;
    public Text textToDisplay;

    /* Encapsulation: turn the variables into Properties by adding get/set accessors */
    public string ShapeType { get { return shapeType; } set { shapeType = value; } }
    public Color ShapeColor { get { return shapeColor; } set { shapeColor = value; } }

    public virtual void DisplayText() // Polymorphism
    {
        Debug.Log("Parent class Shape"); 
        textToDisplay.text = "Shape";
    }
    public void DisplayText(string ShapeType) // Abstraction
    {
        textToDisplay.text = $"{ShapeType}";
    }

    private void OnMouseDown() // Abstraction
    {
        DisplayText();
    }
}
