using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerRaycastEvent : MonoBehaviour
{
    private Ray _ray;
    private RaycastHit _hit;

    public UnityEvent Event;

    void Update()
    {
        _ray = Camera.main.ScreenPointToRay((Input.mousePosition));

        if (Physics.Raycast(_ray, out _hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (_hit.collider.tag == "Player")
                {
                    print(_hit.collider.name);
                    Event.Invoke(); 
                }
            }
        }
    }

}
