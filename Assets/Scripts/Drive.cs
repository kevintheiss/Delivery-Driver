using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    [SerializeField] float turnSpeed = 100f;
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float slowSpeed = 10f;
    [SerializeField] float boostSpeed = 25f;

    // Update is called once per frame
    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0f, 0f, -turnAmount);
        transform.Translate(0f, moveAmount, 0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "SpeedUp")
        {
            moveSpeed = boostSpeed;
        }
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;        
    }
}
