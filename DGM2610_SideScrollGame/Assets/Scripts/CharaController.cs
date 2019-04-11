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

    private void FixedUpdate()
    {  
         _pos.x = MoveSpeed.value * Time.deltaTime;
//       _pos.z = 0F;
         _cc.Move(_pos);

        if (!_cc.isGrounded)
        {
            _pos.y -= Gravity.value * Time.deltaTime;
        }
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

    public void Crouch()
    {
        transform.localScale = new Vector3(1F, 0.5F, 1F);
    }

    public void ResetScale()
    {
        transform.localScale = new Vector3(1F, 1F, 1F);
    }
}


