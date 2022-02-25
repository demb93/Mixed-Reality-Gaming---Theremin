using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class CubeBehaviourScript : MonoBehaviour
{
    float Geschwindigkeit = 1.0f;
    public Material cube_mat_start;
    public Material cube_mat_treffer;
    public AudioSource audioTheremin;

    Renderer cubeandplayer; 
    
    float cLow = 261.626f;
    //float cis = 277.183f;
    float d = 293.665f;
    //float dis = 311.127f;
    float e = 329.628f;
    float f = 349.228f;
    //float fis = 369.994f;
    float g = 391.995f;
    //float gis = 415.305f;
    float a = 440.000f;
    //float ais = 466.164f;
    float h = 493.883f;
    float cHigh = 523.251f;
    
     void Start()
    {
        //StartCoroutine(startGame());
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
       

        audioTheremin.volume = 1.0f;
        //Material des Cubes ändern 
        cubeandplayer.material = cube_mat_treffer;

        //Abspielen des Tons (abhängig von der Position)

        float Position_x = transform.position.x;
        Debug.Log("Position_x:"+Position_x);


        float pitch;

        //audioTheremin.pitch = pitch;
        switch (Position_x)
        {
            case -0.4375f: 
                Debug.Log("cLow");
                pitch = cLow / a;
                audioTheremin.pitch = pitch;
                break;

            case -0.3125f:
                Debug.Log("d"); 
                pitch = d / a;
                audioTheremin.pitch = pitch;
                break;

            case -0.1875f: 
                Debug.Log("e");
                pitch = e / a;
                audioTheremin.pitch = pitch;
                break;

            case -0.0625f: 
                Debug.Log("f");
                pitch = f / a;
                audioTheremin.pitch = pitch;
                break;

            case 0.0625f: 
                Debug.Log("g");
                pitch = g / a;
                audioTheremin.pitch = pitch;
                break;

            case 0.1875f: 
                Debug.Log("a");
                pitch = a / a;
                audioTheremin.pitch = pitch;
                break;
                
            case 0.3125f: 
                Debug.Log("h");
                pitch = h / a;
                audioTheremin.pitch = pitch;
                break;
            
            case 0.4375f:
                Debug.Log("cLow"); 
                pitch = cHigh / a;
                audioTheremin.pitch = pitch;
                break;

            default: 
                Debug.Log("Error Switch-Case Collision");
                audioTheremin.volume = 0.0f;
                break;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        audioTheremin.volume = 0.0f;
    }

    



}
