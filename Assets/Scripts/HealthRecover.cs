using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthRecover : MonoBehaviour
{
    [SerializeField] private float _amountOfHealing;
    [SerializeField] private HealthBar _healthBar;

    public void RecoverHealth()
    {
        float currentHealth = _healthBar.CurrentHealth + _amountOfHealing;
        _healthBar.ChangeHealth(currentHealth);
    }
}
