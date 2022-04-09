using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireProjectile : MonoBehaviour
{
    public float rateOfFire = 5;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rateOfFire -= Time.deltaTime;

        if (rateOfFire < 0)
        {
            rateOfFire = 5;
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}
