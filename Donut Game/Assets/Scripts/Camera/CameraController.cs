using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform target;

    private Vector3 offset = new Vector3 (0, 9, -7);
    private Vector3 velocity = Vector3.zero;

    private float smoothTime = .3f;

    private void Start() => target = GameObject.FindWithTag("Player").transform;

    // Update is called once per frame
    void FixedUpdate()
    {
        FollowTarget();
    }

    private void FollowTarget()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);

        transform.position = smoothedPosition;
    }
}
