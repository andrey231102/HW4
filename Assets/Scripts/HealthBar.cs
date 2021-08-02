using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
<<<<<<< HEAD
    [SerializeField] private float _smoothness;
    [SerializeField] private Player _player;
=======
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _smoothness;
>>>>>>> edf1f816012e06454e78e7e41aa73e75e22dd2a4

    private Slider _slider;

    private void Update()
    {
        if (_slider.value != _player.CurrentHealth)
            _slider.value = Mathf.Lerp(_slider.value, _player.CurrentHealth, _smoothness * Time.deltaTime);
    }

    public void SetMaxHealth(float health)
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = health;
        _slider.value = health;
    }

<<<<<<< HEAD
    public void SetHealth(float health)
    {
        _slider.value = health;
=======
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
>>>>>>> edf1f816012e06454e78e7e41aa73e75e22dd2a4
    }
}
