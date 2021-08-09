using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Player))]
public class Adapter : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private float _smoothness;

    private Player _player;

    private void Start()
    {
        _player = GetComponent<Player>();
    }

    private IEnumerator qwe()
    {
        while (_healthBar.value != _player.CurrentHealth)
        {
            _healthBar.value = Mathf.MoveTowards(_healthBar.value, _player.CurrentHealth, _smoothness * Time.deltaTime);
            yield return null;
        }
    }

    public void Change()
    {
        StartCoroutine(qwe());
    }
}
