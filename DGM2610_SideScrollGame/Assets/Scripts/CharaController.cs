using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharaController : MonoBehaviour
{
    private CharacterController _cc;
    private Vector3 _pos;

    private Ray _ray;
    private RaycastHit _hit;
    
    public FloatData MoveSpeed, JumpHeight, Gravity;

    private void Start()
    {
        _cc = GetComponent<CharacterController>();
        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    private void Update()
    {
        if (_cc.isGrounded)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Physics.Raycast(_ray, out _hit))
                {
                    _pos.y = JumpHeight.value * Time.deltaTime;
//                  _pos.x = MoveSpeed.value * Time.deltaTime;
                    _cc.Move(_pos);
                }
                
            }
        }
        
        else
        {
            _pos.y -= Gravity.value * Time.deltaTime;
           
        }
        
         _pos.x = MoveSpeed.value * Time.deltaTime;
        _cc.Move(_pos);
    }
}

