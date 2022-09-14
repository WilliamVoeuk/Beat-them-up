using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    #region Champs
    [Header("Basic Input")]
    [SerializeField] InputActionReference _moveInput;
    [SerializeField] InputActionReference _JumpInput;
    [SerializeField] InputActionReference _AttackInput;
    [SerializeField] InputActionReference _RunInput;

    [Header("Advanced Input")]
    [SerializeField] InputActionReference _PickUp;
    [SerializeField] InputActionReference _Throw;

    [Header("Movement")]
    [SerializeField] float _speed;
    //[SerializeField] float _movingThreshold;
    [SerializeField] Animator _animation;
    [SerializeField] float _speedMultiplicator;
    [SerializeField] Rigidbody2D _rb;

    Vector3 direction;
    bool _isRunning;
    bool _isWalking;
    bool _onAir;
    bool _withCan;
    #endregion

    #region reset
    private void Reset()
    {
        _speed = 5f;
        _speedMultiplicator = 2.5f;
    }
    #endregion


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
        _AttackInput.action.started += Attack;

        //Jump
        _JumpInput.action.started += Jump;

        //PickUp
        _PickUp.action.started += Pickup;

        //PickUp
        _Throw.action.started += Throw;

    }
    

    void FixedUpdate()
    {
        _animation.SetBool("IsWalking", _isWalking);
        _animation.SetBool("IsRunning", _isRunning);
        _animation.SetBool("OnAir", _onAir);
        _animation.SetBool("IsWithCan", _withCan);


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
        _isWalking = true;
    }
    
    void EndMove(InputAction.CallbackContext obj)
    {
        direction = Vector2.zero;
        _isWalking = false;
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
    private void Attack(InputAction.CallbackContext obj)
    {
        _animation.SetTrigger("Attack");
    }

    #endregion

    #region Jump
    private void Jump(InputAction.CallbackContext obj)
    {
        _animation.SetTrigger("Jump");
        Debug.Log("Jump");
    }

    #endregion

    #region PickUp
    private void Pickup(InputAction.CallbackContext obj)
    {
        _animation.SetTrigger("PickUp");
        Debug.Log("Pickup");
    }

    #endregion

    #region Throw
    private void Throw(InputAction.CallbackContext obj)
    {
        _animation.SetTrigger("Throw");
        Debug.Log("Pickup");
    }
    #endregion


}
