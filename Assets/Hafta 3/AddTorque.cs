using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTorque : MonoBehaviour
{
    private Rigidbody rb;

    public float torque = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        
        float turn = Input.GetAxis("Horizontal");
        rb.AddTorque(transform.up * torque * turn);
        
    }
}
