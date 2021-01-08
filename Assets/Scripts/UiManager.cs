using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] private  Text scoreText;
    [SerializeField] private  Text livesScore;
   
  


    // Update is called once per frame
    public  void setScore(float score)
    {
        scoreText.text = score.ToString("0");
    }
    public  void TakeALife()
    {
        livesScore.text = (int.Parse(livesScore.text) - 1).ToString("0");
    }
}
