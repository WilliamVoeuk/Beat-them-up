using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

[ExecuteAlways]
public class PlayerHealth : MonoBehaviour   
{
    [SerializeField] Slider Slider1;
    [SerializeField] Slider Slider2;
    [SerializeField] Slider Slider3;
    //[SerializeField] int _dammage;
    [SerializeField] const int MAX_health = 100;
    [Range(0, MAX_health)] public int _health;


    private void Start ()
    {
        _health = MAX_health;
    }

    private void Update()
    {
        Slider1.value = (_health * 100/ MAX_health) ; 
        Slider2.value = (_health * 100 / MAX_health) ; 
        Slider3.value = (_health * 100 / MAX_health) ;

        //Dammage ();
    }

// //   //vo//id Dammage ()
    //{
//    //    _health -= _dammage ;
    //
    //}

}
