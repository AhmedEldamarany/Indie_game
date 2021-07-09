using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] UiManager uiManager;
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
        
    }
    public void InitPosition()
    {
        transform.position = new Vector3(0, 13, 0);
        rb.velocity = Vector3.zero;
        PlayerPosition.value = transform.position;
    }

    private void FixedUpdate() //torest the cpu a bit from adding force every frame
    {
        rb.AddForce(Movement.value * speed.value);   
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

