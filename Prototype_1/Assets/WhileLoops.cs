using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while (i < 5)
        {
            //Console.WriteLine(i);
            i++;
        }
        int l = 0;
        do
        {
            //Console.WriteLine(l);
            i++;
        }
        while (l < 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
