using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNum : MonoBehaviour
{
    private int RanNum;
    private int myNum;
    private int Counter;

    // Start is called before the first frame update
    void Start()
    {
        RanNum = Random.Range(0, 11);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            myNum = int.Parse(GetComponent<InputField>().text);
            CompareToRandomNumber(myNum);
            Counter++;
        }
    }

    public void CompareToRandomNumber(int userNum)
    {
        if (userNum < RanNum)
        {
            Debug.Log("El numero que yo habia pensado era mas grande");
        }
        if (userNum > RanNum)
        {
            Debug.Log("El numero que yo habia pensado era mas pequeño");
        }
        if (userNum == RanNum)
        {
            Debug.Log($"¡Has acertado! El numero que habia pensado era {RanNum}");
            Debug.Log($"Has utilizado {Counter} intentos");
        }
    }
}
