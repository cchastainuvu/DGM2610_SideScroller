using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRun : MonoBehaviour
{
    public FloatData EnemySpeed, SlowSpeed, SpeedReset;

    public void Start()
    {
        SpeedReset = EnemySpeed;
    }
    
    private void FixedUpdate()
    {
        transform.Translate(EnemySpeed.Value * Time.deltaTime, 0F, 0F);
    }

    public void Slow()
    {
        EnemySpeed = SlowSpeed;
    }

    public void ResetSpeed()
    {
        EnemySpeed = SpeedReset;
    }
}
