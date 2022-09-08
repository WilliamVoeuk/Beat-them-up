using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Input")]
    [SerializeField] InputActionReference _moveInput;

    [Header("Movement")]
    [SerializeField] Transform _root;
    [SerializeField] float _speed;
    [SerializeField] float _movingThreshold;

    Vector2 _playerMovement;

    void Start()
    {
        _moveInput.action.started += StartMove;
        _moveInput.action.performed += UpdateMove;
        _moveInput.action.canceled += EndMove;
    }
    void FixedUpdate()
    {
        Vector2 direction = new Vector2(_playerMovement.x, _playerMovement.y);
        _root.transform.Translate(direction * Time.fixedDeltaTime * _speed, Space.World);
    }
    void StartMove(InputAction.CallbackContext obj)
    {
        _playerMovement = obj.ReadValue<Vector2>();
    }
    void UpdateMove(InputAction.CallbackContext obj)
    {
        _playerMovement = obj.ReadValue<Vector2>();
    }
    void EndMove(InputAction.CallbackContext obj)
    {
        _playerMovement = new Vector2(0, 0);
    }
}
