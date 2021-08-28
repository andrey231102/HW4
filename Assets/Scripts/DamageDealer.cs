using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] private float _amountOfDamage;
    [SerializeField] private Player _player;

    public void DoDamage()
    {
        _player.TakeDamage(_amountOfDamage);
    }
}
