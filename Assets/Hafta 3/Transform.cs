using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            transform.position = new Vector3(transform.position.x,transform.position.y + 0.10f,transform.position.z);
            Debug.Log("Up");
        }
    }
}
