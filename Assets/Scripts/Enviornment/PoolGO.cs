using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolGO : MonoBehaviour //Mine
{
    public List<PoolItem> roads;
    PoolItem currentRoad;
    private int index;
   
    void Start()
    {
        int count = roads.Count;
        for (int i = 0; i < count; i++)
            roads.Add(roads[i]); //Doubling the list by adding every element again
        for (int i = 0; i < roads.Count; i++)
        {
            roads[i] = Instantiate(roads[i]);
            roads[i].transform.SetParent(transform);
            roads[i].gameObject.SetActive(false);
            
        }
    }
    public PoolItem getRoad()
    {
        if (roads.Count > 0)
        {
            index = Random.Range(0, roads.Count);
            currentRoad = roads[index];
            roads[index].Activate();
            roads.RemoveAt(index);
            return currentRoad;
        }
        else
            return null;
    }
    public void AddBack(PoolItem road)
    {
        if (road != null)
        {
            roads.Add(road);
            road.Deactivate();
       
        }
    }

}
