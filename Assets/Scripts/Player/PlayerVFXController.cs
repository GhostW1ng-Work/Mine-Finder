using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerVFXController : MonoBehaviour
{
    [SerializeField] private ParticleSystem _healing;
    [SerializeField] private DigState _digState;

    private void OnEnable()
    {
        _digState.Diged += OnDigged;
    }

    private void OnDisable()
    {
        _digState.Diged -= OnDigged;
    }

    private void OnDigged()
    {
        _healing.Play();
    }
}
