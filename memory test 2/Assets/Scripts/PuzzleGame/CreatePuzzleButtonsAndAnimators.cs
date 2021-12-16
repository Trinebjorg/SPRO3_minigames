using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePuzzleButtonsAndAnimators : MonoBehaviour
{

    [SerializeField]
    private LayoutPuzzleButtons layoutPuzzleButtons;

    [SerializeField]
    private Button puzzleButton;

    private int puzzleGame1 = 4;
    private int puzzleGame2 = 8;
    private int puzzleGame3 = 12;
    private int puzzleGame4 = 18;
    private int puzzleGame5 = 24;
    private int puzzleGame6 = 80; 

    private List<Button> level1Buttons = new List<Button>();
    private List<Button> level2Buttons = new List<Button>();
    private List<Button> level3Buttons = new List<Button>();
    private List<Button> level4Buttons = new List<Button>();
    private List<Button> level5Buttons = new List<Button>();
    private List<Button> level6Buttons = new List<Button>();


    private List<Animator> level1Anims = new List<Animator>();
    private List<Animator> level2Anims = new List<Animator>();
    private List<Animator> level3Anims = new List<Animator>();
    private List<Animator> level4Anims = new List<Animator>();
    private List<Animator> level5Anims = new List<Animator>();
    private List<Animator> level6Anims = new List<Animator>();


    void Awake()
    {
        CreateButtons();
        GetAnimators();
    }

    void Start()
    {
        AssignBUttonsAndAnims();

    }

    void AssignBUttonsAndAnims()
    {
        layoutPuzzleButtons.level1Buttons = level1Buttons;
        layoutPuzzleButtons.level2Buttons = level2Buttons;
        layoutPuzzleButtons.level3Buttons = level3Buttons;
        layoutPuzzleButtons.level4Buttons = level4Buttons;
        layoutPuzzleButtons.level5Buttons = level5Buttons;
        layoutPuzzleButtons.level6Buttons = level6Buttons;


        layoutPuzzleButtons.level1Anims = level1Anims;
        layoutPuzzleButtons.level2Anims = level2Anims;
        layoutPuzzleButtons.level3Anims = level3Anims;
        layoutPuzzleButtons.level4Anims = level4Anims;
        layoutPuzzleButtons.level5Anims = level5Anims;
        layoutPuzzleButtons.level6Anims = level6Anims;



    }

    void CreateButtons()
    {
        for(int i = 0; i < puzzleGame1; i++)
        {
            Button btn = Instantiate(puzzleButton);
            btn.gameObject.name = "" + i;
            level1Buttons.Add(btn);
        }
        for (int i = 0; i < puzzleGame2; i++)
        {
            Button btn = Instantiate(puzzleButton);
            btn.gameObject.name = "" + i;
            level2Buttons.Add(btn);
        }
        for (int i = 0; i < puzzleGame3; i++)
        {
            Button btn = Instantiate(puzzleButton);
            btn.gameObject.name = "" + i;
            level3Buttons.Add(btn);
        }
        for (int i = 0; i < puzzleGame4; i++)
        {
            Button btn = Instantiate(puzzleButton);
            btn.gameObject.name = "" + i;
            level4Buttons.Add(btn);
        }
        for (int i = 0; i < puzzleGame5; i++)
        {
            Button btn = Instantiate(puzzleButton);
            btn.gameObject.name = "" + i;
            level5Buttons.Add(btn);
        }
        for (int i = 0; i < puzzleGame6; i++)
        {
            Button btn = Instantiate(puzzleButton);
            btn.gameObject.name = "" + i;
            level6Buttons.Add(btn);
        }
    }

    void GetAnimators()
    {
        for(int i = 0; i < level1Buttons.Count; i++)
        {
            level1Anims.Add(level1Buttons[i].gameObject.GetComponent<Animator>());
            level1Buttons[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < level2Buttons.Count; i++)
        {
            level2Anims.Add(level2Buttons[i].gameObject.GetComponent<Animator>());
            level2Buttons[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < level3Buttons.Count; i++)
        {
            level3Anims.Add(level3Buttons[i].gameObject.GetComponent<Animator>());
            level3Buttons[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < level4Buttons.Count; i++)
        {
            level4Anims.Add(level4Buttons[i].gameObject.GetComponent<Animator>());
            level4Buttons[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < level5Buttons.Count; i++)
        {
            level5Anims.Add(level5Buttons[i].gameObject.GetComponent<Animator>());
            level5Buttons[i].gameObject.SetActive(false);
        }
        for (int i = 0; i < level6Buttons.Count; i++)
        {
            level6Anims.Add(level6Buttons[i].gameObject.GetComponent<Animator>());
            level6Buttons[i].gameObject.SetActive(false);
        }
    }
}
