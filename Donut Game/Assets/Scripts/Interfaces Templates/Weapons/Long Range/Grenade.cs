using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Grenade : MonoBehaviour
{
    [SerializeField] private ParticleSystem particles;

    protected Collider[] colliders;
    private Rigidbody grenadeRb;    
    private readonly float gravity = Physics.gravity.y;

    public Vector3 ShootDirection { protected get; set; }
    public float ExplosionRadius { protected get; set; }
    public float Damage { protected get; set; }
    public float Height { protected get; set; }
    public float Force { protected get; set; }
    public float Length { protected get; set; }
    public float DetonateTime { private get; set; }    

    private void Awake()
    {
        grenadeRb = GetComponent<Rigidbody>();
        ShootDirection = Vector3.one;
    }

    protected virtual void OnEnable()
    {
        ParabolicThrow();
        StartCoroutine(Explosion(DetonateTime));
    }

    public IEnumerator Explosion(float detonateTime)
    {
        yield return new WaitForSeconds(detonateTime);

        particles.Play(true);

        HandleCollisions();

        yield return new WaitForSeconds(particles.main.startLifetime.constant * 0.7f);

        gameObject.SetActive(false);
    }

    private void ParabolicThrow()
    {
        Vector3 direction = ShootDirection;

        float displacementY = direction.y;

        direction.y = 0;

        Vector3 velocityY = Vector3.up * Mathf.Sqrt(Mathf.Abs(Height * 2 * gravity));

        float flyTime = (Mathf.Sqrt(Mathf.Abs(2 * Height / gravity)) + Mathf.Sqrt(Mathf.Abs(2 * (displacementY - Height) / gravity)));

        Vector3 velocityXZ = direction / flyTime;

        grenadeRb.velocity = velocityXZ + velocityY;
    }

    protected virtual void HandleCollisions()
    {
        colliders = Physics.OverlapSphere(transform.position, ExplosionRadius);
    }
}
