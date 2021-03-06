using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPuzzleGame : MonoBehaviour
{
    [SerializeField]
    private PuzzleGameManager puzzleGameManager;

    [SerializeField]
    private LayoutPuzzleButtons layoutPuzzleButtons;

    [SerializeField]
    private GameObject puzzleLevelSelectPanel;


    [SerializeField]
    private Animator puzzleLevelSelectAnim;

    [SerializeField]
    private GameObject puzzleGamePanel1, puzzleGamePanel2, puzzleGamePanel3, puzzleGamePanel4, puzzleGamePanel5, puzzleGamePanel6;

    [SerializeField]
    private Animator puzzleGamePanelAnim1, puzzleGamePanelAnim2, puzzleGamePanelAnim3, puzzleGamePanelAnim4, puzzleGamePanelAnim5, puzzleGamePanelAnim6;

    private int puzzlelevel;

    private string selectedPuzzle;

    private List<Animator> anims;


    public void LoadPuzzle(int level, string puzzle)
    {
        this.puzzlelevel = level;   //Gathers level selected info 
        this.selectedPuzzle = puzzle;   //Gathers puzzle selected info 

        layoutPuzzleButtons.LayoutButtons (level, puzzle);  //sends level and puzzle info to layoutPuzzleButtons

        switch (puzzlelevel)
        {
            case 0:
                StartCoroutine(LoadPuzzleGamePanel(puzzleGamePanel1, puzzleGamePanelAnim1));    //Fades out the level select panel and fades in level 1 panel
                break;
            
            case 1:
                StartCoroutine(LoadPuzzleGamePanel(puzzleGamePanel2, puzzleGamePanelAnim2));    //Fades out the level select panel and fades in level 2 panel
                break;
            
            case 2:
                StartCoroutine(LoadPuzzleGamePanel(puzzleGamePanel3, puzzleGamePanelAnim3));    //Fades out the level select panel and fades in level 3 panel
                break;
            
            case 3:
                StartCoroutine(LoadPuzzleGamePanel(puzzleGamePanel4, puzzleGamePanelAnim4));    //Fades out the level select panel and fades in level 4 panel
                break;
            
            case 4:
                StartCoroutine(LoadPuzzleGamePanel(puzzleGamePanel5, puzzleGamePanelAnim5));    //Fades out the level select panel and fades in level 5 panel
                break;

            case 5:
                StartCoroutine(LoadPuzzleGamePanel(puzzleGamePanel6, puzzleGamePanelAnim6));    //Fades out the level select panel and fades in level 6 panel
                break; 

        }


    }

    public void BackToPuzzleLevelSelectMenu()
    {
        anims = puzzleGameManager.ResetGameplay();

        switch (puzzlelevel)
        {
            case 0:
                StartCoroutine(LoadPuzzleLevelSelectMenu(puzzleGamePanel1, puzzleGamePanelAnim1));  //Fades out level 1 panel and fades in level Select panel 
                break;

            case 1:
                StartCoroutine(LoadPuzzleLevelSelectMenu(puzzleGamePanel2, puzzleGamePanelAnim2));  //Fades out level 2 panel and fades in level Select panel 
                break;

            case 2:
                StartCoroutine(LoadPuzzleLevelSelectMenu(puzzleGamePanel3, puzzleGamePanelAnim3));  //Fades out level 3 panel and fades in level Select panel 
                break;

            case 3:
                StartCoroutine(LoadPuzzleLevelSelectMenu(puzzleGamePanel4, puzzleGamePanelAnim4));  //Fades out level 4 panel and fades in level Select panel 
                break;

            case 4:
                StartCoroutine(LoadPuzzleLevelSelectMenu(puzzleGamePanel5, puzzleGamePanelAnim5));  //Fades out level 5 panel and fades in level Select panel 
                break;

            case 5:
                StartCoroutine(LoadPuzzleLevelSelectMenu(puzzleGamePanel6, puzzleGamePanelAnim6));  //Fades out level 6 panel and fades in level Select panel
                break;

        }
    }

    IEnumerator LoadPuzzleLevelSelectMenu(GameObject puzzleGamePanel, Animator puzzleGamePanelAnim)
    {
        puzzleLevelSelectPanel.SetActive(true);
        puzzleLevelSelectAnim.Play("FadeIn");
        puzzleGamePanelAnim.Play("FadeOut");
        yield return new WaitForSeconds(1f);

        foreach (Animator anim in anims)
        {
            anim.Play("Idle");
        }

        yield return new WaitForSeconds(.5f); 


        puzzleGamePanel.SetActive(false);
    }




    IEnumerator LoadPuzzleGamePanel (GameObject puzzleGamePanel, Animator puzzleGamePanelAnim)
    {
        puzzleGamePanel.SetActive(true);
        puzzleGamePanelAnim.Play("FadeIn");
        puzzleLevelSelectAnim.Play("FadeOut");
        yield return new WaitForSeconds(1f);
        puzzleLevelSelectPanel.SetActive(false);
    }
}
