using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] Animator _animation;

    [Header ("Script Link Dependance")]
    [SerializeField] Movement movement;
    [SerializeField] Jump jump;
    [SerializeField] Attack attack;
    public void Load ()
    {
        _animation.SetTrigger ("Jump");
        Debug.Log ("Jump");
    }


    void FixedUpdate()
    {
        
    }
}
