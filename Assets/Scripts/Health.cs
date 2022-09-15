using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int _healthMax;
    [SerializeField] int _currentHealth;

    public int MaxHealth
    {
        get { return _healthMax; }
    }
    public int CurrentHealth
    {
        get { return _currentHealth; }
    }

    private void Start ()
    {
        _currentHealth = _healthMax;
    }

    public void Damage(int dam)
    {
        _currentHealth -= dam;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HitContact foundTag;
        foundTag = collision.attachedRigidbody.GetComponent<HitContact>();
        if (foundTag != null)
        {
            Debug.Log("tagged");
        }
        Debug.Log("yohoho");

    }
}
