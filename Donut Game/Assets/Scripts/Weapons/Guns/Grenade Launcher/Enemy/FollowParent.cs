using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowParent : MonoBehaviour
{
    [SerializeField] private GameObject parent;

    private readonly Vector3 offsetY = Vector3.up * 1.5f;
    private Quaternion initial;

    private void Awake()
    {
        initial = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = parent.transform.position + offsetY;
        transform.rotation = initial;
    }
}
