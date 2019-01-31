using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movements : MonoBehaviour
{
    public Rigidbody Rigidbody;
    
    public FloatData JumpHeight, ForwardThrust;
    
    public void Jump()
    {
        Rigidbody.AddForce(ForwardThrust.value, JumpHeight.value * Time.deltaTime, 0F, ForceMode.Impulse);
    }
}
