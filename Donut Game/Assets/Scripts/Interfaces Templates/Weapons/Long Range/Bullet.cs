using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    public float Damage { get; set; }
    public float BulletSpeed { get; set; }
    public Vector3 BulletDirection {get; set;}

    protected Rigidbody bulletRb;

    private void Awake() => bulletRb = GetComponent<Rigidbody>();

    protected virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enviorement"))
            gameObject.SetActive(false);
    }

    private void OnDisable()
    {        
        bulletRb.velocity = Vector3.zero;
        transform.forward = Vector3.one;
    }
}
