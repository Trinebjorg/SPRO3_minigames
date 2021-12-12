using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class PuzzleGameManager : MonoBehaviour
{
    private List<Button> puzzleButtons = new List<Button>();

    private List<Animator> puzzleButtonsAnimators = new List<Animator>();

    [SerializeField]
    private List<Sprite> gamePuzzleSprites = new List<Sprite>();

    private int level;
    private string selectedPuzzle;

    private bool firstGuess, secondGuess;
    private int firstGuessIndex, secondGuessIndex;
    private string firstGuessPuzzle, secondGuessPuzzle; 

    public void PickAPuzzle()
    {
        if(!firstGuess)
        {
            firstGuess = true;

            firstGuessIndex = int.Parse(UnityEngine.Eventsystems.EventSystem.current.currentSelectedGameObject.name);

            firstGuessPuzzle = gamePuzzleSprites[firstGuessIndex].name; 

            StartCoroutine(TurnPuzzleButtonIn(puzzleButtonsAnimators[firstGuessIndex], puzzleButtons[firstGuessIndex], gamePuzzleSprites[firstGuessIndex]));



        }
        else if(!secondGuess)
        {
            secondGuess = true;

            secondGuessIndex = int.Parse(UnityEngine.Eventsystems.EventSystem.current.currentSelectedGameObject.name);

            secondGuessPuzzle = gamePuzzleSprites[secondGuessIndex].name;

            StartCoroutine(TurnPuzzleButtonIn(puzzleButtonsAnimators[secondGuessiÍndex], puzzleButtons[secondGuessIndex], gamePuzzleSprites[SecondGuessIndex]));

        }

    }

    IEnumerator TurnPuzzleButtonIn(Animator anim, Button btn, Sprite puzzleImage)
    {
        anim.Play("FadeIn");
        yield return new WaitForSeconds(.4f);
        btn.image.sprite = puzzleImage;

    }

    IEnumerator TurnPuzzleButtonOut(Animator anim, Button btn, Sprite puzzleImage)
    {
        anim.Play("FadeOut");
        yield return new WaitForSeconds(.4f);
        btn.image.sprite = puzzleImage;

    }
    void AddListeners()
    {
        foreach(Button btn in puzzleButtons)
        {
            btn.onClick.RemoveAllListeners();
            btn.onClick.AddListener(() => PickAPuzzle());
        }
    }

    public void SetupButtonsAndAnimators (List<Button> buttons, List<Animator> animators)
    {
        this.puzzleButtons = buttons;
        this.puzzleButtonsAnimators = animators;

        AddListeners();

    }

    public void SetGamePuzzleSprites(List<Sprite> gamePuzzleSprites)
    {
        this.gamePuzzleSprites = gamePuzzleSprites; 
    }

    public void SetLevel(int level)
    {
        this.level = level; 
    }

    public void SetSelectedPuzzle(string selectedPuzzle)
    {
        this.selectedPuzzle = selectedPuzzle; 

    }


}
