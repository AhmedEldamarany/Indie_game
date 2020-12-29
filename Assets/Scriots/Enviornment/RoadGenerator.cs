using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    private Transform Player;
    RoadsPool roadsPool;
    private float spawnz;
    private float roadLegnth = 10;
    private int amount = 1;
    Queue<GameObject> activeRoads;
    void Start()
    {
        roadsPool = gameObject.GetComponent<RoadsPool>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        activeRoads = new Queue<GameObject>();
        for (int i = 0; i < amount; i++)
        {
            SpawnRoad();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.position.z-roadLegnth > (spawnz - (amount * roadLegnth)))
        {
            SpawnRoad();
            ReturnRoad();
        }
    }
    private void SpawnRoad()
    {
        GameObject newRoad = roadsPool.getRoad();
        if (newRoad == null)
            return;
        newRoad.SetActive(true);

        newRoad.transform.position = Vector3.forward * spawnz;
        activeRoads.Enqueue(newRoad);
        spawnz += roadLegnth;

    }
    private void ReturnRoad()
    {
        roadsPool.Add(activeRoads.Dequeue());

    }
}
