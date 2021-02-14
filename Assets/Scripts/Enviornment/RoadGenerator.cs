using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : Generator
{
    [SerializeField] MyEventSO scoreIncrease;

    
    void Update()
    {
        if (PlayerPosition.value.z - roadLegnth > (spawnz - (amount * roadLegnth)))
        {
            SpawnRoad();
            ReturnRoad();
            scoreIncrease.Raise();
        }
    }
   
}
