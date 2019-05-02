using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
public class CharaController : MonoBehaviour
{
    
    private CharacterController _cc;
    private Vector3 _pos;

    private Ray _ray;
    private RaycastHit _hit;

    public FloatData MoveSpeed, JumpHeight, Gravity;

    public Animator PlayerAnimator;

    public AudioSource RunAudio, JumpAudio, CrouchAudio;
    
    private void Start()
    {
        _cc = GetComponent<CharacterController>();
        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    }
  
    private void FixedUpdate()
    {  
         _pos.x = MoveSpeed.value * Time.deltaTime;
         _cc.Move(_pos);

        if (!_cc.isGrounded)
        {
            _pos.y -= Gravity.value * Time.deltaTime;
            PlayerAnimator.SetBool("Jumping", false);
            PlayerAnimator.SetBool("Grounded", false);
        }
        
        else if (_cc.isGrounded)
        {
            PlayerAnimator.SetBool("Grounded", true);
            PlayerAnimator.SetBool("Jumping", false);

            if (!RunAudio.isPlaying && !CrouchAudio.isPlaying)
            {
                RunAudio.Play();
            }
        }
    }
    
    public void Jump()
    {
        if (_cc.isGrounded)
        {
                print("I'm working...");
                _pos.y = JumpHeight.value * Time.deltaTime;
                _cc.Move(_pos);
            
                PlayerAnimator.SetBool("Jumping", true);
            
                RunAudio.Pause();
                CrouchAudio.Pause();
                JumpAudio.Play();
        }
        
        
     }

    public void Crouch()
    {
        if (_cc.isGrounded)
        {
            transform.localScale = new Vector3(1F, 0.5F, 1F);
            PlayerAnimator.SetBool("Crouching", true);
            
            RunAudio.Pause();
            JumpAudio.Pause();
            
            CrouchAudio.Play();
        }
        
        
    }

    public void ResetScale()
    {
        transform.localScale = new Vector3(1F, 1F, 1F);
        PlayerAnimator.SetBool("Crouching", false);
        
        CrouchAudio.Pause();
    }
}


