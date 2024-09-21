using UnityEngine;

public class DayOfWeek : MonoBehaviour
{
    //Escriba un programa que lea un número del 1 al 7 e imprima el nombre del día correspondiente de la semana.
    
    public int day;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PrintDay();
        }
    }

    private void PrintDay()
    {
        switch (day)
        {
            case 1: 
                Debug.Log("Monday"); 
                break;
            case 2: 
                Debug.Log("Tuesday"); 
                break;
            case 3: 
                Debug.Log("Wednesday"); 
                break;
            case 4: 
                Debug.Log("Thursday"); 
                break;
            case 5:
                Debug.Log("Friday"); 
                break;
            case 6: 
                Debug.Log("Saturday"); 
                break;
            case 7: 
                Debug.Log("Sunday"); 
                break;
            default: 
                Debug.LogError("Invalid day."); 
                break;
        }
    }
}
