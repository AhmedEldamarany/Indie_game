using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
    public void TimeSpeed(float scale)
    {
        Time.timeScale = scale;
    }
    public void Exit()
    {
        Application.Quit();
    }
}
