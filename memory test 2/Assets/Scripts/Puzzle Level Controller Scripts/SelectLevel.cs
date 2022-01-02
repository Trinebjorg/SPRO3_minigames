using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevel : MonoBehaviour
{

    [SerializeField]
    private PuzzleGameManager puzzleGameManager; 

    [SerializeField]
    private LoadPuzzleGame loadPuzzleGame; 


    [SerializeField]
    private GameObject selectPuzzleMenuPanel, puzzleLevelSelectPanel;

    [SerializeField]
    private Animator selectPuzzleMenuAnim, puzzleLevelSelectAnim;

    private string selectedPuzzle; 

    public void BackToPuzzleSelectMenu()
    {
        StartCoroutine(ShowPuzzleSelectMenu());
    }

    public void SelectPuzzleLevel()
    {
        int level = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name); //gets the selected level 

        puzzleGameManager.SetLevel(level); //sends the level info to PuzzleGameMAnager 

        loadPuzzleGame.LoadPuzzle(level, selectedPuzzle); //sends the level info to loadPuzzleGame
    }


    IEnumerator ShowPuzzleSelectMenu()     //fades out puzzle level panel and fades in puzzle menu panel 
    {
        selectPuzzleMenuPanel.SetActive(true);
        selectPuzzleMenuAnim.Play("FadeIn");
        puzzleLevelSelectAnim.Play("FadeOut");
        yield return new WaitForSeconds(1f);
        puzzleLevelSelectPanel.SetActive(false);
    }

    public void SetSelectedPuzzle(string selectedPuzzle) //gets the selected puzzle
    {
        this.selectedPuzzle = selectedPuzzle;
        Debug.Log("The selected puzzle is " + selectedPuzzle);
    }

}
