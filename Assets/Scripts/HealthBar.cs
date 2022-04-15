using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthPlayer;
    [SerializeField] private Player _player;

    private float _stepSliderMove = 0.2f;
    private float _targetSliderPosition = 50;

    private Coroutine _workingCoroutine;   

    private void OnEnable()
    {
        _player.HealthChanged += ChangeBar;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= ChangeBar;
    }

    private void ChangeBar(int value)
    {
        _targetSliderPosition = value;

        if (_workingCoroutine != null)
        {
            StopCoroutine(_workingCoroutine);            
        }
        _workingCoroutine = StartCoroutine(ChangeHealth());
    }

    private IEnumerator ChangeHealth()
    {
        while (_healthPlayer.value != _targetSliderPosition)
        {
            _healthPlayer.value = Mathf.MoveTowards(_healthPlayer.value, _targetSliderPosition, _stepSliderMove);

            yield return null;
        }
    }
}

