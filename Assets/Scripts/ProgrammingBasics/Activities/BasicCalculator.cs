using System;
using UnityEngine;

public class BasicCalculator : MonoBehaviour
{
    // Escriba un programa en C# que solicite al usuario dos números y una operación (+,-,x,/) después calcule la operación y muestre el resultado por pantalla.
    // Muestre el texto Caracter no reconocido si el símbolo de la operación es diferente a los anteriores.
    
    public float num1;
    public float num2;
    public char operation;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("First number: " + num1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Second number: " + num2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("Operation: " + operation);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            CalculateResult();
        }
    }

    private void CalculateResult()
    {
        switch (operation)
        {
            case '+':
                Debug.Log($"{num1} + {num2} = {num1 + num2}"); 
                break;
            case '-': 
                Debug.Log($"{num1} - {num2} = {num1 - num2}"); 
                break;
            case 'x': 
                Debug.Log($"{num1} * {num2} = {num1 * num2}"); 
                break;
            case '/':
                if (num2 != 0)
                {
                    Debug.Log($"{num1} / {num2} = {num1 / num2}"); 
                }
                else
                {
                    Debug.LogError("Cannot divide by zero.");
                } 
                break;
            default:
                Debug.LogError("Unrecognized operation.");
                break;
        }
    }
}