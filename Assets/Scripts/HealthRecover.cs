using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRecover : MonoBehaviour
{
    [SerializeField] private float _amountOfHealing;
    [SerializeField] private Player _player;

    public void RecoverHealth()
    {
        _player.RecoverHealth(_amountOfHealing);
    }
}
