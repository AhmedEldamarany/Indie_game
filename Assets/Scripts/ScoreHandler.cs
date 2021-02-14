using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField] private IntSo score;
    [SerializeField]UiManager uiManager;
    [SerializeField]private DifficultySO diffuclty;
    void Start()
    {
        diffuclty.value = DifficultySO.Diffuclty.easy;
        //uiManager = GameObject.FindGameObjectWithTag("ui").GetComponent<UiManager>(); //

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
