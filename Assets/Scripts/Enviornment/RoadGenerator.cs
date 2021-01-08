using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum Diffuclty
{
    easy,
    meduim,
    hard,
    insane
}
public class RoadGenerator : MonoBehaviour
{
    private Transform Player;
    RoadsPool roadsPool;
    private float spawnz;
    private float roadLegnth = 10;
    private int amount = 5;
    Queue<GameObject> activeRoads;
    float score = 0;
    UiManager uiManager;
    AudioPlayer audioPlayer;
    private Diffuclty diffuclty;
    void Start()
    {
        diffuclty = Diffuclty.easy;
        audioPlayer = GetComponent<AudioPlayer>();
        roadsPool = gameObject.GetComponent<RoadsPool>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        activeRoads = new Queue<GameObject>();
        for (int i = 0; i < amount; i++)
        {
            SpawnRoad();
        }
        uiManager = GameObject.FindGameObjectWithTag("ui").GetComponent<UiManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.position.z - roadLegnth > (spawnz - (amount * roadLegnth)))
        {
            SpawnRoad();
            ReturnRoad();
            audioPlayer.PlayAudio();
        }
    }
    private void SpawnRoad()
    {
        GameObject newRoad = roadsPool.getRoad();
        if (newRoad == null)
            return;
        newRoad.SetActive(true);
        newRoad.transform.position = Vector3.forward * spawnz;

        switch (diffuclty)
        {
            case Diffuclty.meduim:
                newRoad.GetComponent<rotate>().enabled = true;
                break;
            case Diffuclty.hard:
                newRoad.GetComponent<move>().enabled = true;
                break;
            case Diffuclty.insane:
                newRoad.GetComponent<rotate>().enabled = true;
                newRoad.GetComponent<move>().enabled = true;
                break;
        }
        // //todo when 
        activeRoads.Enqueue(newRoad);
        spawnz += roadLegnth;

    }
    private void ReturnRoad()
    {
        roadsPool.Add(activeRoads.Dequeue());
        uiManager.setScore(++score);

        if (score > 10 && score < 20)
            diffuclty = Diffuclty.meduim;
        else if (score > 20 && score < 30)
            diffuclty = Diffuclty.hard;
        else if (score > 30 && score < 40)
            diffuclty = Diffuclty.insane;
    }
}
