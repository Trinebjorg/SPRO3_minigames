using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPuzzle : MonoBehaviour
{

    [SerializeField]
    private PuzzleGameManager puzzleGameManager;

    [SerializeField]
    private SelectLevel selectLevel; 


    [SerializeField]
    private GameObject selectPuzzleMenuPanel, puzzleLevelSelectPanel;

    [SerializeField]
    private Animator selectPuzzleMenuAnim, puzzleLevelSelectAnim; 

    private string selectedPuzzle;

    public void SelectedPuzzle()
    {
        selectedPuzzle = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name; // checks which puzzle button has been pressed

        puzzleGameManager.SetSelectedPuzzle(selectedPuzzle); //Sends the puzzle button info to PuzzleGameManager 

        selectLevel.SetSelectedPuzzle(selectedPuzzle); //Sends the puzzle button Info to selectLevel 

        StartCoroutine(ShowPuzzlelevelSelectMenu());

    }

    IEnumerator ShowPuzzlelevelSelectMenu()    //Fades out the menu panel and fades in the select level panel 
    {
        puzzleLevelSelectPanel.SetActive(true);
        selectPuzzleMenuAnim.Play("FadeOut");
        puzzleLevelSelectAnim.Play("FadeIn");
        yield return new WaitForSeconds(1f);
        selectPuzzleMenuPanel.SetActive(false);
    }

}
