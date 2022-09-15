using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public int _health;
    // Start is called before the first frame update


    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D collision)
    {
        HitTag foundTag;
        foundTag = collision.attachedRigidbody.GetComponent<HitTag>();
        if (foundTag != null)
        {
            Debug.Log("tagged");
        }
        Debug.Log("yohoho");

    }
}
