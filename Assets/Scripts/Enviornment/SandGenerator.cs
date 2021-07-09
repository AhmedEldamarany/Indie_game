using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandGenerator : Generator
{
    private bool isPlaying = false;

    private void Start()
    {
        myPool = gameObject.GetComponent<Pool>();
        
    }

    void Update()
    {
        if(isPlaying)
        if (PlayerPosition.value.z - roadLegnth > (spawnz - (startingAmount * roadLegnth)))
        {
            SpawnRoad();
            ReturnRoad();
           
        }
    }
    public void init()
    {
        Init();
        isPlaying = true;
    }
}
