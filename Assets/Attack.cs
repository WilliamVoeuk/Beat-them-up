using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Attack : MonoBehaviour
{
    #region Attack
    [SerializeField] Animator _animation;

    public void Launch ()
    {
        _animation.SetTrigger ("Attack");
    }


    #endregion
}
