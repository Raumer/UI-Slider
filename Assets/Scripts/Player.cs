using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Slider HealthPlayer;
    [SerializeField] private Button Health;
    [SerializeField] private Button Damage;
    [SerializeField] private HealthBar HealthBar;

    private float _deltaHealth = 10f;
    private float _playerHealth = 50f;

    public void OnButtonClick(Button name)
    {
        if (name == Health)
        {
            if (_playerHealth < HealthPlayer.maxValue)
            {
                _playerHealth += _deltaHealth;
            }
        }
        else
             if (name == Damage)
        {
            if (_playerHealth > HealthPlayer.minValue)
            {
                _playerHealth -= _deltaHealth;
            }
        }
    }

    private void Update()
    {
        if (_deltaHealth != 0)
        {
            HealthBar.MoveSlider(_playerHealth);
        }
    }    
}
