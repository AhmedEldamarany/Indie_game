using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="SO/intSO")]
public class IntSo : ScriptableObject
{
    public int value;
    private void OnDisable()
    {
        value = 0;
    }
}
