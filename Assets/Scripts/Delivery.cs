using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] bool pickedPackage = false;
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("I bump to something");
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            pickedPackage = true;
            Debug.Log("I picked up the package");
        }

        if (other.tag == "Customer" && pickedPackage)
        {
            pickedPackage = false;
            Debug.Log("Delivered package");
        }
    }
}
