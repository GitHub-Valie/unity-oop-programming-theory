using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    public override void DisplayText()
    {
        Debug.Log("Child class Cylinder of parent class Shape"); // Polymorphism

        // Implement a better way of printing on screen
    }
}
