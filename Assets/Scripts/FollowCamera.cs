using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // the camera's position should be the same as the target's position

    [SerializeField] GameObject followTarget;

    // Update is called once per frame
    void Update()
    {
        transform.position = followTarget.transform.position + new Vector3(0f, 0f, -10f);
    }
}
