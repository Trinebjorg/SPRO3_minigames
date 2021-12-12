using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float beat = (60/130)*2;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>beat)
        {
            GameObject cube = Instantiate(cubes[Random.Range(0, 4)], points[Random.Range(0, 4)]); //point = transform?
            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 2));
            // Rotate the object around its local X axis at 1 degree per second:
            //cube.transform.Rotate(Time.deltaTime, 0, 0);
            // ...also rotate around the World's Y axis
           // transform.Rotate(0, Time.deltaTime, 0, Space.World);
            timer -= beat;
        }
        timer += Time.deltaTime;
        
    }
}
