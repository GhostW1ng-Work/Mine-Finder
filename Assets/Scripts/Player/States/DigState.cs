using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DigState : State
{
    [SerializeField] private int _digCount;

    private bool _isDiged;

    public bool IsDiged => _isDiged;

    public event UnityAction Diged;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Ore ore))
        {
            StartCoroutine(Dig(ore));
        }
    }

    private void OnDisable()
    {
        Animator.SetBool("isDig", false);
    }

    private void Update()
    {
    }

    private IEnumerator Dig(Ore ore)
    {
        Animator.SetBool("isDig", true);
        Diged?.Invoke();
        yield return new WaitForSeconds(_digCount);
        ore.gameObject.SetActive(false);
        Animator.SetBool("isDig", false);
    }
}
