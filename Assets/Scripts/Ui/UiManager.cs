using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] private  Text scoreText;
    [SerializeField] private  Text livesScore;
    [SerializeField] private ScoreSO score;
    [SerializeField] private IntSo lives;
    [SerializeField] MyEventSO GameOverEvent;
    private void Start()
    {
        InitCanvasValues();
        
    }
    public void InitCanvasValues()
    {
        scoreText.text = $"{score.value}";
        livesScore.text = lives.value.ToString("0");
    }

    public  void setScore()
    {
        // after scorehandlre did ++
        scoreText.text = $"{score.value}";
    }
    public  void TakeALife()
    {

        if (--lives.value > 0) //shouldn't really decrease it here.
            livesScore.text = lives.value.ToString("0");
        else
            GameOverEvent.Raise();

    }

   
}
