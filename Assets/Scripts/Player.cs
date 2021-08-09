﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{    
    [SerializeField] private float _maxHealth;
    [SerializeField] private UnityEvent _changed;

    private float _currentHealth;

    public float CurrentHealth => _currentHealth;
    public float MaxHealth => _maxHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void ChangeHealth(float health)
    {
        _currentHealth = health;

        if (health < 0)
        {
            _currentHealth = 0;
        }
        else if (health > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }

        _changed?.Invoke();
    }
}
