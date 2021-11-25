using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class BackToMain : MonoBehaviour
{
    

    public void JumpToMemory() {

        SceneManager.LoadScene(sceneName: "MemoryGame");

    }
    public void JumpToMain()
    {
        SceneManager.LoadScene(sceneName: "MainMenu");

    }

    public void JumpToMem_Difficulty()
    {
        SceneManager.LoadScene(sceneName: "Difficulty_mem");
    }

}