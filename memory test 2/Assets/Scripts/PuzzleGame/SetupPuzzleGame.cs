using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupPuzzleGame : MonoBehaviour
{

    [SerializeField]
    private PuzzleGameManager puzzleGameManager;

    [SerializeField]
    private Sprite[] cloverPuzzleSprites, marvelPuzzleSprites, transportPuzzleSprites;

    [SerializeField]
    private List<Sprite> gamePuzzles = new List<Sprite>();

    private List<Button> puzzleButtons = new List<Button>();

    private List<Animator> puzzleButtonsAnimators = new List<Animator>();

    private int level;
    private string selectedPuzzle;

    private int looper;

     void Awake()   //loads all the sprites for each puzzle
    {
        cloverPuzzleSprites = Resources.LoadAll<Sprite>("Sprites/Clover");
        marvelPuzzleSprites = Resources.LoadAll<Sprite>("Sprites/Pokemon");
        transportPuzzleSprites = Resources.LoadAll<Sprite>("Sprites/Animals");

    }

    void PrepareGameSprites()
    {
        gamePuzzles.Clear ();
        gamePuzzles = new List<Sprite>();

        int index = 0; 

        switch (level)  //Depending on which level is selected the amount of cards that should load is set as the looper
        {
            case 0:
                looper = 4;
                break;

            case 1:
                looper = 8;
                break;
            case 2:
                looper = 12;
                break;

            case 3:
                looper = 18;
                break;

            case 4:
                looper = 24;
                break;

            case 5:
                looper = 80;
                break;
        }

        switch(selectedPuzzle)
        {
            case "Clover Puzzle":     //loads the appropriate amount of sprites for the Clover Puzzle 
                for (int i = 0; i < looper; i++)
                {
                    if(index == (looper/2))
                    {
                        index = 0; 
                    }
                    gamePuzzles.Add(cloverPuzzleSprites[index]);

                    index++;
                }

                break;

            case "Marvel Puzzle":     //loads the appropriate amount of sprites for the Marvel Puzzle 
                for (int i = 0; i < looper; i++)
                {
                    if (index == (looper / 2))
                    {
                        index = 0;
                    }
                    gamePuzzles.Add(marvelPuzzleSprites[index]);

                    index++;
                }

                break;

            case "Transport Puzzle":     //loads the appropriate amount of sprites for the Transport Puzzle 
                for (int i = 0; i < looper; i++)
                {
                    if (index == (looper / 2))
                    {
                        index = 0;
                    }
                    gamePuzzles.Add(transportPuzzleSprites[index]);

                    index++;
                }

                break;
        }
        Shuffle(gamePuzzles);
    }

    void Shuffle(List<Sprite> list)     //Shuffles the list of sprites in order to introduce randomness into the game
    {
        for(int i = 0; i < list.Count; i++)
        {
            Sprite temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp; 

        }
    }

    public void SetLevelAndPuzzle(int level, string selectedPuzzle)     //Gathers info about which puzzle and which level has been selected
    {
        this.level = level;
        this.selectedPuzzle = selectedPuzzle;

        PrepareGameSprites();

        puzzleGameManager.SetGamePuzzleSprites(this.gamePuzzles);   
    }

    public void SetPuzzleButtonsAndAnimators(List<Button> puzzleButtons, List<Animator> puzzleButtonsAnimators)
    {
        this.puzzleButtons = puzzleButtons;
        this.puzzleButtonsAnimators = puzzleButtonsAnimators;

        puzzleGameManager.SetupButtonsAndAnimators(puzzleButtons, puzzleButtonsAnimators);
    }
}
