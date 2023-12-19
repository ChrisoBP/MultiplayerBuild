using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float despawnTime;
    private float timer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {
        
        rb.velocity = transform.up.normalized * bulletSpeed * 10;
        
        if (timer >= despawnTime)
        {
            Destroy(gameObject);
        }
        else
        {
            timer += Time.deltaTime;
        }

    }
}
