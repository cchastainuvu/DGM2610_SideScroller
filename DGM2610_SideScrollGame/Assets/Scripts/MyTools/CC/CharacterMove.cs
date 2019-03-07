using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CharacterController))]
public class CharacterMove : MonoBehaviour

{

    private CharacterController _controller;
    public MovePattern Pattern;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Pattern.Invoke(_controller, transform);
    }
}