using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="SO/intSO")]
public class IntSo : ScriptableObject
{
    public int value;
    [SerializeField] private int startingValue=1;
    private void OnDisable()
    {
        value = startingValue;
    }
    private void OnEnable()
    {
        value = startingValue;

    }


}
