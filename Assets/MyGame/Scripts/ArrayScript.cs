using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    public int[] a = { 0, 1, 3, 2 };
    

    // Start is called before the first frame update
    void Start()
    {
        int Summe = a[0] + a[1] + a[3] + a[2];

        Debug.Log(Summe);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
