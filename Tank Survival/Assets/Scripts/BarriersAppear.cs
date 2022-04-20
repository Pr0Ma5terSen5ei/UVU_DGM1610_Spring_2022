using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarriersAppear : MonoBehaviour
{
    [SerializeField] private GameObject[] barriers;
    public void ActivateBarriers()
    {
        barriers[0].SetActive(true);
        barriers[1].SetActive(true);
        barriers[2].SetActive(true);
        barriers[3].SetActive(true);
    }
}
