using System;
using UnityEngine;

public class DigitCounter : MonoBehaviour
{
    /*
        Cree un programa en C# para calcular cuántos dígitos tiene un número entero positivo.
        Si el usuario ingresa un número entero negativo, el programa debe mostrar un mensaje de advertencia y proceder con el número positivo equivalente.
    */
    
    public int number;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CountDigits();
        }
    }

    private void CountDigits()
    {
        if (number < 0)
        {
            Debug.LogWarning("Negative number detected, using absolute value.");
            number = Mathf.Abs(number);
        }

        var digits = number.ToString().Length;
        Debug.Log("Number of digits: " + digits);
    }
}