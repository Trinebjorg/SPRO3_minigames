using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class GameData
{
    private bool cloverPuzzleLevels;
    private bool marvelPuzzleLevels;
    private bool transportPuzzleLevels;

    private int[] cloverPuzzleLevelStars;
    private int[] marvelPuzzleLevelStars;
    private int[] transportPuzzleLevelStars;

    private bool isTheGameStartedForTheFirstTime;

    private float musicVolume;

    public void SetMusicVolume(float musicVolume)
    {
        this.musicVolume = musicVolume;
    }

    public float GetMusicVolume()
    {
        return this.musicVolume;
    }

    public void SetisTheGameStartedForTheFirstTime( bool isTheGameStartedForTheFirstTime)
    {
        this.isTheGameStartedForTheFirstTime = isTheGameStartedForTheFirstTime;
    }
    public bool GetisTheGameStartedForTheFirstTime()
    {
        return this.isTheGameStartedForTheFirstTime;
    }



}
