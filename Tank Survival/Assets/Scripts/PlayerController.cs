using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float tankSpeed = 5.0f;
    private float tankRotation = 100.0f;
    public float playerHealth = 10;
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
        if (playerHealth == 0)
        {
            Debug.Log("Game Over!");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            playerHealth -= 1;
        } else if (collision.gameObject.CompareTag("Enemy"))
        {
            playerHealth -= 1;
        } else if (collision.gameObject.CompareTag("Heal"))
        {
            playerHealth += 3;
            if(playerHealth > 10)
            {
                playerHealth = 10;
            }
        }
        
    }
}
