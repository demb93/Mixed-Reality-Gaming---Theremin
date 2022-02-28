using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;


public class Highscore_page : MonoBehaviour
{
    //private string score;
    public TMP_Text scoreText;
   
    //static void Start()
    void Start()
    {
        //score = script.PlayerScore;
        //scoreText.text = "Score: " + score;
        //score = PlayerPrefs.GetInt("highscore").ToString();
        scoreText.text = "Score: " + PlayerPrefs.GetInt("highscore").ToString() + " / " + PlayerPrefs.GetInt("Max_Score").ToString();

    }
    public void MainMenu()
    {
        //scoreText.text = "Score: 0" + " / " + PlayerPrefs.GetInt("Max_Score").ToString();
        //score = "0";
        SceneManager.LoadScene("Startmenü");
    }
    public void QuitGame()
    {
        //score = "0"; 
        Application.Quit();
    }
}
