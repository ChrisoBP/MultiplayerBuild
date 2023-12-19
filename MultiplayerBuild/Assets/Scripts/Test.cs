using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Test : MonoBehaviourPunCallbacks
{
    Rigidbody2D rb;
    [SerializeField] float moveSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(x, y, 0).normalized* moveSpeed;
    }
}
