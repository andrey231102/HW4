using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{    
    [SerializeField] private float _maxHealth;

    private float _currentHealth;

    public float CurrentHealth => _currentHealth;
    public float MaxHealth => _maxHealth;

    public event UnityAction<float> HealthChanged;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(float amountOfDamage)
    {
        _currentHealth -= amountOfDamage;

        if (_currentHealth < 0)
        {
            _currentHealth = 0;
        }
        HealthChanged?.Invoke(_currentHealth);
    }

    public void RecoverHealth(float amountOfHealing)
    {
        _currentHealth += amountOfHealing;

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
        HealthChanged?.Invoke(_currentHealth);
    }
}
