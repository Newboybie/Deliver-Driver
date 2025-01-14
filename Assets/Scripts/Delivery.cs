using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] private Color32 hasPackageColor = new Color32 (1, 1, 1, 1);
    [SerializeField] private Color32 noPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField] bool pickedPackage = false;
    [SerializeField] private float destroyDelay = 1f;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !pickedPackage)
        {
            pickedPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
            Debug.Log("I picked up the package");
        }

        if (other.tag == "Customer" && pickedPackage)
        {
            spriteRenderer.color = noPackageColor;
            pickedPackage = false;
            Debug.Log("Delivered package");
        }
    }
}
