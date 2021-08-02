using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRecover : MonoBehaviour
{
    [SerializeField] private float _amountOfHealing;
    [SerializeField] private Player _player;

    public void RecoverHealth()
    {
        float currentHealth = _player.CurrentHealth + _amountOfHealing;
        _player.ChangeHealth(currentHealth);
    }
}
