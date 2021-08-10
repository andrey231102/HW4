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
    }

    private void SetMaxHealth(float maxHealth)
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = maxHealth;
        _slider.value = maxHealth;
    }

    private IEnumerator SetCurrentHealth()
    {
        while (_slider.value != _player.CurrentHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _player.CurrentHealth, _smoothness * Time.deltaTime);
            yield return null;
        }
    }

    public void ChangeValue()
    {
        StartCoroutine(SetCurrentHealth());
    }
}


