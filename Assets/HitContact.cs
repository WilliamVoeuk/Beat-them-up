using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitContact : MonoBehaviour
{
    [SerializeField] Attack Attack;
    [SerializeField] int _damageAmount;

    [SerializeField] List<Health> healths;

    private void OnTriggerEnter2D (Collider2D collision)
    {
        Debug.Log ("fils de ta grand-mere");
        if (collision.TryGetComponent<Health>(out var h))
        {
            healths.Add(h);
            Debug.Log ("h� ho tu m'as attaqu�");
        }
    }

    private void OnTriggerExit2D (Collider2D collision)
    {
        Debug.Log ("fils de ta grand-mere");
        if (collision.TryGetComponent<Health> (out var h))
        {
            healths.Remove (h);
            Debug.Log ("h� ho tu m'as attaqu�");
        }
    }

    public void ApplyDamage()
    {
        foreach(Health health in healths)
        {
            health.Damage (_damageAmount);
        }
    }
}
