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

    [SerializeField]
    private GameFinished gameFinished;

    private int level;
    private string selectedPuzzle;

    private Sprite puzzleBackgroundImage; 

    private bool firstGuess, secondGuess;
    private int firstGuessIndex, secondGuessIndex;
    private string firstGuessPuzzle, secondGuessPuzzle;

    private int countTryGuesses;

    private int countCorrectGuesses;
    private int gameGuess; 

    public void PickAPuzzle()
    {
        if(!firstGuess)
        {
            firstGuess = true;

            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

            firstGuessPuzzle = gamePuzzleSprites[firstGuessIndex].name; 

            StartCoroutine(TurnPuzzleButtonIn(puzzleButtonsAnimators[firstGuessIndex], puzzleButtons[firstGuessIndex], gamePuzzleSprites[firstGuessIndex]));



        }
        else if(!secondGuess)
        {
            secondGuess = true;

            secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

            secondGuessPuzzle = gamePuzzleSprites[secondGuessIndex].name;

            StartCoroutine(TurnPuzzleButtonIn(puzzleButtonsAnimators[secondGuessIndex], puzzleButtons[secondGuessIndex], gamePuzzleSprites[secondGuessIndex]));

            StartCoroutine(CheckIfThePuzzlesMatch(puzzleBackgroundImage));

            countTryGuesses++;
        }




    }

    IEnumerator CheckIfThePuzzlesMatch(Sprite puzzleBackgroundImage)
    {
        yield return new WaitForSeconds(1.7f);

        if(firstGuessPuzzle == secondGuessPuzzle)
        {
            puzzleButtonsAnimators[firstGuessIndex].Play("FadeOut");
            puzzleButtonsAnimators[secondGuessIndex].Play("FadeOut");

            CheckIfTheGameIsFinished();
        } else
        {
            StartCoroutine(TurnPuzzleButtonOut(puzzleButtonsAnimators[firstGuessIndex], puzzleButtons[firstGuessIndex], puzzleBackgroundImage));

            StartCoroutine(TurnPuzzleButtonOut(puzzleButtonsAnimators[secondGuessIndex], puzzleButtons[secondGuessIndex], puzzleBackgroundImage));

        }

        yield return new WaitForSeconds(.7f);

        firstGuess = secondGuess = false; 
    } 

    void CheckIfTheGameIsFinished()
    {
        countCorrectGuesses++;

        if(countCorrectGuesses == gameGuess)
        {
 //           Debug.Log("Game End");
            CheckHowManyGuesses();
        }

    }

    void CheckHowManyGuesses()
    {
        int amountGuesses = 0;  

        switch (level) {
            case 0:
                amountGuesses = 5;
                break;

            case 1:
                amountGuesses = 10;
                break;

            case 2:
                amountGuesses = 15;
                break;

            case 3:
                amountGuesses = 20;
                break;

            case 4:
                amountGuesses = 25;
                break; 
        }

        if(countTryGuesses < amountGuesses)
        {
            gameFinished.ShowGameFinishedPanel(3); 
        } else if (countTryGuesses < (amountGuesses + 5))
        {
            gameFinished.ShowGameFinishedPanel(2);
        } else
        {
            gameFinished.ShowGameFinishedPanel(1);
        }
    }

    public List<Animator> ResetGameplay()
    {
        firstGuess = secondGuess = false;

        countTryGuesses = 0;
        countCorrectGuesses = 0; 

        gameFinished.HideGameFinishedPanel();


        return puzzleButtonsAnimators; 
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

        gameGuess = puzzleButtons.Count / 2; 

        puzzleBackgroundImage = puzzleButtons[0].image.sprite; 


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
