using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    private UiManager uiManager;
    float h, v;
    float speed = 3f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        uiManager = GameObject.FindGameObjectWithTag("ui").GetComponent<UiManager>();
    }

    
    void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal") * speed ;
        v = Input.GetAxis("Vertical") * speed ;
        rb.AddForce(h, 0, v);
        if (transform.position.y < -5f)
        {
            Deadth();
        }
    }
    public void Deadth()
    {
        transform.position = new Vector3(0, 5, transform.position.z + 5);
        rb.velocity = Vector3.zero;
        uiManager.TakeALife();
    }
}

