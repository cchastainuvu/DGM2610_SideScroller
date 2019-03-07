using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class MovePattern : ScriptableObject
{
    public FloatData Gravity;
    public FloatData MoveX, MoveY, MoveZ, Jump;
    public FloatData RotX, RotY, RotZ;

    private Vector3 _moveDirection;
    private Vector3 _rotDirection;
    
    public virtual void Invoke(CharacterController controller, Transform transform)
    {
        if (controller.isGrounded)
        {
            Move(transform);
        }

        Move(controller);
    }

    protected void Move(CharacterController controller)
    {
        _moveDirection.y -= Gravity.Value * Time.deltaTime;
        controller.Move(_moveDirection * Time.deltaTime);
    }

    protected void Move(Transform transform)
    {
        _moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
        transform.Rotate(_rotDirection);
        _rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
        _moveDirection = transform.TransformDirection(_moveDirection);
    }
}
