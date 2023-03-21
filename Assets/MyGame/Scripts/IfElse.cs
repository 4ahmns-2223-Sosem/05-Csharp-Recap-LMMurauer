using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour
{
    public int Number = 1;
    
    void Start()
    {
        Number++;

        if (Number == 5)
        {
            Debug.Log("Hallo");
        }

        else
        {
            Debug.Log("Else Debug");
        }
    }

    
    void Update()
    {
        
    }
}
