using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Globalization;
using System.Linq;
using System.IO.Ports; // Serial Communication



public class SerialCom : MonoBehaviour
{
    public string port = "COM5";
    public int baudrate = 9600;
    private SerialPort sp;
    public GameObject sph;
    //public ParticleSystem particle;
    //public AudioSource audioTheremin;
    bool isStreaming;
    int min_dist = 4; //2
    int max_dist = 30; //24
    /*
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
    */

    // Start is called before the first frame update
    void Start()
    {
        //audioTheremin = GetComponent<AudioSource>();
        open();
    }

    public void open()
    {
        sp = new SerialPort(port, baudrate); // Create new object sp from class SerialPort with the above defined values port and baudrate
        isStreaming = true;
        sp.ReadTimeout = 5000; // Timeout after 100ms
        sp.Open();
        Debug.Log("Opened successfully");
    }

    public string ReadSerialPort(int timeout = 5000)
    {
        string distance; 
        sp.ReadTimeout = timeout;

        try
        {
            distance = sp.ReadLine();
            isStreaming = true;
            return distance;
        }
        catch (TimeoutException)
        {
            isStreaming = false;
            return null;
        }

    }



    // Update is called once per frame
    void Update()
    {
        //string value = ReadSerialPort();
        string[] elements = sp.ReadLine().Split(' ');
        float sphereXPosition;
        float sphereYPosition;
        float zPosition = -2.000000000000f;


        if (isStreaming)
        {
            float x = float.Parse(elements[0], CultureInfo.InvariantCulture.NumberFormat);
            float y = float.Parse(elements[1], CultureInfo.InvariantCulture.NumberFormat);
            float t = Mathf.InverseLerp(min_dist, max_dist, x);
            sphereXPosition = Mathf.Lerp(-0.35f, 0.35f, t);
            float c = Mathf.InverseLerp(min_dist, max_dist, y);
            sphereYPosition = Mathf.Lerp(0.07f, 0.4f, c);
            sph.transform.localPosition = new Vector3(sphereXPosition, sphereYPosition, zPosition);


            //if (value.Contains("D"))
            //{
            //    data1 = value.Trim(charsToTrim);
            //    newData1 = float.Parse(data1, CultureInfo.InvariantCulture.NumberFormat);
            //    float t = Mathf.InverseLerp(min_dist, max_dist, newData1);
            //    sphereXPosition = Mathf.Lerp(-0.35f, 0.35f, t);
            //    check = true;
            //    //sph.transform.position = new Vector3(sphereXPosition, sphereYPosition, zPosition);
            //}
            //else if (value.Contains("d"))
            //{
            //    data2 = value.Trim(charsToTrim);
            //    newData2 = float.Parse(data2, CultureInfo.InvariantCulture.NumberFormat);
            //    float t = Mathf.InverseLerp(min_dist, max_dist, newData2);
            //    sphereYPosition = Mathf.Lerp(0.07f, 0.35f, t);
            //    check = true;
            //    //sph.transform.position = new Vector3(sphereXPosition, sphereYPosition, zPosition);
            //}

            //if (check == true)
            //{
            //    sph.transform.localPosition = new Vector3(sphereXPosition, sphereYPosition, zPosition);
            //}

            //newData1 = float.Parse(data1, CultureInfo.InvariantCulture.NumberFormat);
            //float t = Mathf.InverseLerp(min_dist, max_dist, newData1);
            //spherePosition = Mathf.Lerp(-0.35f, 0.35f, t);
            //sph.transform.localPosition = new Vector3(spherePosition, yPosition, zPosition);

            /*if (newValue <= 3)
            {
                pitch = cLow / a;
                audioTheremin.pitch = pitch;
            } else if(newValue > 3 && newValue <= 6)
            {
                pitch = d / a;
                audioTheremin.pitch = pitch;
            } else if(newValue > 6 && newValue <= 9)
            {
                pitch = e / a;
                audioTheremin.pitch = pitch;
            } else if (newValue > 9 && newValue <= 12)
            {
                pitch = f / a;
                audioTheremin.pitch = pitch;
            } else if (newValue > 12 && newValue <= 15)
            {
                pitch = g / a;
                audioTheremin.pitch = pitch;
            } else if (newValue > 15 && newValue <= 18)
            {
                pitch = a / a;
                audioTheremin.pitch = pitch;
            } else if(newValue > 18 && newValue <= 21)
            {
                pitch = h / a;
                audioTheremin.pitch = pitch;
            } else if(newValue > 21 && newValue <= 24)
            {
                pitch = cHigh / a;
                audioTheremin.pitch = pitch;
            }*/

        }
    }
}
