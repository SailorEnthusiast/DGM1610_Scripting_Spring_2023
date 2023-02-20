using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    //private ScoreManager scoreManager; // A variable to hold the reference to the scoremanager
    //public int scoreToGive;
    //public ParticleSystem explosionParticle; // Store the particle sysytem

    // Start is called before the first frame update
    void Start()
    {
        //scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Reference scoremanager
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("LaserBolt"))
        {
            Destroy(gameObject); //Destroy this gameobject (UFO)
            Destroy(other.gameObject); // Destroy the other gameobject it hits
        }

        //Explosion();
        //scoreManager.IncreaseScore(scoreToGive); // Increase Score
        //Destroy(other.gameObject); // Destroy the other gameobject it hits
        //Destroy(gameObject); // Destroy the game object
    }

    /*
    void Explosion()
    {
        Instantiate(explosionParticle,transform.position,transform.rotation);
    }
    */
}
