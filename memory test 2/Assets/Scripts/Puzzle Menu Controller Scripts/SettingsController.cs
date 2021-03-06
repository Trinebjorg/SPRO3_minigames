using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{

    [SerializeField]
    private MusicController musicController;

    [SerializeField]
    private GameObject settingsPanel;


    [SerializeField]
    private Animator settingsPanelAnim;

    [SerializeField]
    private Slider slider;

    public void OpenSettingsPanel()
    {
        slider.value = musicController.GetMusicVolume();
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

    public void GetVolume(float volume)
    {
        musicController.SetMusicVolume(volume);
    }


}
