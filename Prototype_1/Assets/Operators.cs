using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operators : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = 100 + 50;

        int sum1 = 100 + 50;
        int sum2 = sum1 + 250;
        int sum3 = sum2 + sum2;

        x = 10;
        x += 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
