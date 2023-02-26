using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleFall : MonoBehaviour
{
      public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        // Move GameObject down
        transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
}
