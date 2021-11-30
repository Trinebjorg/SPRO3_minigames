using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_buttons : MonoBehaviour
{

    // accessing the difficulty declared when selecting difficulty
 
   /* [SerializeField]
    private Difficulty Diff; 
   */
    [SerializeField]
    private Transform puzzleField;

    [SerializeField]
    private GameObject btn;

    private void Awake()
    {
        for (int i = 0; i < /*Diff.btn_count*/ 8 ; i++)
        {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(puzzleField, false);
        }
    }

}
