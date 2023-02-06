using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public float upperBound = 10f;
    public ScoreManager scoreManager; // A reference to the scoremanager
    public Balloon balloon; // A reference to the balloon script to get score

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        // Make the balloon float upward
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        if(transform.position.y > upperBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive); // Reduces score for allowing balloon to leave the screen
            Destroy(gameObject); // Pops the balloon
        }
    }
}
