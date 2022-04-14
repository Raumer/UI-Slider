using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private Button Health;
    [SerializeField] private Button Damage;
    [SerializeField] public Action<int> HealthChanged;

    private int _deltaHealth = 10;
    private int _playerHealth = 50;
    private int _minPlayerHealth = 0;
    private int _maxPlayerHealth = 50;

    public void OnButtonClick(Button name)
    {
        if (name == Health)
        {
            SetHealth(_deltaHealth);
        }
        else
             if (name == Damage)
        {
            SetHealth(-_deltaHealth);
        }
    }

    private void SetHealth(int value)
    {
        int _checkValueHealth = _playerHealth + value;

        if (_checkValueHealth <= _maxPlayerHealth)
        {
            if (_checkValueHealth >= _minPlayerHealth)
            {
                _playerHealth = _checkValueHealth;
                HealthChanged?.Invoke(value);
            }
        }
    }
}
