using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bisiesto : MonoBehaviour
{
    public int year = 2016;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            year = int.Parse(GetComponent<InputField>().text);
            esBisiesto(year);
        }
    }

    public void esBisiesto(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Debug.Log($"El anyo {year} es bisisto");
                }
                else
                {
                    Debug.Log($"El anyo {year} no es bisisto");
                }
            }
            else
            {
                Debug.Log($"El año {year} es bisisto");
            }
        }
        else
        {
            Debug.Log($"El año {year} no es bisisto");
        }
    }
}
