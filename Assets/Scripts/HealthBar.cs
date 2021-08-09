using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;

    private Slider _slider;

    private void Start()
    {
        SetMaxHealth(_player.MaxHealth);
    }

<<<<<<< HEAD
=======
    private void Update()
    {
        SetHealth(_player.CurrentHealth);
    }

>>>>>>> 6ae89ecd7673fd1d14be860211fd3a22f07f8598
    private void SetMaxHealth(float maxHealth)
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = maxHealth;
        _slider.value = maxHealth;
    }
<<<<<<< HEAD
=======

    private void SetHealth(float currentHealth)
    {
        if (_slider.value != currentHealth)        
            _slider.value = Mathf.MoveTowards(_slider.value, currentHealth, _smoothness * Time.deltaTime);       
    }
>>>>>>> 6ae89ecd7673fd1d14be860211fd3a22f07f8598
}


