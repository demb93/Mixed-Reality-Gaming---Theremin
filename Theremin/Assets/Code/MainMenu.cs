using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
 
{

    public Dropdown gameScene;
    string dropdownValue;
    int dropdownIndex;

    private void Start()
    {
        gameScene.onValueChanged.AddListener(delegate
        {
            gameSceneValueChangeHappened(gameScene);
        });
    }

    public void gameSceneValueChangeHappened(Dropdown sender)
    {
        Debug.Log(sender.value);
        Debug.Log(gameScene.options[gameScene.value].text);

    }

    public void Play()
    {
        StartCoroutine(wait());
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(gameScene.options[gameScene.value].text);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
