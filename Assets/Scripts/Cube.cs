using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape // Inheritance
{
    void Start()
    {
        ShapeType = "Cube";
        ShapeColor = Color.red;
    }

    public override void DisplayText() // Polymorphism
    {
        Debug.Log("Child class Cube of parent class Shape"); 
        DisplayText(ShapeType);
    }
}
