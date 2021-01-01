using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    private Text scoreText;
    private void Start()
    {
        scoreText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
     public void setScore( float score)
    {
        scoreText.text = score.ToString("0");
    }
}
