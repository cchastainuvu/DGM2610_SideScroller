using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneMGR : MonoBehaviour
{
    public int Load;

    public void LoadLevel()
    {
        SceneManager.LoadScene(Load);
    }
    
    public void ExitLevel()
    {
        Application.Quit();
    }
    
}
