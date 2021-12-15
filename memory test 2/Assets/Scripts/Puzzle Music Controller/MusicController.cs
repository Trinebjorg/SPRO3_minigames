using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{

    [SerializeField]
    private PuzzleGameManager puzzleGameSaver;

    private AudioSource bgMusicClip;



    private float musicVolume;

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {

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
    
        if (bgMusicClip.volume > 0)
        {
            if(!bgMusicClip.isPlaying)
            {
                bgMusicClip.Play();
            }

            puzzleGameSaver.musicVolume = musicVolume;

        }
    
    
    }



}
