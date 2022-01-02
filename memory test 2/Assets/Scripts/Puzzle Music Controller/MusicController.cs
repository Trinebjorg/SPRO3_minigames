using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{

    [SerializeField]
    private PuzzleGameSaver puzzleGameSaver;

    private AudioSource bgMusicClip;



    private float musicVolume;

    void Awake()
    {
        GetAudioSource();
    }

    void Start()
    {
        musicVolume = puzzleGameSaver.musicVolume;  //Checks what the volume was set to last time the game was launched 
        PlayOrTurnOffMusic(musicVolume);    //sends the saved music volume to the appropriate function 
    }

    void GetAudioSource()
    {
        bgMusicClip = GetComponent<AudioSource>();      

    }

    public void SetMusicVolume(float volume)
    {
        PlayOrTurnOffMusic(volume);
    }

    void PlayOrTurnOffMusic(float volume)
    {
        musicVolume = volume;
        bgMusicClip.volume = musicVolume; 
    
        if (bgMusicClip.volume > 0)     //The music plays at the selected volume 
        {
            if(!bgMusicClip.isPlaying)
            {
                bgMusicClip.Play();
            }

            puzzleGameSaver.musicVolume = musicVolume;
            puzzleGameSaver.SaveGameData();
        } else if (bgMusicClip.volume == 0)     //The music stops playing if it is set to 0 
        {
            if(bgMusicClip.isPlaying)
            {
                bgMusicClip.Stop();
            }
            puzzleGameSaver.musicVolume = musicVolume;
            puzzleGameSaver.SaveGameData();
        }
    
    
    }


    public float GetMusicVolume()
    {
        return this.musicVolume;
    }


}
