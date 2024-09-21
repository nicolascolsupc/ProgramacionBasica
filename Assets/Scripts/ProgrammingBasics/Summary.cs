using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Summary : MonoBehaviour
{
    // Variable types in C#
    public int age = 25; // Números enteros, positivos o negativos
    private float _price = 12.4f; // Números decimales con precisión limitada (4 bytes de memoria)
    private double _distance = 120000d; // Decimales con mayor precisión que float (8 bytes de memoria)
    private char _singleValue = 'A'; // Un solo carácter (letras, números o símbolos)
    private string _name = "Agustin"; // Cadena de caracteres (texto)

    public int x; // número que se utilizará en condicionales y bucles

    void Start()
    {
        // Conditionals in C#

        // Estructura simple if-else
        if (x == 0)
        {
            Debug.Log("The number is 0");
        }
        else
        {
            if (x > 0)
            {
                Debug.Log("The number is positive");
            }
            else
            {
                Debug.Log("The number is negative");
            }
        }

        switch (x)
        {
            case 2:
                Debug.Log("The number is 2");
                break;
            case > 0:
                Debug.Log("The number is positive");
                break;
            case 0:
                Debug.Log("The number is 0");
                break;
            default:
                Debug.Log("The number is negative");
                break;
        }

        // Loops in C#

        // While loop: repite el bloque mientras la condición sea verdadera
        int i = 1;
        while (i <= 5)
        {
            Debug.Log(i); // Imprime los números del 1 al 5
            i++; // Incrementa i en 1
        }

        // For loop: itera un bloque de código un número definido de veces
        for (int j = 1; j <= 5; j++)
        {
            Debug.Log(j); // Imprime los números del 1 al 5
        }

        // Do-While loop: ejecuta el bloque al menos una vez y lo repite mientras la condición sea verdadera
        do
        {
            Debug.Log("This message will be printed at least once"); // Este mensaje se imprime al menos una vez
        } while (i <= 5); // i ya no es <= 5, así que no entra en el ciclo de nuevo
    }
}
