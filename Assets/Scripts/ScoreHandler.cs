using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    float score = 0;
    UiManager uiManager;
    [SerializeField]private DifficultySO diffuclty;
    void Start()
    {
        diffuclty.value = DifficultySO.Diffuclty.easy;
        uiManager = GameObject.FindGameObjectWithTag("ui").GetComponent<UiManager>();

    }

    void Update()
    {
        
    }
    public void HandleDifficulty(int score)
    {
        //score++
       // uiManager.setScore();
        if (score > 10 && score < 20)
            diffuclty.value = DifficultySO.Diffuclty.meduim;
        else if (score > 20 && score < 30)
            diffuclty.value = DifficultySO.Diffuclty.hard;
        else if (score > 30 && score < 40)
            diffuclty.value = DifficultySO.Diffuclty.insane;
    }
}
