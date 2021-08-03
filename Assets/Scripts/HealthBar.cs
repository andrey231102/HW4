using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _smoothness;
    [SerializeField] private Player _player;

    private Slider _slider;

    private void Start()
    {
        SetMaxHealth(_player.MaxHealth);
    }

    private void Update()
    {
        SetHealth(_player.CurrentHealth);
    }

    private void SetMaxHealth(float maxHealth)
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = maxHealth;
        _slider.value = maxHealth;
    }

    private void SetHealth(float currentHealth)
    {
        if (_slider.value != currentHealth)        
            _slider.value = Mathf.MoveTowards(_slider.value, currentHealth, _smoothness * Time.deltaTime);       
    }
}
