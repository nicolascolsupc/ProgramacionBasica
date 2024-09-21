using System;
using UnityEngine;

public class NumberRange : MonoBehaviour
{
    /*
        Cree un programa en C# que solicite al usuario dos números enteros (x, y) y muestre el rango de esos números (los dos incluidos), de tres maneras diferentes:
        Usando la instrucción for.
        Usando la instrucción while.
        Usando la instrucción do while.
    */
    
    public int x;
    public int y;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            RangeFor();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            RangeWhile();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            RangeDoWhile();
        }
    }

    private void RangeFor()
    {
        Debug.Log("Using for:");
        for (int i = x; i <= y; i++)
        {
            Debug.Log(i);
        }
    }

    private void RangeWhile()
    {
        Debug.Log("Using while:");
        int i = x;
        while (i <= y)
        {
            Debug.Log(i); 
            i++;
        }
    }

    private void RangeDoWhile()
    {
        Debug.Log("Using do while:");
        int i = x;
        do
        {
            Debug.Log(i); 
            i++;
        } while (i <= y);
    }
}