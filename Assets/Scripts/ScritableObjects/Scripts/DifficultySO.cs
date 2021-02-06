using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/DifficultySO")]

public class DifficultySO : ScriptableObject
{
    public enum Diffuclty
    {
        easy,
        meduim,
        hard,
        insane
    }
    public Diffuclty value;
}
