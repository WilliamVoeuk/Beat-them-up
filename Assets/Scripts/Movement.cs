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
        _direction = vector2.normalized;
    }

    public void Load ()
    {
        _animation.SetBool ("IsRunning", true);
        _isRunning = true;
    }
    public void UnLoad ()
    {
        _isRunning = false;
        _animation.SetBool ("IsRunning", false);
    }



    private void FixedUpdate ()
    {
        _animation.SetBool ("IsWalking", _isWalking);
        //_animation.SetBool ("IsRunning", _isRunning);
        
        if (_direction.magnitude > 0)
        {
            _rb.MovePosition (transform.position + (_direction * Time.fixedDeltaTime * _speed ));
            _isWalking = true;
        }
        else
        {
            _isWalking = false;            
        }
        
        
        if (_isRunning)
        {
            _rb.MovePosition (transform.position + (_direction * Time.fixedDeltaTime * (_speed * _speedMultiplicator)));
            _isRunning = true;

        }
        else
        {
            _isRunning = false;
        }
    }

    #endregion
}