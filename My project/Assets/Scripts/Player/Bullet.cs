using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float projectileSpeed;
    public GameObject impactEffect;
    private Rigidbody2D rb;

     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * projectileSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent<Enemy>(out Enemy enemyComponent))
        {
            enemyComponent.TakeDamage(1);
        }
        if (collision.gameObject.TryGetComponent<BossBehavior>(out BossBehavior bossComponent))
        {
            bossComponent.TakeDamage(1);
        }

        Destroy(gameObject);

    }
}
