using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourComponents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Intput.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer> ().material.color = Color.red;
        }
        if (Intput.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer> ().material.color = Color.green;
        }
        if (Intput.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer> ().material.color = Color.blue;
        }
    }
}
