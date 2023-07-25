using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiverScroll : MonoBehaviour
{
    public float xr;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.05f, 0);
        if (transform.position.y <-45f)
        {
            transform.position = new Vector3(xr, 45f, 0);
        }
    }
}

