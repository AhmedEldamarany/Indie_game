using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] private  Text scoreText;
    [SerializeField] private  Text livesScore;
    [SerializeField] private IntSo score;
    [SerializeField] private IntSo Lives;
    private void Start()
    {
        
        scoreText.text = "0";
    }


    public  void setScore()
    {
        // after scorehandlre did ++
        scoreText.text = $"{score.value}";
    }
    public  void TakeALife()
    {
        livesScore.text = (int.Parse(livesScore.text) - 1).ToString("0");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
