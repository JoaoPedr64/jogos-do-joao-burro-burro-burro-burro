using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operadores : MonoBehaviour
{
    int number1 = 30, number2 = 20;
    string resut;

    void Start()
    {
       resut = number1>number2 ? "sim": "nao";
       Debug.Log(resut);
    }

   
    void Update()
    {
        
    }
}
