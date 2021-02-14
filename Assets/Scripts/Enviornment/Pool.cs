using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour //Mine
{
    public List<PoolItem> elements;
    PoolItem currentRoad;
    private int index;
   
    void Start()
    {
        int count = elements.Count;
        for (int i = 0; i < count; i++)
            elements.Add(elements[i]); //Doubling the list by adding every element again
        for (int i = 0; i < elements.Count; i++)
        {
            elements[i] = Instantiate(elements[i]);
            elements[i].transform.SetParent(transform);
            elements[i].gameObject.SetActive(false);
            
        }
    }
    public PoolItem getRoad()
    {
        if (elements.Count > 0)
        {
            index = Random.Range(0, elements.Count);
            currentRoad = elements[index];
            elements[index].Activate();
            elements.RemoveAt(index);
            return currentRoad;
        }
        else
            return null;
    }
    public void AddBack(PoolItem road)
    {
        if (road != null)
        {
            elements.Add(road);
            road.Deactivate();
       
        }
    }

}
