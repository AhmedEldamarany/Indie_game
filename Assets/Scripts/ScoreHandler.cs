using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] private IntSo score;
    [SerializeField]UiManager uiManager;
    [SerializeField]private DifficultySO diffuclty;
    [SerializeField] int mediumStartingScore=5;
    [SerializeField] int hardStartingScore=20;
    [SerializeField] int insaneStartingScore=40;
    void Awake()
    {
        diffuclty.value = DifficultySO.Diffuclty.easy;
        score.value = 0;
        uiManager.setScore();
    }

    
    public void HandleDifficulty()
    {
        score.value++;
        uiManager.setScore();
        //why am i not using <= and >= ???????!
        if (score.value > mediumStartingScore && score.value < hardStartingScore)
            diffuclty.value = DifficultySO.Diffuclty.meduim;
        else if (score.value > hardStartingScore && score.value < insaneStartingScore)
            diffuclty.value = DifficultySO.Diffuclty.hard;
        else if (score.value > insaneStartingScore)
        {
            diffuclty.value = DifficultySO.Diffuclty.insane;
            //if score== winningScore you won
        }
    }
}
