using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public Action<int> HealthChanged;

    private int _deltaHealth = 10;
    private int _health = 50;
    private int _minHealth = 0;
    private int _maxHealth = 50;

    public void Heal()
    {
        if (_health < _maxHealth)
        {
            SetHealth(_deltaHealth);
        }
    }

    public void Damage()
    {
        if (_health > _minHealth)
        {
            SetHealth(-_deltaHealth);
        }
    }

    private void SetHealth(int value)
    {
        _health  += value;
        HealthChanged?.Invoke(value);
    }
}
