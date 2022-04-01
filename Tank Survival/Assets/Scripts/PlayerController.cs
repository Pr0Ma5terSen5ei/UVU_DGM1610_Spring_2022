using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float tankSpeed = 10.0f;
    private float tankRotation = 100.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }
    //Moves player using wasd or arrow keys
    void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * tankSpeed * forwardInput);
        transform.Rotate(Vector3.up, tankRotation * horizontalInput * Time.deltaTime);
    }
}
