using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape // Inheritance
{
    void Start()
    {
        ShapeType = "Sphere";
        ShapeColor = Color.green;
    }

    public override void DisplayText() // Polymorphism
    {
        Debug.Log("Child class Sphere of parent class Shape"); 
        DisplayText(ShapeType);
    }
}
