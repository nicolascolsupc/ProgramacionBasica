using UnityEngine;

public class MaxOfThree : MonoBehaviour
{
    //Escriba un programa en C# que solicite tres números (x, y, z) y muestre el mayor de ellos.

    public float x;
    public float y;
    public float z;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            FindMaxWithIf();
            //FindMax(); Podemos utilizar esta funcion como una opción mas simple
        }
    }

    private void FindMax()
    {
        if (x == y && y == z)
        {
            Debug.Log("all numbers are equal");
            return;
        }
        
        var max = Mathf.Max(x, y, z);
        Debug.Log("The largest number is: " + max);
    }
    
    private void FindMaxWithIf()
    {
        if (x == y && y == z)
        {
            Debug.Log("all numbers are equal");
            return;
        }

        float max;

        if (x > y && x > z)
        {
            max = x;
        }
        else if (y > x && y > z)
        {
            max = y;
        }
        else
        {
            max = z;
        }

        Debug.Log("The largest number is: " + max);
    }
}
