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

    public void SetHealth(float health)
    {
        _slider.value = health;
    }
}
