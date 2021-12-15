using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class PuzzleGameSaver : MonoBehaviour
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

    // Start is called before the first frame update
  
    void initializeGame()
    {
        LoadGameData();

        if(gameData != null)
        {
            isTheGameStartedForTheFirstTime = gameData.GetisTheGameStartedForTheFirstTime();
        } else
        {
            isTheGameStartedForTheFirstTime = true; 
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
