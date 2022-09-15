using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    #region Attack
    [SerializeField] Animator _animation;
    [SerializeField] Health health;
    [SerializeField] HitContact _hitbox;

    public void Launch ()
    {
        _animation.SetTrigger ("Attack");
        _hitbox.ApplyDamage ();
    }

    private void FixedUpdate ()
    {
        
    }


    #endregion
}
