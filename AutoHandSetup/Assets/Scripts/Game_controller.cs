using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_controller : MonoBehaviour
{

    [SerializeField]
    private Sprite BGImage;

    public Sprite[] puzzles;

    public List<Sprite> gamePuzzles = new List<Sprite>();

    private bool firstGuess, secondGuess;

    private int countGuesses;
    private int countCorrectGuesses;
    private int gameGuesses;

    private string firstGuessPuzzle, secondGuessPuzzle;

    private int firstGuessIndex, secondGuessIndex;


    public List<Button> btns = new List<Button>();

    void Awake()
    {
        puzzles = Resources.LoadAll<Sprite>("Sprites/Cards");
    }

    void Start()
    {
        GetButtons();
        AddListeners();
        AddGamePuzzles();
        Shuffle(gamePuzzles);
        gameGuesses = gamePuzzles.Count / 2;
    }

    void GetButtons()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");

        for (int i = 0; i < objects.Length; i++)
        {
            btns.Add(objects[i].GetComponent<Button>());
            btns[i].image.sprite = BGImage;

        }


    }

    void AddGamePuzzles()
    {
        int looper = btns.Count;
        int index = 0;

        for (int i = 0; i < looper; i++)
        {
            if (index == looper / 2)
            {
                index = 0;
            }

            gamePuzzles.Add(puzzles[index]);
            index++;
        }
    }
    void AddListeners()
    {
        foreach (Button btn in btns)
        {
            btn.onClick.AddListener(() => PickAPuzzle());
        }
    }

    public void PickAPuzzle()
    {
        string name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        if (!firstGuess)
        {
            firstGuess = true;
            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            firstGuessPuzzle = gamePuzzles[firstGuessIndex].name;
            btns[firstGuessIndex].image.sprite = gamePuzzles[firstGuessIndex];

        }
        else if (!secondGuess)
        {
            secondGuess = true;
            secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
            secondGuessPuzzle = gamePuzzles[secondGuessIndex].name;
            btns[secondGuessIndex].image.sprite = gamePuzzles[secondGuessIndex];
            countGuesses++;
            StartCoroutine(CheckIfThePuzzlesMatch());

            if (firstGuessPuzzle == secondGuessPuzzle)
            {
                Debug.Log("The Puzzles match!");
            }
            else
            {
                Debug.Log("The puzzles don't match");
            }

        }
        IEnumerator CheckIfThePuzzlesMatch()
        {
            yield return new WaitForSeconds(1f);
            if (firstGuessPuzzle == secondGuessPuzzle)
            {
                yield return new WaitForSeconds(.5f);
                btns[firstGuessIndex].interactable = false;
                btns[secondGuessIndex].interactable = false;

                btns[firstGuessIndex].image.color = new Color(0, 0, 0, 0);
                btns[secondGuessIndex].image.color = new Color(0, 0, 0, 0);

                CheckIfTheGameIsFinished();
            }
            else
            {
                yield return new WaitForSeconds(.5f);

                btns[firstGuessIndex].image.sprite = BGImage;
                btns[secondGuessIndex].image.sprite = BGImage;

            }

            yield return new WaitForSeconds(.5f);

            firstGuess = secondGuess = false;
        }

        void CheckIfTheGameIsFinished()
        {
            countCorrectGuesses++;
            if (countCorrectGuesses == gameGuesses)
            {
                Debug.Log("Game Finished");
                Debug.Log("it took you " + countGuesses + " many guess(es) to finish the game");
                SceneManager.LoadScene(sceneName: "Memory_Win");
            }
        }
    }

    void Shuffle(List<Sprite> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            Sprite temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }



    }

}
