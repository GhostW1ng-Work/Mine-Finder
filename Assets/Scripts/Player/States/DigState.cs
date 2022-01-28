using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigState : State
{
    [SerializeField] private float _digCount;

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
        yield return new WaitForSeconds(_digCount);
        ore.gameObject.SetActive(false);
        Animator.SetBool("isDig", false);
    }
}
