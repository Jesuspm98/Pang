using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;

    public Vector2 initialForce;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(initialForce, ForceMode2D.Impulse);
    }
}