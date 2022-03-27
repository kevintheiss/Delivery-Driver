using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    [SerializeField] float turnSpeed = 100f;
    [SerializeField] float moveSpeed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0f, 0f, -turnAmount);
        transform.Translate(0f, moveAmount, 0f);
    }
}
