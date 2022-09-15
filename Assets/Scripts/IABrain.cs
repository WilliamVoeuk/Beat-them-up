using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class IABrain : MonoBehaviour
{
    [Header ("Script Link Dependance")]
    [SerializeField] Movement movement;
    [SerializeField] Attack attack;

    [SerializeField] float _limitDistance;
    [SerializeField] float _agroDistance;


    PlayerTag Player;

    public void SetTarget (PlayerTag player)
    {
        Player = player;
        // Faire le code qui decide d'aller vers le joueur
        //movement.SetDirection (Player.transform.position - transform.position);
    }

    internal void Removetarget (PlayerTag player)
    {
        Player = null;
    }


    private void Update ()
    {
        if(Player != null)// On connait notre joueur
        {
            var distanceToPlayer = Vector2.Distance (Player.transform.position, transform.position);
            if (distanceToPlayer < _limitDistance)
            {
                movement.SetDirection (Vector2.zero);
                attack.Launch ();
            }
            else
            {
                if (distanceToPlayer < _agroDistance)
                {
                    movement.SetDirection (Player.transform.position - transform.position);
                }
            }

        }
        else
        {
            movement.SetDirection (Vector2.zero);
        }
    }

}
