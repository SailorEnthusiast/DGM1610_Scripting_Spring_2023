using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; // How many clicks before ballon pops
    public float scaleToIncrease = 0.10f; // Scale increase each time ballon is clicked
    public ScoreManager scoreManager; // A refernce to the scoremanager
    public int scoreToGive = 100;

    // Start is called before the first frame update
    void Start()
    {
        // Get ScoreManager Component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnMouseOver() 
    {
        if(Input.GetMouseButtonDown(0))
        {
            clickToPop --; // Reduce clicks by one
            // Inflate balloon
            transform.localScale += Vector3.one * scaleToIncrease;
            // Check to see if click to pop has reached zero. Check to see if the balloon pops
            if (clickToPop == 0)
            {
                // Tell the scoremanager to increase the score by a certain amount
                scoreManager.IncreaseScoreText(scoreToGive);
                Destroy(gameObject); // Destroy and remove popped balloon
            }
        }
    }
}
