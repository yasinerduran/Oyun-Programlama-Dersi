using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Control : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 input;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        
    }

    private void FixedUpdate()
    {
        rb.velocity = input * 10f;
    }
}
