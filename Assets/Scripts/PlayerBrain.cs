using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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


    /* ON VA AVOIR UN PETIT SOUCIS IL VA FALLOIR LES RENOMMER
    //[SerializeField] Pickup pickup;
    //[SerializeField] Throw throw; */
    #endregion

    #region Start
    void Start ()
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

        /*//PickUp
        _PickUp.action.started += Pickup;

        //PickUp
        _Throw.action.started += Throw;*/


    }
    #endregion


    #region Move
    private void StartMove(InputAction.CallbackContext obj)
    {
        movement.SetDirection(obj.ReadValue<Vector2>());
    }

    private void EndMove(InputAction.CallbackContext obj)
    {
        movement.SetDirection(Vector2.zero);
    }
    #endregion


    #region Run
    private void RunStart (InputAction.CallbackContext obj)
    {
        movement.Load();
    }


    private void EndRun (InputAction.CallbackContext obj)
    {
        movement.UnLoad();        
    }
    #endregion


    #region Attack
    private void Attack (InputAction.CallbackContext obj)
    {
        attack.Launch();
    }
    #endregion


    #region Jump
    private void Jump (InputAction.CallbackContext obj)
    {
        jump.Load ();
    }
    #endregion


    //#region Pickup
    //private void Pickup (InputAction.CallbackContext obj)
    //{
    //    pickup.Take ();
    //}
    //#endregion
    //
    //
    //#region Throw
    //private void Throw (InputAction.CallbackContext obj)
    //{
    //    throw.Take ();
    //}
    //#endregion


}
