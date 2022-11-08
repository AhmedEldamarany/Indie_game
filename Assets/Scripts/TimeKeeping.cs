using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeKeeping : MonoBehaviour
{
    bool isOver = false;
    private void Awake()
    {
        Time.timeScale = 0;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
    private void freeze()
    {
        Time.timeScale = 0;
    }
    private void unFreeze()
    {
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        freeze();
        isOver = true;
    }
    public void NewGame()
    {
        unFreeze();
        isOver = false;
    }
    public void Pause(bool pause)
    {
        if (isOver) return;
        else
            if (pause)
            freeze();
        else
            unFreeze();
    }

}
