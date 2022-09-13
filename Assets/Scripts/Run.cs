using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Run : MonoBehaviour
{
    [SerializeField] Animator _animation;
    [SerializeField] float _speedMultiplicator;
    [SerializeField] float _speed;

    bool _isRunning;

    internal void launch ()
    {
        throw new NotImplementedException ();
    }

    internal void Launch ()
    {
        throw new NotImplementedException ();
    }

    //void FixedUpdate()
    //{
    //    _animation.SetBool ("IsRunning", _isRunning);
    //
    //    if (_isRunning)
    //    {
    //        _rb.MovePosition (transform.position + (direction * Time.fixedDeltaTime * (_speed * _speedMultiplicator)));
    //    }
    //    else
    //    {
    //        _rb.MovePosition (transform.position + (direction * Time.fixedDeltaTime * _speed));
    //    }
    //}




    
}
