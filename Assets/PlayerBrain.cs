using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBrain : MonoBehaviour
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


    [Header("Script Link Dependance")]
    [SerializeField] Movement movement;
    [SerializeField] Jump jump;
    [SerializeField] Attack attack;
    [SerializeField] Run run;
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
        
        ////PickUp
        //_PickUp.action.started += Pickup;
        //
        ////PickUp
        //_Throw.action.started += Throw;
    }

    private void Jump (InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException ();
    }

    private void Attack (InputAction.CallbackContext obj)
    {
        attack.Launch();
    }

    private void RunStart (InputAction.CallbackContext obj)
    {
        run.SetDirection(obj.ReadValue<Vector2>());
    }

    private void EndRun (InputAction.CallbackContext obj)
    {
        
    }


    private void StartMove(InputAction.CallbackContext obj)
    {
        movement.SetDirection(obj.ReadValue<Vector2>());
    }

    private void EndMove(InputAction.CallbackContext obj)
    {
        movement.SetDirection(Vector2.zero);
    }



}
