using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Header("Input")]
    [SerializeField] InputActionReference _moveInput;
    [SerializeField] InputActionReference _JumpInput;
    [SerializeField] InputActionReference _AttackInput;
    [SerializeField] InputActionReference _RunInput;

    [Header("Movement")]
    [SerializeField] Transform _root;
    [SerializeField] float _speed;
    //[SerializeField] float _movingThreshold;
    [SerializeField] float _speedMultiplicator;
    [SerializeField] Rigidbody2D _rb;


    Vector3 direction;
    bool _isRunning;
    bool _isAttack;//To do : rajouter l'animation.
    bool _isJumping;

    void Start()
    {
        //Move
        _moveInput.action.started += StartMove;
        _moveInput.action.performed += StartMove;
        _moveInput.action.canceled += EndMove;

        //Run
        _RunInput.action.started += RunStart;
        _RunInput.action.canceled += EndRun;

        //Attack
        _AttackInput.action.started += StartAttack;
        _AttackInput.action.canceled += EndAttack;

        //Jump
        _JumpInput.action.started += JumpStart;
        _JumpInput.action.canceled += EndJump;
    }
    

    void FixedUpdate()
    {
        if (_isRunning)
        {
            _rb.MovePosition(transform.position + (direction * Time.fixedDeltaTime * (_speed * _speedMultiplicator)));
        }
        else
        {
            _rb.MovePosition(transform.position + (direction * Time.fixedDeltaTime * _speed));
        }
    }
    #region Move
    void StartMove(InputAction.CallbackContext obj)
    {
        direction = obj.ReadValue<Vector2>();
    }
    
    void EndMove(InputAction.CallbackContext obj)
    {
        direction = Vector2.zero;
    }
    #endregion

    #region Run
    private void RunStart(InputAction.CallbackContext obj)
    {
        _isRunning = true;
        Debug.Log("Run");
    }

    private void EndRun(InputAction.CallbackContext obj)
    {
        _isRunning = false;
        Debug.Log("NoRun");

    }
    #endregion

    #region Attack
    private void StartAttack(InputAction.CallbackContext obj)
    {
        _isAttack = true;
    }

    private void EndAttack(InputAction.CallbackContext obj)
    {
        _isAttack = false;        
    }
    #endregion

    #region Jump
    private void JumpStart(InputAction.CallbackContext obj)
    {
        _isJumping = true;
    }

    private void EndJump(InputAction.CallbackContext obj)
    {
        _isJumping = false;
    }
    #endregion
}
