using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int clickToPop = 3; // How many clicks before ballon pops
    public float scaleToIncrease = 0.10f; // Scale increase each time ballon is clicked

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void onMouseDown() 
    {
        clickToPop -= 1; // Reduce clicks by one
        // Inflate balloon
        transform.localScale += Vector3.one * scaleToIncrease;
        // Check to see if click to pop has reached zero. Check to see if the balloon pops
        if (clickToPop == 0)
        {
            Destroy(gameObject); //Destroy and remove popped balloon
        }
    }
}
