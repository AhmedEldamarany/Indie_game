using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] private ScoreSO score;
    [SerializeField]UiManager uiManager;
    [SerializeField]private DifficultySO diffuclty;
    [SerializeField] int mediumStartingScore=5;
    [SerializeField] int hardStartingScore=20;
    [SerializeField] int insaneStartingScore=40;
    [SerializeField] bool isEndless;
    [SerializeField] int winningScore;
    [SerializeField] MyEventSO WinningEvent;

    void Start()
    {
        initDifficulty();
        
    }
    public void initDifficulty()
    {
        diffuclty.value = DifficultySO.Diffuclty.easy;

    }

    public void HandleDifficulty()
    {
        score.value++;
        uiManager.setScore();

        if(!isEndless)
        {
            if (score.value >= winningScore)
                WinningEvent.Raise(); 

        }
        
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
