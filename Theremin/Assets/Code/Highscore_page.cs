using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System;


public class Highscore_page : MonoBehaviour
{
    private int score;
    public TMP_Text scoreText;
   
    //static void Start()
    void Start()
    {
        //score = script.PlayerScore;
        //scoreText.text = "Score: " + score;

        scoreText.text = "Score: " + PlayerPrefs.GetInt("highscore").ToString();

    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Startmenü");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
