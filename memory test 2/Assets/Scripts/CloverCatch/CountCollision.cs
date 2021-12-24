using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountCollision : MonoBehaviour // Class for cheching the missed game objects 
{
    private SaberControl saberControl;
    
    [SerializeField]
    private CGameFinished cGameFinished;


    [SerializeField]
    private GameObject Spawner;

    int count = 0;
    int totalHits;
    public void OnTriggerEnter(Collider col) // Function for collision detection
    {

        Destroy(col.gameObject); // If a collision happens -> destroy Gameobject
        count++;

        if (count == 10) // If player misses 10 objects 
        {
            Spawner.SetActive(false); // Stop spawning objects 
            cGameFinished.ShowGameFinishedPanel(); // Display the game finished panel
     //       StartCoroutine(FakeFinnishPanel());

        }
        Debug.Log("Count " + count);

    }


/*
    public void CheckIfGameFinished()
    {

        if (totalHits == 5)
        {
            StartCoroutine(showPanel(1));
        }
        else if (totalHits == 10)
        {
            StartCoroutine(showPanel(2));
        }
        else
        {
            StartCoroutine(showPanel(3));
        }


    }

    IEnumerator showPanel(int stars)
    {
        gameFinishedPanel.SetActive(true);

        gameFinishedAnim.Play("FadeIn");

        yield return new WaitForSeconds(1.7f);

        switch (stars)
        {
            case 1:
                star1Anim.Play("FadeIn");
                yield return new WaitForSeconds(.1f);
                textAnim.Play("FadeIn");
                break;

            case 2:
                star1Anim.Play("FadeIn");
                yield return new WaitForSeconds(.25f);
                star2Anim.Play("FadeIn");
                yield return new WaitForSeconds(.1f);
                textAnim.Play("FadeIn");
                break;

            case 3:
                star1Anim.Play("FadeIn");
                yield return new WaitForSeconds(.25f);
                star2Anim.Play("FadeIn");
                yield return new WaitForSeconds(.1f);
                star3Anim.Play("FadeIn");
                yield return new WaitForSeconds(.1f);
                textAnim.Play("FadeIn");
                break;

        }


    }

   /* public void hitRegister(int hits)
    {
        this.hits = hits;
    }
   

    

    IEnumerator FakeFinnishPanel()
    {
        spawner.SetActive(false);
        gameFinishedPanel.SetActive(true);
        gameFinishedAnim.Play("FadeIn");
        yield return new WaitForSeconds(1.7f);
        star1Anim.Play("FadeIn");
        yield return new WaitForSeconds(.25f);
        star2Anim.Play("FadeIn");
        yield return new WaitForSeconds(.1f);
        star3Anim.Play("FadeIn");
        yield return new WaitForSeconds(.1f);
        textAnim.Play("FadeIn");
    }
*/
}



