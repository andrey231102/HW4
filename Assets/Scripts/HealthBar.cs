﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _smoothness;

    private Slider _slider;

    private void Start()
    {
        SetMaxHealth(_player.MaxHealth);

        _player.HealthChanged += OnChanged;
    }

    private void SetMaxHealth(float maxHealth)
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = maxHealth;
        _slider.value = maxHealth;
    }

    private void OnChanged(float s)
    {
        var a = TransmitCurrentHealth(s);

        //StopAllCoroutines();
        StopCoroutine(a);
        StartCoroutine(a);
    }

    private IEnumerator TransmitCurrentHealth(float currentHealthValue)
    {
        while (_slider.value != currentHealthValue)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, currentHealthValue, _smoothness * Time.deltaTime);
            yield return null;
        }
    }
}


