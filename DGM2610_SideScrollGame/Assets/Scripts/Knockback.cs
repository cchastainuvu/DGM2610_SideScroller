using System.Collections;
using System.Collections.Generic;
using Boo.Lang.Environments;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    public Rigidbody Rigidbody;

    public FloatData Thrust;
    
    public void OnTriggerEnter(Collider other)
    {
        Rigidbody.AddForce(Thrust.value, 0F, 0F, ForceMode.Impulse);
    }
    
    
}
