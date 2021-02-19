using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoadActOne()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadActTwo()
    {
        SceneManager.LoadScene(2);
    }
}
