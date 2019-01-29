using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blob : MonoBehaviour
{
    public float Speed;

    private float _acceleration = 0.001f;


    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + Speed);
        Speed += _acceleration;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
    }
}