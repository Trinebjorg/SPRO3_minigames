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
    public void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject);
        Debug.Log("Second");

        if (col.CompareTag("GameObject1"))
        {
            Destroy(col.gameObject);
        }
    }

    /*
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Charmander_trigger")
        {
            Destroy(gameObject);
            Debug.Log("First");
        }
        //Destroy(collision.collider.gameObject);
        //Destroy(gameObject);
        if (collision.gameObject.name == "GameObject1")
        {
            Destroy(gameObject);
            Debug.Log("1");
        }
        if (collision.gameObject.name == "GameObject2")
        {
            Destroy(gameObject);
            Debug.Log("2");
        }
        if (collision.gameObject.name == "GameObject3")
        {
            Destroy(gameObject);
            Debug.Log("3");
        }
        if (collision.gameObject.name == "GameObject4")
        {
            Destroy(gameObject);
            Debug.Log("4");
        }
    }
    */
}
