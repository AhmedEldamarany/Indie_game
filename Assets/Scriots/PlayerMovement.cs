using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    float h, v;
    float speed = 5f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    
    void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal") * speed ;
        v = Input.GetAxis("Vertical") * speed ;
        rb.AddForce(h, 0, v);
    }
}

