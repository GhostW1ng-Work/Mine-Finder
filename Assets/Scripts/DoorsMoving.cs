using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorsMoving : MonoBehaviour
{
    [SerializeField] private GameObject _door1;
    [SerializeField] private GameObject _door2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Player player) && player.KeyIsPickedUp == true) 
        {
            _door1.transform.DOLocalMoveX(1, 2);
            _door2.transform.DOLocalMoveX(-2, 2);
            player.SetKeyIsPickedUpFalse();
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
