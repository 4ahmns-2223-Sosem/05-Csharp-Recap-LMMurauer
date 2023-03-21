using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Methode : MonoBehaviour
{
    public int A = 1;
    public int B = 1;
    public int Result;
    // Start is called before the first frame update
    void Start()
    {
        Zahl();
    }

    public int Zahl()
    {
        Result = A += B;
        Debug.Log(Result);
        return Result;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
