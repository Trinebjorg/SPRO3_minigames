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
        if(collision.gameObject.name == "Charmander_trigger")
        {
            Destroy(gameObject);
            Debug.Log("First");
        }
        //Destroy(collision.collider.gameObject);
        //Destroy(gameObject);
    }

    public void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
        Debug.Log("Second");
    }
}
