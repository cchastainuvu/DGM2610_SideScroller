using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTimeScale : MonoBehaviour 
{
    public void SlowTime()
    {
        Time.timeScale = 0.1F;
    }

    public void FreezeTime()
    {
        Time.timeScale = 0F;
    }

    public void NormalTime()
    {
        Time.timeScale = 1F;
    }
}
