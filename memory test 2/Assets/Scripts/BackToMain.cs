using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class BackToMain : MonoBehaviour
{
    //Coding for Addbuttons

    //   [SerializeField]
    //   private Transform MainField_Panel;
    //   [SerializeField]
    //   private GameObject Exit;
    //   [SerializeField]
    //   private GameObject Break;
    public Button btn;

    public void SceneChangeOnClick() {
       

        //change scene for Exit_button
        if (btn != null) {
            if (btn.name == "Exit_Button") {
                Application.Quit();
            }

        }
    }
}