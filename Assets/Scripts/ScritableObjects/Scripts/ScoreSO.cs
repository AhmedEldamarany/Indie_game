using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "SO/ScoreSO")]

public class ScoreSO : ScriptableObject
{
    public int value;
    [SerializeField] private int startingValue = 1;
    private void OnDisable()
    {
        value = startingValue;
    }
    private void OnEnable()
    {
        value = startingValue;

    }
}
