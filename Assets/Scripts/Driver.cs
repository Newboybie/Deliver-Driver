using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 2.0f;
    [SerializeField] float moveSpeed = 10.0f;
    [SerializeField] private float basicSpeed = 10.0f;
    [SerializeField] private float slowSpeed = 5.0f;
    [SerializeField] private float boostSpeed = 20.0f;
    void Start()
    {

    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0, -steerAmount);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "BoostPoint")
        {
            moveSpeed = boostSpeed;
        }

        if (other.tag == "Customer" || other.tag == "Package")
        {
            moveSpeed = basicSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }
}
