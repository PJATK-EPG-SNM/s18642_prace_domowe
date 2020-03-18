using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sukces : MonoBehaviour
{

    public GameObject sukces;
    void Start()
    {
        sukces = GameObject.Find("sukces");
        sukces.gameObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sukces.gameObject.SetActive(true);
        }
    }

}
