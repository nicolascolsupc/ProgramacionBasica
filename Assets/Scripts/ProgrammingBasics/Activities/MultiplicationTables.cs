using System;
using UnityEngine;

public class MultiplicationTables : MonoBehaviour
{
    //Cree un programa en C# que solicite un rango de números al usuario (x,y) y muestre las tablas de multiplicar de x hasta y.
    
    public int x;
    public int y;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PrintTables();
        }
    }

    void PrintTables()
    {
        for (int i = x; i <= y; i++)
        {
            Debug.Log($"Table of {i}");
            for (int j = 1; j <= 10; j++)
            {
                Debug.Log($"{i} x  {j} =  {i * j}");
            }
        }
    }
}