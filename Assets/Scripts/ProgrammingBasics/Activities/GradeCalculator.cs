using System;
using UnityEngine;

public class GradeCalculator : MonoBehaviour
{
    
    /*
        Cree un programa en C# que calcule la nota de un alumno a partir de un número entero. Solicite al usuario un número (x) y responda lo siguiente:
            10 - Matrícula de honor
            9 - Sobresaliente
            7.8 - Notable
            6 - Bien
            5 - Aprobado
            0.4 - Suspenso
        Use la instrucción switch, break y default de C#.
     */
    public int grade;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CalculateGrade();
        }
    }

    private void CalculateGrade()
    {
        switch (grade)
        {
            case 10:
                Debug.Log("Matrícula de honor"); 
                break;
            case 9: 
                Debug.Log("Sobresaliente"); 
                break;
            case 7 or 8: 
                Debug.Log("Notable"); 
                break;
            case 6: 
                Debug.Log("Bien"); 
                break;
            case 5: 
                Debug.Log("Aprobado");
                break;
            default:
                if (grade >= 0 && grade < 5) //(grade is >= 0 and < 5) tambien se puede escribir de esta manera
                {
                    Debug.Log("Suspenso");
                }
                else
                {
                    Debug.LogError("Invalid grade.");
                }
                break;
        }
    }
}