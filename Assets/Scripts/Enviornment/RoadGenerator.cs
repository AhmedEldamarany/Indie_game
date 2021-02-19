using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : Generator
{
    [SerializeField] MyEventSO scoreIncrease;

    
    void Update()
    {
        if (PlayerPosition.value.z - roadLegnth*1.5f > (spawnz - (startingAmount * roadLegnth)))
        {
            SpawnRoad();
            ReturnRoad();
            scoreIncrease.Raise();
        }
    }
   
}
