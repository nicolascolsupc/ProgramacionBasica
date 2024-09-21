using System;
using UnityEngine;

public class RepeatNumber : MonoBehaviour
{
    //Escriba un programa en C# que solicite un número (x) y una cantidad (y). Muestre ese número tantas veces como la cantidad (y).
    
    public int x;
    public int y;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            RepeatX();
        }
    }

    private void RepeatX()
    {
        for (int i = 0; i < y; i++)
        {
            Debug.Log("Number: " + x);
        }
    }
}