using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool coolDown = false;
    private float timerCoolDown = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !coolDown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            coolDown = true;
            Invoke(nameof(EndCooldown), timerCoolDown);
        }
    }
    void EndCooldown()
    {
        coolDown = false;
    }
}
