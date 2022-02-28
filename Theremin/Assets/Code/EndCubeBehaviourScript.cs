using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;


public class EndCubeBehaviourScript : MonoBehaviour
{
    float Geschwindigkeit = 1.5f;
    public Material cube_mat_start;
    public Material cube_mat_treffer;

    Renderer cubeandplayer; 
    
    void Start()
    {
        //audioTheremin = GetComponent<AudioSource>();
        cubeandplayer = GetComponent<Renderer>();
        cubeandplayer.material = cube_mat_start;
    }

    // Update is called once per frame
    void Update()
    {
        // Objekt bewegt sich mit einer Geschwindigkeit von 10 nach rechts
        var Richtung = new Vector3(0f, 0f, -1.0f);
        this.transform.position += Richtung * Geschwindigkeit * Time.deltaTime;          
    }

    // Start wenn Kollision erkannt wird  
    private void OnCollisionEnter (Collision collision)
    {
 
        //Material des Cubes ändern 
        cubeandplayer.material = cube_mat_treffer;
        SceneManager.LoadScene("HighScore");
        Debug.Log("ZIEL");

        //Abspielen des Tons (abhängig von der Position)
    }

    /*void OnCollisionExit(Collision collision)
    {
        SceneManager.LoadScene("HighScore");
    }*/

}
