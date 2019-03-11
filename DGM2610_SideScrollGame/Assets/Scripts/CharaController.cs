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

    public NameID SpecifiedID;

    private void Start()
    {
        _cc = GetComponent<CharacterController>();
        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    private void Update()
    {  
         _pos.y -= Gravity.value * Time.deltaTime;
         _pos.x = MoveSpeed.value * Time.deltaTime;
         _cc.Move(_pos);
    }

    public void Jump()
    {
        if (_cc.isGrounded)
        {
                print("I'm working...");
                _pos.y = JumpHeight.value * Time.deltaTime;
                _cc.Move(_pos);
        }
     }
}


