using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] private IntSo score;
    [SerializeField]UiManager uiManager;
    [SerializeField]private DifficultySO diffuclty;
    void Awake()
    {
        diffuclty.value = DifficultySO.Diffuclty.easy;
        score.value = 0;
        uiManager.setScore();
    }

    void Update()
    {
        
    }
    public void HandleDifficulty()
    {
        score.value++;
        uiManager.setScore();
        if (score.value > 10 && score.value < 25)
            diffuclty.value = DifficultySO.Diffuclty.meduim;
        else if (score.value > 25 && score.value < 40)
            diffuclty.value = DifficultySO.Diffuclty.hard;
        else if (score.value > 40 )
            diffuclty.value = DifficultySO.Diffuclty.insane;
    }
}
