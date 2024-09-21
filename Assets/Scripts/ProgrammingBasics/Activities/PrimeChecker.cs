using System;
using UnityEngine;

public class PrimeChecker : MonoBehaviour
{
    //Escriba un programa en C# que solicite al usuario un número entero y responda si es un número primo o no.
    public int number;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CheckPrime();
        }
    }

    private void CheckPrime()
    {
        if (number < 2)
        {
            Debug.Log(number + " is not a prime number.");
            return;
        }

        for (int i = 2; i <= Mathf.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                Debug.Log(number + " is not a prime number.");
                return;
            }
        }

        Debug.Log(number + " is a prime number.");
    }
}