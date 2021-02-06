using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Generator : MonoBehaviour //make it generic and inherit from it in roadgenerator and sandgenerator
    // implement the start and update in every subclass but keep spawn and return here
{
    [SerializeField] protected VectorSO PlayerPosition;
   protected PoolGO roadsPool;
    protected float spawnz;
   [SerializeField] protected float roadLegnth = 10;
   [SerializeField] protected int amount = 5;
   protected Queue<PoolItem> activeRoads;
    protected Vector3 currentPosition;

    //AudioPlayer audioPlayer;


    void Start()
    {
        currentPosition = transform.position;
        // audioPlayer = GetComponent<AudioPlayer>();
        roadsPool = gameObject.GetComponent<PoolGO>();

        activeRoads = new Queue<PoolItem>();
        for (int i = 0; i < amount; i++)
        {
            SpawnRoad();
        }
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    if (PlayerPosition.value.z - roadLegnth > (spawnz - (amount * roadLegnth)))
    //    {
    //        SpawnRoad();
    //        ReturnRoad();
    //      //  audioPlayer.PlayAudio();
    //        //score event SO
    //    }
    //}
    protected void SpawnRoad()
    {
        PoolItem newRoad = roadsPool.getRoad();
        if (newRoad == null)
            return;
        currentPosition.z = spawnz;
        newRoad.transform.position = currentPosition;



        // //todo when 
        activeRoads.Enqueue(newRoad);
        spawnz += roadLegnth;

    }
    protected void ReturnRoad()
    {
        roadsPool.AddBack(activeRoads.Dequeue());



    }
}
