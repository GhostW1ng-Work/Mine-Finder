using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorsMoving : MonoBehaviour
{
    [SerializeField] private GameObject _door1;
    [SerializeField] private GameObject _door2;
    [SerializeField] private ParticleSystem _confetti;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player player) && player.KeyIsPickedUp == true) 
        {
            _door1.transform.DOLocalMoveX(1, 1);
            _door2.transform.DOLocalMoveX(-2, 1);
            player.SetKeyIsPickedUpFalse();
            _confetti.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.TryGetComponent(out Player player))
        {
            _door1.transform.DOLocalMoveX(0, 2);
            _door2.transform.DOLocalMoveX(-1, 2);
        }
    }
}
