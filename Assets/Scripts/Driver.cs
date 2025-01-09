using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    float steerSpeed = 1.0f;
    float moveSpeed = 0.2f;
    void Start()
    {

    }

    void Update()
    {
        transform.Translate(0, moveSpeed, 0);
        transform.Rotate(0, 0, steerSpeed);
    }
}