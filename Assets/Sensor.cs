using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    [SerializeField] IABrain _IAbrain;
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.attachedRigidbody.TryGetComponent<PlayerTag> (out var player))
        {
            _IAbrain.SetTarget (player);
        }
    }
    private void OnTriggerExit2D (Collider2D collision)
    {
        if (collision.attachedRigidbody.TryGetComponent<PlayerTag> (out var player))
        {
            _IAbrain.Removetarget (player);
        }
            
    }
}
