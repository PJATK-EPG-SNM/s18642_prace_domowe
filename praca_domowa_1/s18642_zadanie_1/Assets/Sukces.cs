using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sukces : MonoBehaviour
{

    public GameObject sukces;
    void Start()
    {
        sukces = GameObject.Find("Sukces");
        sukces.gameObject.SetActive(false);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
       

        if (collision.gameObject.name.Equals("Cactonio"))
        {
            sukces.gameObject.SetActive(true);
        }
    }

}
