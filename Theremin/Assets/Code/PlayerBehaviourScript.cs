using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviourScript : MonoBehaviour
{
    public int PlayerScore;
    public int Max_Score;
    //public text highscoreText;
    public Text scoreText;
    int highscore;

    // Start is called before the first frame update
    void Start()
    {
        PlayerScore = 0;
        PlayerPrefs.SetInt("highscore", PlayerScore);
        PlayerPrefs.SetInt("Max_Score", Max_Score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayerScoreCount()
    {
        //Punkte werden hochgezähl 
        PlayerScore++;
        scoreText.text = "Score: "+PlayerScore;
        Debug.Log("PlayerScore: "+PlayerScore);
        Debug.Log("PlayerScore_max: "+Max_Score);

        PlayerPrefs.SetInt("highscore", PlayerScore);
        PlayerPrefs.SetInt("Max_Score", Max_Score);
        //highscoreText.text = PlayerPrefs.GetInt("highscore").ToString();

    }


    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "SoundCubeTag")
        {
            Debug.Log("Treffer ");
            
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "SoundCubeTag")
        { 
            Destroy (collision.gameObject);
            PlayerScoreCount();
        }
    }
}
