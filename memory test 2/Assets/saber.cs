using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saber : MonoBehaviour
{
    public LayerMask Layer;
   private Vector3 previousPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, 1, Layer))
        {
            Destroy(hit.transform.gameObject); 
           // if (Vector3.Angle(transform.position-previousPos, hit.transform.up)>130) //Hit the objects over 130 degrees
            //{  Destroy(hit.transform.gameObject);}
        }
        previousPos = transform.position;
    }
}
