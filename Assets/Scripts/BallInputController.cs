using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallInputController : MonoBehaviour
{
    [HideInInspector] public Vector3 BallDirection;

    private PlayerInput _playerInput;
    private InputAction _clickAction;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        _clickAction = _playerInput.actions["Click"];
    }

    private void Start()
    {
        BallDirection = Vector3.left;
    }

    private void OnEnable()
    {
        _clickAction.performed += _ => HandleBallInput();
    }

    private void OnDisable()
    {
        _clickAction.performed -= _ => HandleBallInput();
    }

    private void HandleBallInput()
    {
        ChangeBallDirection();
        Debug.Log("Click!");
    }

    private void ChangeBallDirection()
    {
        if (BallDirection.x == -1)
        {
            BallDirection = Vector3.forward;
        }
        else
        {
            BallDirection = Vector3.left;
        }
    }
}
