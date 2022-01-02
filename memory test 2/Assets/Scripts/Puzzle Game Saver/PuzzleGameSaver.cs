using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class PuzzleGameSaver : MonoBehaviour    //This feature has not yet been fully implemented
{
    private GameData gameData;


    private bool cloverPuzzleLevels;
    private bool marvelPuzzleLevels;
    private bool transportPuzzleLevels;

    private int[] cloverPuzzleLevelStars;
    private int[] marvelPuzzleLevelStars;
    private int[] transportPuzzleLevelStars;

    private bool isTheGameStartedForTheFirstTime;

    public float musicVolume;

  
    void initializeGame()
    {
        LoadGameData();

        if(gameData != null)
        {
            isTheGameStartedForTheFirstTime = gameData.GetisTheGameStartedForTheFirstTime();    //Checks if the game has been started before 
        } else
        {
            isTheGameStartedForTheFirstTime = true;     //If there is no game data the game has not been started before 
        }

        if(isTheGameStartedForTheFirstTime)
        {
            isTheGameStartedForTheFirstTime = false;
            musicVolume = 0;

            gameData = new GameData();

            gameData.SetisTheGameStartedForTheFirstTime(isTheGameStartedForTheFirstTime);
            gameData.SetMusicVolume(musicVolume);

            SaveGameData();
            LoadGameData();
        }


    }

    public void SaveGameData()
    {
        FileStream file = null;

        try
        {
            BinaryFormatter bf = new BinaryFormatter();

            file = File.Create(Application.persistentDataPath + "/GameData.dat");

            if(gameData != null)
            {
                gameData.SetMusicVolume(musicVolume);

                bf.Serialize(file, gameData);

            }

        } catch(Exception e)
        {

        } finally
        {
            if(file != null)
            {
                file.Close();
            }
        }

    }

    void LoadGameData()
    {
        FileStream file = null; 

        try
        {
            BinaryFormatter bf = new BinaryFormatter();

            file = File.Open(Application.persistentDataPath + "/GameData.dat", FileMode.Open);

            gameData = (GameData)bf.Deserialize(file);

            if(gameData != null)
            {
                musicVolume = gameData.GetMusicVolume();
            }


        } catch(Exception e)
        {

        } finally
        {
            if(file != null)
            {
                file.Close();

            }
        }
    }

    public void Save(int level, string selectedPuzzle, int stars)
    {

    }

}
