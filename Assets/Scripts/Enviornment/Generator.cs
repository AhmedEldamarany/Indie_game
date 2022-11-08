using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Generator : MonoBehaviour
{
    [SerializeField] protected VectorSO PlayerPosition;
    protected Pool myPool;
    protected float spawnz;
    [SerializeField] protected float roadLegnth = 10;
    [Tooltip("Must be less than double the pool elements amount")]
    [SerializeField] protected int startingAmount = 5;
    protected Queue<PoolItem> activeRoads;
    protected Vector3 currentPosition;

    //AudioPlayer audioPlayer;



    protected void Init() //TODO Make virtual and add override in the init children
    {
        currentPosition = transform.position;
        spawnz = currentPosition.z;
        //myPool = gameObject.GetComponent<Pool>();

        { //making sure the first item is always emptyRoad prefab
            activeRoads = new Queue<PoolItem>();
            PoolItem newRoad = myPool.getItemAt(0);
            currentPosition.z = spawnz;
            newRoad.transform.position = currentPosition;
            activeRoads.Enqueue(newRoad);
            spawnz += roadLegnth;
        }

        for (int i = 0; i < startingAmount - 1; i++)
        {
            SpawnRoad();
        }
    }
    
    protected void SpawnRoad()
    {
        PoolItem newRoad = myPool.getRoad();
        if (newRoad == null)
        {
            Debug.LogError("Pool sent nothing");
            return;
        }

        currentPosition.z = spawnz;
        newRoad.transform.position = currentPosition;
        activeRoads.Enqueue(newRoad);
        spawnz += roadLegnth;
    }
    protected void ReturnRoad()
    {
        myPool.AddBack(activeRoads.Dequeue());
    }
    public void CleanSlate()
    {
        foreach (var road in activeRoads)
            myPool.AddBack(road);
    }
}
