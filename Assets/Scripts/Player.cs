using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{    
    [SerializeField] private float _maxHealth;
    [SerializeField] private HealthBar _healthBar;

    private float _currentHealth;

    public float CurrentHealth => _currentHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
        _healthBar.SetMaxHealth(_maxHealth);
    }

    public void ChangeHealth(float health)
    {
        _healthBar.SetHealth(_currentHealth);
        _currentHealth = health;

        if (health < 0)
        {
            _currentHealth = 0;
        }
        else if (health > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }
    }
}
