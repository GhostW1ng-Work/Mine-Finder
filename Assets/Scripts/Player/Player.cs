using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Animator))]
public class Player : MonoBehaviour
{
    [SerializeField] private Key _keyPlayer;
    [SerializeField] private Pointer _pointer;
    [SerializeField] private float _endValue;
    [SerializeField] private float _duration;

    private bool _keyIsPickedUp = false;

    public bool KeyIsPickedUp => _keyIsPickedUp;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Key key))
        {
            Destroy(key.gameObject);

            _keyIsPickedUp = true;
            _keyPlayer.gameObject.SetActive(true);
            _pointer.gameObject.SetActive(true);
            _keyPlayer.transform.DOLocalMoveY(_endValue, _duration);
        }
    }

    public void SetKeyIsPickedUpFalse()
    {
        _keyIsPickedUp = false;
        _keyPlayer.gameObject.SetActive(false);
        _pointer.gameObject.SetActive(false);
        _pointer.NextTarget();
    }
}
