using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandGenerator : Generator
{


    // Update is called once per frame
    void Update()
    {
        if (PlayerPosition.value.z - roadLegnth > (spawnz - (amount * roadLegnth)))
        {
            SpawnRoad();
            ReturnRoad();
            //  audioPlayer.PlayAudio();
            //score event SO
        }
    }

}
