using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class SwitchScene : MonoBehaviour
{
    

    public void JumpToMemory    () {

        SceneManager.LoadScene(sceneName: "Memory_Game2");

    }
    public void JumpToMain()
    {
        SceneManager.LoadScene(sceneName: "MainMenu");

    }

    public void JumpToMem_Difficulty()
    {
        SceneManager.LoadScene(sceneName: "Difficulty_mem");
    }

    public void JumpToCloverCatch()
    {
        SceneManager.LoadScene(sceneName: "CloverCatch");
    }
    public void JumpToPickTheme()
    {
        SceneManager.LoadScene(sceneName: "ThemeCatch");
    }

}