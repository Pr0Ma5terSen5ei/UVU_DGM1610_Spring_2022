using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsWithArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            //Console.WriteLine(i);
        }
        for (int i = 0; i <= 10; i = i + 2)
        {
            //Console.WriteLine(i);
        }
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda", "Tesla"};
        foreach (string i in cars)
        {
            //Console.WriteLine(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
