using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour 
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
    public PoolItem getItemAt(int index)
    {
        if (elements.Count > 0)
        {
            currentRoad = elements[index];
            currentRoad.Activate();
            elements.RemoveAt(index);
            return currentRoad;
        }
        else
        {
            Debug.LogWarning("Pool is empty");
            return null;
        }
    }
    public PoolItem getRoad()
    {
        if (elements.Count > 0)
        {
            index = Random.Range(0, elements.Count);
            currentRoad = elements[index];
            currentRoad.Activate();
            elements.RemoveAt(index);
            return currentRoad;
        }
        else
        {
            Debug.LogWarning("Pool is empty");
            return null;
        }
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
