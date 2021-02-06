using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] private  Text scoreText;
    [SerializeField] private  Text livesScore;
    private int score;
    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString("0");
    }


    public  void setScore()
    {
       // after scorehandlre did ++
        scoreText.text =score.ToString("0");
    }
    public  void TakeALife()
    {
        livesScore.text = (int.Parse(livesScore.text) - 1).ToString("0");
    }
}
