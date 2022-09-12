using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackableTrigger : MonoBehaviour
{
    [SerializeField] BoxCollider2D _myCollider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.attachedRigidbody == _myCollider.attachedRigidbody) return;
        // if (collision.isTrigger) return;



    }
}
