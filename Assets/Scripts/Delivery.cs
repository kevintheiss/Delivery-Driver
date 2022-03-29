using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("CRASH!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Package")
        {
            Debug.Log("Picked up the package!");
        }

        if(other.tag == "Customer")
        {
            Debug.Log("Package delivered!");
        }
    }
}
