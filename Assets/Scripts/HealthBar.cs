using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider HealthPlayer;
    [SerializeField] private Player Player;

    private float _stepSliderMove = 0.2f;
    private float _targetSliderPosition = 50;

    private void OnEnable()
    {
        Player.HealthChanged += ChangeBar;
    }

    private void OnDisable()
    {
        Player.HealthChanged -= ChangeBar;
    }

    private void ChangeBar(int value)
    {
        _targetSliderPosition += value;

        StartCoroutine(ChangeHealth());
    }

    private IEnumerator ChangeHealth()
    {

        while (HealthPlayer.value != _targetSliderPosition)
        {
            HealthPlayer.value = Mathf.MoveTowards(HealthPlayer.value, _targetSliderPosition, _stepSliderMove);

            yield return null;
        }
    }

}

