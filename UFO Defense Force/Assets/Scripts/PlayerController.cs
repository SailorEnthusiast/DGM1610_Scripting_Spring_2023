using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float xRange;
    public Transform Blaster;
    public GameObject laserBolt;

    // Update is called once per frame
    void Update()
    {
        // Set horizontalInput to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves Player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Keep player within bounds
        // Left Side Wall
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }

        // Right Side Wall
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }

        // If spacebar is pressed fire laserbolt
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Create laserBolt at the blaster transform position maintaining the objects rotation
            Instantiate(laserBolt, Blaster.transform.position, laserBolt.transform.rotation);
        }
    }
    // Delete any object with a trigger that hits the player
    private void OnTriggerEnter(Collider other)
    {
         Destroy(other.gameObject);
    }
}
