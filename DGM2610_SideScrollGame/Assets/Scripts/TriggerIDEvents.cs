using System;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.Events;

public class TriggerIDEvents : MonoBehaviour
{
    public NameID SpecifiedID;
    public UnityEvent EnterEvent, ExitEvent;

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.GetComponent<ObjectID>().ID == SpecifiedID)
        {
            EnterEvent.Invoke();
        }

    }

    private void OnTriggerExit(Collider obj)
    {
        if (obj.GetComponent<ObjectID>().ID == SpecifiedID)
        {
            ExitEvent.Invoke();
        }
    }
}
