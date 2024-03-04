using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerDemo : MonoBehaviour
{
    private CharacterController ch;
    // Start is called before the first frame update
    void Start()
    {
        ch = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        ch.Move(move * Time.deltaTime * 10f);
    }
}
