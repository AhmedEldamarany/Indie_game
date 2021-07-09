using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : Generator
{
    [SerializeField] MyEventSO scoreIncrease;
    [SerializeField] ScoreSO score;
    [SerializeField] IntSo lives;
    private bool isPlaying = false;
    
    public void Init(bool isDeadly)
    {
        SelectLeveL(isDeadly);
        score.value = 0;
        lives.value = 5;
        Init();
        isPlaying = true;
    }
    private void SelectLeveL(bool isDeadly)
    {
        if (isDeadly)
            myPool = gameObject.GetComponent<DeadlyPool>();
        else
            myPool = gameObject.GetComponent<NormalPool>();
    }
    void Update()
    {
        
        if (isPlaying)
        {
            if (PlayerPosition.value.z - roadLegnth * 1.5f > (spawnz - (startingAmount * roadLegnth)))
            {
                SpawnRoad();
                ReturnRoad();
                scoreIncrease.Raise();
            }
        }
    }

}


