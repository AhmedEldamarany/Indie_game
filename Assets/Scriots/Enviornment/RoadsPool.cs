using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadsPool : MonoBehaviour
{
    public List<GameObject> roads;
    GameObject currentRoad;
    private int index;
    void Start()
    {
        int count = roads.Count;
        for (int i = 0; i < count; i++)
            roads.Add(roads[i]);
        for (int i = 0; i < roads.Count; i++)
        {
            roads[i] = Instantiate(roads[i]);
            roads[i].transform.SetParent(transform);
            roads[i].SetActive(false);
        }
    }
    public GameObject getRoad()
    {
        if (roads.Count > 0)
        {
            index = Random.Range(0, roads.Count);
            currentRoad = roads[index];
            roads.RemoveAt(index);
            return currentRoad;
        }
        else
            return null;
    }
    public void Add(GameObject road)
    {
        if (road != null)
            roads.Add(road);
        road.SetActive(false);
    }


}
