using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    private UiManager uiManager;
    [SerializeField] VectorSO PlayerPosition;
    [SerializeField] MyEventSO deathEvent;
    [SerializeField] VectorSO Movement;
    [SerializeField] private IntSo speed;

    private void Awake()
    {
        PlayerPosition.value = new Vector3(0, 0, -3);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        uiManager = GameObject.FindGameObjectWithTag("ui").GetComponent<UiManager>();
    }


    private void LateUpdate()
    {
        Debug.Log(rb.velocity);
        rb.AddForce(Movement.value*speed.value,ForceMode.Acceleration);   //need to be clamped
        PlayerPosition.value = transform.position;
    }
    public void Deadth()
    {
        deathEvent.Raise();
        transform.position = new Vector3(0, 13, transform.position.z + 3);
        rb.velocity = Vector3.zero;
        uiManager.TakeALife();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "deadly")
            Deadth();
    }

}

