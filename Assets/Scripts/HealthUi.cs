using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

//[ExecuteAlways]
public class HealthUi : MonoBehaviour   
{
    [SerializeField] Slider Slider1;
    [SerializeField] Slider Slider2;
    [SerializeField] Slider Slider3;
    [SerializeField] Health _PlayerMaxHealth;

    private void Start ()
    {
        Debug.Log($"Health: {_PlayerMaxHealth.CurrentHealth} / {_PlayerMaxHealth.MaxHealth}");
    }

    private void Update()
    {
        Slider1.value = (_PlayerMaxHealth.CurrentHealth * 100/ _PlayerMaxHealth.MaxHealth) ; 
        Slider2.value = (_PlayerMaxHealth.CurrentHealth * 100 / _PlayerMaxHealth.MaxHealth) ; 
        Slider3.value = (_PlayerMaxHealth.CurrentHealth * 100 / _PlayerMaxHealth.MaxHealth) ;

        
    }
}
