using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private Key _key;
    [SerializeField] private Pointer _pointer;

    private bool _keyIsPickedUp = false;

    public bool KeyIsPickedUp => _keyIsPickedUp;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Key key))
        {
            Destroy(key.gameObject);

            _keyIsPickedUp = true;
            _key.gameObject.SetActive(true);
            _pointer.gameObject.SetActive(true);
        }
    }

    public void SetKeyIsPickedUpFalse()
    {
        _keyIsPickedUp = false;
        _key.gameObject.SetActive(false);
        _pointer.gameObject.SetActive(false);
        _pointer.NextTarget();
    }
}
