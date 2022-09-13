using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float _speed;
    //[SerializeField] float _movingThreshold;
    [SerializeField] Animator _animation;
    [SerializeField] float _speedMultiplicator;
    [SerializeField] Rigidbody2D _rb;

    Vector3 _direction;

    bool _isWalking;
    bool _isRunning;

    #region Move
    internal void SetDirection(Vector2 vector2)
    {
        _direction = vector2;

        //else if (_direction.magnitude < 0)
        //{
        //    _rb.MovePosition(transform.position + (_direction * Time.fixedDeltaTime * _speed));
        //    _isWalking = true;
        //    _isRunning = false;
        //}

    }
    private void FixedUpdate ()
    {
        _animation.SetBool ("IsWalking", _isWalking);
        //_animation.SetBool ("IsRunning", _isRunning);
        
        if (_direction.magnitude > 0)
        {
            _rb.MovePosition (transform.position + (_direction * Time.fixedDeltaTime * (_speed * _speedMultiplicator)));
            _isWalking = true;
            //_isRunning = true;
        }
        else
        {
            _isWalking = false;
        }
    }

    #endregion
}