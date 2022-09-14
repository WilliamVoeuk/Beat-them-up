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
            _IAbrain.SetDirection (player);
        }
    }
    private void OnTriggerExit2D (Collider2D collision)
    {
            _IAbrain.SetDirection (Vector2.zero);        
    }
}
