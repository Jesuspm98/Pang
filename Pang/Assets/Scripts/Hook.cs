using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hook : MonoBehaviour
{
    private Vector3 initialSize;
    public bool isFired;
    public Transform player;
    public float growSpeed = 5;

    private void Start()
    {
        initialSize = transform.localScale;
    }

    private void Update()
    {
        if (isFired)
        {
            transform.localScale += Vector3.up * Time.deltaTime * growSpeed;
        }
        else
        {
            transform.position = player.position;
            transform.localScale = initialSize;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isFired = true;
        }
    }
}