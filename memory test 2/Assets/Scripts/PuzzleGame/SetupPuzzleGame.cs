using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupPuzzleGame : MonoBehaviour
{

    [SerializeField]
    private Sprite[] cloverPuzzleSprites, marvelPuzzleSprites, transportPuzzleSprites;

    private List<Sprite> gamePuzzles = new List<Sprite>();

    private List<Button> puzzleButtons = new List<Button>();

    private List<Animator> puzzleButtonsAnimators = new List<Animator>();

    private int level;
    private string selectedPuzzle;

    private int looper;

    private void Awake()
    {
        cloverPuzzleSprites = Resources.LoadAll<Sprite>("Sprites/Clover");
        marvelPuzzleSprites = Resources.LoadAll<Sprite>("Sprites/Pokemon");
        transportPuzzleSprites = Resources.LoadAll<Sprite>("Sprites/Clover");

    }

    void PrepareGameSprites()
    {

    }

    void Shuffle(List<Sprite> list)
    {

    }

    public void SetLevelAndPuzzle(int level, string selectedPuzzle)
    {

    }

    public void SetPuzzleButtonsAndAnimators(List<Button> puzzleButtons, List<Animator> puzzleButtonAnimators)
    {

    }
}
