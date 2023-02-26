using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOOB : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowBounds = -30.0f;

    void Awake()
    {
        //Time.timescale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowBounds)
        {
            Debug.Log("Game Oover !");
            Destroy(gameObject);
            //Time.timescale = 0;
        }
    }
}
