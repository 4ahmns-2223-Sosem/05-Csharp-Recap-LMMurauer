using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variablen : MonoBehaviour
{
    public int Number1 = 2;
    public int Number2 = 5;
    public GameObject GO;
    void Start()
    {
        Debug.Log(Number1 + Number2);
        Debug.Log(GO);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
