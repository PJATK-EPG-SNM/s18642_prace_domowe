using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monety : MonoBehaviour
{
    public GameObject monety;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(monety);
    }

}
