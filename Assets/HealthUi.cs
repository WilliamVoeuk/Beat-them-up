using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

[ExecuteAlways]
public class HealthUi : MonoBehaviour   
{
    [SerializeField] Slider Slider1;
    [SerializeField] Slider Slider2;
    [SerializeField] Slider Slider3;
    [SerializeField] int _dammage;
    [SerializeField] Health _PlayerMaxHealth;
    
    int _currentHealth;

    private void Start ()
    {
        _currentHealth = _PlayerMaxHealth._health;
        Debug.Log($"Health: {_currentHealth}");
    }

    private void Update()
    {
        Slider1.value = (_currentHealth * 100/ _PlayerMaxHealth._health) ; 
        Slider2.value = (_currentHealth * 100 / _PlayerMaxHealth._health) ; 
        Slider3.value = (_currentHealth * 100 / _PlayerMaxHealth._health) ;

        Dammage ();
    }

    void Dammage()
    {
        _currentHealth -= _dammage;
    }

}
