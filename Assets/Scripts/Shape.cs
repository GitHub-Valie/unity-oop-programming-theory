using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    private string shapeType;
    private Color shapeColor;

    public virtual void DisplayText()
    {
        Debug.Log("Parent class Shape"); // Polymorphism  
        
        // Implement a better way of printing on screen
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
}
