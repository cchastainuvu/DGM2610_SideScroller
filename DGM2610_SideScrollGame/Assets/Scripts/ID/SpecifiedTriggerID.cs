using System;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Events;

public class SpecifiedTriggerID : MonoBehaviour
{
    public NameID SpecifiedID;
    public UnityEvent OnMatch;

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.GetComponent<ObjectID>().ID == SpecifiedID)
        {
            OnMatch.Invoke();
        }
    }
}
