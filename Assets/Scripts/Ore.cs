using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore : MonoBehaviour
{
    [SerializeField] private Key _key;

    private void OnDisable()
    {
        _key.gameObject.SetActive(true);   
    }
}
