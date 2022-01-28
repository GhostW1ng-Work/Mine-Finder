using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigTransition : PlayerTransition
{
    public override void Enable()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Ore ore))
            NeedTransit = true;
    }

    private void Update()
    {
        
    }
}
