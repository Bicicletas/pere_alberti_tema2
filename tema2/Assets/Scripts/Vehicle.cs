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
    // Variable que guarda si el vehiculo tiene sirena
    [SerializeField] private bool hasSiren = false;
    [SerializeField] private bool isOn = true;






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
        }else if (isOn == false)
        {
            Debug.Log($"{name} hara {sound}");
        }else
        {
            Debug.Log($"{sound} no esta en marcha");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
