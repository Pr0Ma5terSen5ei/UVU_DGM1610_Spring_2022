using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 5.0f;
    private Rigidbody enemyRb;
    private int enemyHealth = 3;
    Transform targetTransform;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        targetTransform = GameObject.FindWithTag("Player").GetComponent<Transform>();
        Vector3 playerLocation = Vector3.MoveTowards(transform.position, targetTransform.position, speed * Time.deltaTime);
        enemyRb.MovePosition(playerLocation);
        transform.LookAt(playerLocation);
        if(enemyHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            enemyHealth -= 1;
        }
        
    }

}
