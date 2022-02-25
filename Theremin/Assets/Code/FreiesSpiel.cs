using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreiesSpiel : MonoBehaviour
{
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

    public AudioSource audioTheremin;
    float pitch;
    // Start is called before the first frame update
    void Start()
    {
        audioTheremin.volume = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float Position_x = this.transform.position.x;
        float Position_y = this.transform.position.y;

        float t = Mathf.InverseLerp(0.07f, 0.35f, Position_y);
        float volume = Mathf.Lerp(0, 1, t);

        audioTheremin.volume = volume;

        if (Position_x <= -0.2625f)
        {
            pitch = cLow / a;
            audioTheremin.pitch = pitch;
        }
        else if (Position_x > -0.2625f && Position_x <= -0.175f)
        {
            pitch = d / a;
            audioTheremin.pitch = pitch;
        }
        else if (Position_x > -0.175f && Position_x <= -0.0875f)
        {
            pitch = e / a;
            audioTheremin.pitch = pitch;
        }
        else if (Position_x > -0.0875f && Position_x <= 0f)
        {
            pitch = f / a;
            audioTheremin.pitch = pitch;
        }
        else if (Position_x > 0f && Position_x <= 0.0875f)
        {
            pitch = g / a;
            audioTheremin.pitch = pitch;
        }
        else if (Position_x > 0.0875f && Position_x <= 0.175f)
        {
            pitch = a / a;
            audioTheremin.pitch = pitch;
        }
        else if (Position_x > 0.175f && Position_x <= 0.2625f)
        {
            pitch = h / a;
            audioTheremin.pitch = pitch;
        }
        else if (Position_x > 0.2625f && Position_x <= 0.35f)
        {
            pitch = cHigh / a;
            audioTheremin.pitch = pitch;
        }

        

    }
}
