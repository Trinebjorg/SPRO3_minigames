using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class GameData   //This feature has not been fully implemented yet
{
    private bool cloverPuzzleLevels;
    private bool marvelPuzzleLevels;
    private bool transportPuzzleLevels;

    private int[] cloverPuzzleLevelStars;
    private int[] marvelPuzzleLevelStars;
    private int[] transportPuzzleLevelStars;

    private bool isTheGameStartedForTheFirstTime;

    private float musicVolume;

    public void SetMusicVolume(float musicVolume) //gathers data about the music 
    {
        this.musicVolume = musicVolume;
    }

    public float GetMusicVolume() //returns data about the music 
    {
        return this.musicVolume;
    }

    public void SetisTheGameStartedForTheFirstTime( bool isTheGameStartedForTheFirstTime) //Checks if the game has been started before 
    {
        this.isTheGameStartedForTheFirstTime = isTheGameStartedForTheFirstTime;
    }
    public bool GetisTheGameStartedForTheFirstTime()    //Returns data about whether the game has been started
    {
        return this.isTheGameStartedForTheFirstTime;
    }



}
