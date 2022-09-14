using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IABrain : MonoBehaviour
{
    [Header ("Script Link Dependance")]
    [SerializeField] Movement movement;
    [SerializeField] Attack attack;

    [SerializeField] PlayerTag Player;

    public void SetDirection (PlayerTag player)
    {
        // Faire le code qui decide d'aller vers le joueur
        movement.SetDirection (Player.transform.position - transform.position);
    }
}
