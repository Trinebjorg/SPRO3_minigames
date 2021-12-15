using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountCollision : MonoBehaviour
{
    int count = 0;
    public void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
        count++;
        Debug.Log("Count" + count);
    }

}

