using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    // Variable que guarda el sonido del vehiculo
    [SerializeField] private string sound = "¡Brum, brum!";
    // Variables que guardan el nombre de los vehiculo
    [SerializeField] private string name;
    // Variable que guarda el numero de ruedas
    [SerializeField] private int numberWheels = 4;
    // Variable que indica si el vehiculo tiene sirena
    [SerializeField] private bool hasSiren = false;
    // Variable que indica si el vehiculo esta en marcha
    [SerializeField] private bool isOn = true;
    // Variable que guarda la cantidad de gasolina que tinene los vehiculos
    [SerializeField] private float gasoline;








    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log($"{name} tiene {numberWheels} ruedas y hace {sound}");

        // Variable condicional que guarda si el vehiculo tiene sirena
        if (hasSiren)
        {
            Debug.Log($"{name} tiene sirena");
        }
        else 
        {
            Debug.Log($"{name} no tiene sirena");
        }
        */

        if (isOn)
        {
            Debug.Log($"{sound}");
        }else if (hasSiren == true)
        {
            Debug.Log($"{name} hara {sound} cunado se ponga en marcha");
        }else
        {
            Debug.Log($"{name} no esta en marcha");
        }

        if (gasoline < 10 && isOn == true)
        {
            Debug.Log($"¡A {name} le queda poca gasolina");
            if (hasSiren)
            {
                Debug.Log($"sound");
            }
            else
            {
                Debug.Log($"{name} no tiene sirena");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
