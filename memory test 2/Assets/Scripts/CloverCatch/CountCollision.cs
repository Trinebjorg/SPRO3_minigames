using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountCollision : MonoBehaviour
{
    int count = 0;
    public void OnTriggerEnter(Collider col)
    {
       
        Destroy(col.gameObject);
        count++;
        StartCoroutine(CheckIfGameFinished(count));
        Debug.Log("Count" + count);
        
    }

    [SerializeField] 
    private GameObject spawner;

    [SerializeField]
    private GameObject gameFinishedPanel;

    [SerializeField]
    private Animator gameFinishedAni, star1Ani, star2Ani, star3Ani, textAni;

    public IEnumerator CheckIfGameFinished(int count)
    {
        if (count == 10)
        {
            spawner.SetActive(false);
            yield return new WaitForSeconds(1.5f);
            gameFinishedPanel.SetActive(true);

            gameFinishedAni.Play("FadeIn");
            textAni.Play("FaceIn");

        }
    }
}



