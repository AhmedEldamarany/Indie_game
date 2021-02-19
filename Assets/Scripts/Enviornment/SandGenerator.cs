using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandGenerator : Generator
{


    void Update()
    {
        if (PlayerPosition.value.z - roadLegnth > (spawnz - (startingAmount * roadLegnth)))
        {
            SpawnRoad();
            ReturnRoad();
           
        }
    }

}
