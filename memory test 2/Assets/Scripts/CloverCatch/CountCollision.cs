using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountCollision : MonoBehaviour
{
    private SaberControl saberControl;



    [SerializeField]
    private GameObject spawner;

    [SerializeField]
    private GameObject gameFinishedPanel;

    [SerializeField]
    private Animator gameFinishedAnim, star1Anim, star2Anim, star3Anim, textAnim;

    int count = 0;
    public void OnTriggerEnter(Collider col)
    {

        Destroy(col.gameObject);
        count++;

        if (count == 10)
        {
//          CheckIfGameFinished();
            StartCoroutine(FakeFinnishPanel());

        }
        Debug.Log("Count " + count);

    }



 /*   public void CheckIfGameFinished()
    {

        if (hits == 5)
        {
            StartCoroutine(showPanel(1));
        }
        else if (hits == 10)
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

    public void hitRegister(int hits)
    {
        this.hits = hits;
    }


    */

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

}



