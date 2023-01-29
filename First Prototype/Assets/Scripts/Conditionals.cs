using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{

    int time = 104;
    public string weather = "Clear";
    bool isStopLightRed = true;
    float gpa = 3.25f;
    double temperature = 101.45d;


    // Start is called before the first frame update
    void Start()
    {
        // Check Time
        if(time >= 200)
        {
            Debug.Log("Rise and Shine!");
        }
        else
        {
            Debug.Log("It is too early. Go back to bed!");
        }
        // Check Weather
        if(weather == "Cloudy")
        {
            Debug.Log("It is cloudy outside");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
