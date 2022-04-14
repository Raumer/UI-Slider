using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider HealthPlayer;
    
    private float _stepSliderMove = 0.2f;
    private float _targetSliderPosition = 50;

    public void MoveSlider(float _deltaSlider)
    {
       _targetSliderPosition = _deltaSlider;          
    }    

    void Update()
    {
        HealthPlayer.value = Mathf.MoveTowards(HealthPlayer.value, _targetSliderPosition, _stepSliderMove);
    }
}

