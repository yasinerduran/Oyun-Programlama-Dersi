using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour
{
    private Vector3 input;
    private Rigidbody rb;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.z = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.velocity = input * speed;
    }
}
