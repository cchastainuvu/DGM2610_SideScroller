using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnterEvent : MonoBehaviour
{
    public UnityEvent Event;

    public void OnTriggerEnter(Collider other)
    {
        Event.Invoke();
    }

}
