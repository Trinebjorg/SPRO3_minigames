using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_buttons : MonoBehaviour
{

    [SerializeField]
    private Transform puzzleField;

    [SerializeField]
    private GameObject btn;

    private void Awake()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject button = Instantiate(btn);
            button.name = " Card " + i;
            button.transform.SetParent(puzzleField, false);
        }
    }

}
