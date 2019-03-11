using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    private Ray _ray;
    private RaycastHit _hit;

    void Update()
    {
        _ray = Camera.main.ScreenPointToRay((Input.mousePosition));

        if (Physics.Raycast(_ray, out _hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                print(_hit.collider.name);
            }
        }
    }

}
