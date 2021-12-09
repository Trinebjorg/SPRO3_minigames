using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsController : MonoBehaviour
{
    [SerializeField]
    private GameObject settingsPanel;


    [SerializeField]
    private Animator settingsPanelAnim; 
         

    public void OpenSettingsPanel()
    {
        settingsPanel.SetActive(true);
        settingsPanelAnim.Play("FadeIn");
    }


    public void CloseSettingsPanel()
    {
        StartCoroutine(CloseSettings());
    }

    IEnumerator CloseSettings()
    {
        settingsPanelAnim.Play("FadeOut");
        yield return new WaitForSeconds(1f);
        settingsPanel.SetActive(false);
    }


}
