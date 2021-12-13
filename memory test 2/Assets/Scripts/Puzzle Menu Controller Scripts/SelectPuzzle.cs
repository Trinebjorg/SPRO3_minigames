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
        selectedPuzzle = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        puzzleGameManager.SetSelectedPuzzle(selectedPuzzle);

        selectLevel.SetSelectedPuzzle(selectedPuzzle);

        StartCoroutine(ShowPuzzlelevelSelectMenu());

    }

    IEnumerator ShowPuzzlelevelSelectMenu()
    {
        puzzleLevelSelectPanel.SetActive(true);
        selectPuzzleMenuAnim.Play("FadeOut");
        puzzleLevelSelectAnim.Play("FadeIn");
        yield return new WaitForSeconds(1f);
        selectPuzzleMenuPanel.SetActive(false);
    }

}
