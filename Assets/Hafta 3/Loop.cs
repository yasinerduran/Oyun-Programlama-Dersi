using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    private Rigidbody rb;

    public float force = 15f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public bool forvard = true;
    private void FixedUpdate()
    {
        if (forvard)
        {
            if (transform.position.x<15)
            {
                rb.AddForce(transform.forward*force);
            }
            else
            {
                forvard = false;
            }
        }
        else
        {
            if (transform.position.x>0)
            {
                rb.AddForce(-1*transform.forward*force);
            }
            else
            {
                forvard = true;
            }
        }
    }
}
