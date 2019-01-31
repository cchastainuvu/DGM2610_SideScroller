using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseClickEvent : MonoBehaviour
{
    public UnityEvent Event;

    public void OnMouseDown()
    {
        Event.Invoke();
    }
}
