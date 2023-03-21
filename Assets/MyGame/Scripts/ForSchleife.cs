using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForSchleife : MonoBehaviour
{
    public int Number = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 5; i++)
        {
            Number = i;
        }

        Debug.Log(Number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
