using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape // Inheritance
{
    void Start()
    {
        ShapeType = "Cylinder";
        ShapeColor = Color.blue;
    }

    public override void DisplayText() // Polymorphism
    {
        Debug.Log($"Child class Cylinder of parent class Shape"); 
        DisplayText(ShapeType);
    }
}
