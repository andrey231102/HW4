using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _smoothness;

    private float _currentHealth;
    private Slider _slider;

    public float CurrentHealth => _currentHealth;

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _maxHealth;
        _slider.value = _maxHealth;
        _currentHealth = _maxHealth;
    }

    private void Update()
    {
        if (_slider.value != _currentHealth)
        {
            _slider.value = Mathf.Lerp(_slider.value, _currentHealth, _smoothness * Time.deltaTime);
        }
    }

    public void ChangeHealth(float health)
    {
        _currentHealth = health;
        
        if (health<0)
        {
            _currentHealth = 0;
        }
        else if (health>_slider.maxValue)
        {
            _currentHealth = _slider.maxValue;
        }
    }
}
