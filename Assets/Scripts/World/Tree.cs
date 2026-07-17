using System;
using UnityEngine;

[RequireComponent(typeof(Health))]

public class Tree : MonoBehaviour
{
    
    private Health health;

    public void Awake()
    {
        health = GetComponent<Health>();
    }
}
