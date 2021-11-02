    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
    public int playerAge = 35;
    private float playerSpeed = 5.25f;
    public string playerName = "Pere";
    [SerializeField] private bool gameOver;

    public int x = 5;
    public int y = 2;

    public float a = 5f;
    public float b = 2f;
    
    public int playerAge = 35;

    public int x = 5;
    public int y = 2;

    public bool isRaining = false;

    public bool isCold;
    */

    public string hello;

    public int number1;
    public int number2;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Multiply(number1, number2));


        // HelloWorld();


        // hello = GetHello();
        // Debug.Log(hello);

        // Debug.Log(GetHello());

        // transform.position = new Vector3(0, 0, 0);
        // transform.position = Vector3.zero;
        // Debug.Log(transform.position);

        /*
        if (isRaining)
        {
            if (isCold == true)
            {
                Debug.Log("Lleva paraguas y sudadera");
            }else
            {
                Debug.Log("Lleva paraguas");
            }
        }
        else
        {
            if (isCold == true)
            {
                Debug.Log("Lleva sudadera");
            }
            else
            {
                Debug.Log("Disfruta del dia");
            }
        }

        Debug.Log($"Suma: {x} + {y} = {x + y}"); 
        Debug.Log("Resta: " + x + " - " + y + " = " + (x - y));
        Debug.Log(string.Format("Producto: {0} * {1} = {2}", x, y, x * y));
        Debug.Log(string.Format("Division: {0} / {1} = {2}", x, y, x / y));

         if (playerAge >= 18)
        {
            Debug.Log("Eres mayor de edad");
        }
        else if (playerAge >= 13)
        {
            Debug.Log("Eres adolescente");
        } 
        else
        {
            Debug.Log("Eres un niño");
        }

        if (x == 2 || y <= 5)
        {
            Debug.Log("Verdadero");
        }
        else
        {
            Debug.Log("Falso");
        }
       */




    }

    // Update is called once per frame
    void Update()
    {

        // Debug.Log(transform.position);

        MovementToDirection(KeyCode.D, Vector3.right);
        MovementToDirection(KeyCode.A, Vector3.left);
        MovementToDirection(KeyCode.Space, Vector3.up);
        MovementToDirection(KeyCode.LeftShift, Vector3.down);
        MovementToDirection(KeyCode.W, Vector3.forward);
        MovementToDirection(KeyCode.S, Vector3.back);

        HorizontalScale(KeyCode.Q, Vector3.right);
        HorizontalScale(KeyCode.E, Vector3.left);
        HorizontalScale(KeyCode.R, Vector3.up);
        HorizontalScale(KeyCode.F, Vector3.down);
        HorizontalScale(KeyCode.C, Vector3.one);
        HorizontalScale(KeyCode.V, -Vector3.one);

        RotationToDirection(KeyCode.RightArrow, new Vector3(0, 10, 0));
        RotationToDirection(KeyCode.LeftArrow, new Vector3(0, -10, 0));
        RotationToDirection(KeyCode.UpArrow, new Vector3(10, 0, 0));
        RotationToDirection(KeyCode.DownArrow, new Vector3(-10, 0, 0));



        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.Euler(0, 10, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation *= Quaternion.Euler(0, -10, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.rotation *= Quaternion.Euler(10, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.rotation *= Quaternion.Euler(-10, 0, 0);
        }
    }

    public void HelloWorld()
    {
        Debug.Log("¡Hola, mundo!");
    }

    public string GetHello()
    {
        return "¡Hola!";
    }

    public void MovementToDirection(KeyCode key, Vector3 direction)
    {
        if (Input.GetKeyDown(key))
        {
            transform.position += direction;
        }
    }

    public void HorizontalScale(KeyCode key, Vector3 scale)
    {
        if (Input.GetKeyDown(key))
        {
            transform.localScale += scale;
        }
    }

    public void RotationToDirection(KeyCode key, Vector3 axis)
    {
        if (Input.GetKeyDown(key))
        {
            transform.rotation *= Quaternion.Euler(axis);
        }
    }

    public int Multiply(int num1, int num2)
    {
        int resultado = num1 * num2;
        Debug.Log($"{number1} * {number2} = {resultado}");
        return resultado;
    }

    


}
