using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("DictroyCol")) {

            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("DictroyTrig"))
        {
            Destroy(other.gameObject);
        }
    }
}
