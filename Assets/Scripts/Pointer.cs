using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    [SerializeField] private Transform[] _targets;
    [SerializeField] private float _speed;

    private Vector3 _currentTarget;

    private void Awake()
    {
        _currentTarget = _targets[0].transform.position;
    }

    private void Update()
    {
        Vector3 direction = (_currentTarget - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, _speed * Time.deltaTime);
    }

    public void NextTarget()
    {
        for (int i = 0; i < _targets.Length; i++)
        {
            _currentTarget = _targets[i].transform.position;          
        }
    }
}
