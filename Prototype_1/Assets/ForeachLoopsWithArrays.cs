using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoopsWithArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda", "Tesla"};
        //Console.WriteLine(cars[0]);
        cars[0] = "Opel";
        //Console.WriteLine(cars[0]);
        //Console.WriteLine(cars.Length);
        int[] myNum = {10, 20, 30, 40};
        for (int i = 0; i < cars.Length; i++)
        {
            //Console.WriteLine(cars[i]);
        }
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
