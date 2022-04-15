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
        SetHealth(_deltaHealth);
    }

    public void Damage()
    {
        SetHealth(-_deltaHealth);
    }

    private void SetHealth(int _deltaHealth)
    {
        int _testValue = _health + _deltaHealth;

        _health = Mathf.Clamp(_health + _deltaHealth, _minHealth, _maxHealth);

        HealthChanged?.Invoke(_health);
    }
}
