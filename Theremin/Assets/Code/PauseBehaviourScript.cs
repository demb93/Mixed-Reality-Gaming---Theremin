using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class PauseBehaviourScript : MonoBehaviour
{
    public static bool GameIsPaused = false; 
    public GameObject PauseMenuUI;
    public GameObject ball;
    public AudioSource audioTheremin;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Play();
            }
            else
            {
                Pause(); 
            }
        }
    }

    public void Play()
    {
        PauseMenuUI.SetActive(false);
        ball.SetActive(true); 
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true); 
        ball.SetActive(false); 
        audioTheremin.volume = 0f;
        Time.timeScale = 0f;
        GameIsPaused = true;      
    }

    public void MainMenu()
    {
        
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("Startmenü");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
