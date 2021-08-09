using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private float _amountOfDamage;
    [SerializeField] private Player _player;

    public void DoDamage()
    {
        float currentHealth = _player.CurrentHealth - _amountOfDamage;
        _player.ChangeHealth(currentHealth);
        Debug.Log(_player.CurrentHealth);
    }
}
