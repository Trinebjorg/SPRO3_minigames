using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaberControl : MonoBehaviour
{
    public GameObject MissCountArea; 

    public int hits;
    private CountCollision countCollision;

    [SerializeField]
    public  CGameFinished cGameFinished; 

    public void OnTriggerEnter(Collider col)
    {
        Debug.Log("Leets go");
        Destroy(col.gameObject);
        Debug.Log("First");
        hits++;
        cGameFinished.HitRegister(hits);
        //       cGameFinished.CollectStars(hits);
        Debug.Log("Count" + hits);
        //       countCollision.hitRegister(hits);
    }


/*
    public void AmountStars(int stars)
    {
       if (hits > 5)
        {
            stars = 1; 
        } else if (hits > 10)
        {
            stars = 2; 
        } else
        {
            stars = 3; 
        }
    }
*/

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
