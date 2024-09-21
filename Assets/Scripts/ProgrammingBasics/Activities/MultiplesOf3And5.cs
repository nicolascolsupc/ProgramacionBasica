using UnityEngine;

public class MultiplesOf3And5 : MonoBehaviour
{
    // Cree un programa en C# que muestre en pantalla los números del 1 al 500 que sean múltiplos de 3 y también múltiplos de 5.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PrintMultiples();
        }
    }

    private void PrintMultiples()
    {
        for (int i = 1; i <= 500; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}