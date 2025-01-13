using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private GameObject playerCar;
    private Vector3 offset = new Vector3(0, 0, -10);
    void LateUpdate()
    {
        transform.position = playerCar.transform.position + offset;
    }
}
