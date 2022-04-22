using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public int tankSpeed;

     public void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * tankSpeed * forwardInput);
        transform.Rotate(Vector3.up, tankRotation * horizontalInput * Time.deltaTime);
    }
}
