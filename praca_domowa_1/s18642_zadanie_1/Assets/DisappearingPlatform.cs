using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatform : MonoBehaviour
{
   
    IEnumerator OnCollisionEnter2D(Collision2D collision)
    {

        yield return new WaitForSeconds(2);
        Destroy(gameObject);

    }
}
