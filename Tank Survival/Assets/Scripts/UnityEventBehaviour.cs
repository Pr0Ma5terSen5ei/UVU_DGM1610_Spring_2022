using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventBehaviour : MonoBehaviour
{
    
    [SerializeField] private UnityEvent m_MyEvent;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            m_MyEvent.Invoke();
        }
    }
}
