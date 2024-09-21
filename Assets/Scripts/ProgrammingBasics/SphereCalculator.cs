using UnityEngine;

public class SphereCalculator : MonoBehaviour
{
    // Declaramos la variable del radio como pública para poder asignarle un valor en Unity.
    public float radio;

    void Update()
    {
        // Presionamos la tecla '1' para calcular la superficie y el volumen de la esfera
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CalculateSurfaceAndVolume();
        }
    }

    // Función que calcula la superficie y el volumen de la esfera
    private void CalculateSurfaceAndVolume()
    {
        if (radio <= 0)
        {
            Debug.LogError("The radius must be a positive number.");
            return;
        }

        // Fórmula para la superficie de la esfera
        var surface = 4 * Mathf.PI * Mathf.Pow(radio, 2);

        // Fórmula para el volumen de la esfera
        var volume = (4f / 3f) * Mathf.PI * Mathf.Pow(radio, 3);

        // Mostrar los resultados en la consola
        Debug.Log("Surface of the sphere: " + surface);
        Debug.Log("Volume of the sphere: " + volume);
    }
}

