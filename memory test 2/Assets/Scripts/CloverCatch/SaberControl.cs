using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaberControl : MonoBehaviour
{
    public int hits;
    private CountCollision countCollision;


    public void OnTriggerEnter(Collider col)
    {
        Debug.Log("Leets go");
        Destroy(col.gameObject);
        Debug.Log("First");
        hits++;
        Debug.Log("Count" + hits);
 //       countCollision.hitRegister(hits);
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
