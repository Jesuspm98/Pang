using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookCollision : MonoBehaviour
{
    private Hook myHook;

    private void Start()
    {
        myHook = GetComponentInParent<Hook>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        myHook.isFired = false;
    }
}