using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerEvent : MonoBehaviour 
{

    public NameID PlayerID;
    public Animator EnemyAnimator;

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.GetComponent<ObjectID>().ID == PlayerID)
        {
            EnemyAnimator.SetBool("Chomping", true);
        }
    }

    private void OnTriggerExit(Collider obj)
    {
        if (obj.GetComponent<ObjectID>().ID == PlayerID)
        {
            EnemyAnimator.SetBool("Chomping", false);
        }
    }
}
