using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaberControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Bulbasaur_collison")
        {
            Destroy(gameObject);
            Debug.Log("Saur is here");
        }
        //Destroy(collision.collider.gameObject);
        //Destroy(gameObject);
    }

    public void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
        Debug.Log("No here");
    }
}
