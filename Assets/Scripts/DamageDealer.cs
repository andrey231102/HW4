using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private float _amountOfDamage;
    [SerializeField]private HealthBar _healthBar;

    public void DoDamage()
    {
        float currentHealth = _healthBar.CurrentHealth - _amountOfDamage;
        _healthBar.ChangeHealth(currentHealth);
    }
}
