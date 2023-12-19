using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Unity.VisualScripting;


public class Player : MonoBehaviourPunCallbacks
{
    Rigidbody2D rb;
    [SerializeField] Camera playerCam;
    [SerializeField] float moveSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        
    }

    
    void Update()
    {
        if (photonView.IsMine)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            rb.velocity = new Vector3(x, y, 0).normalized * moveSpeed * Time.deltaTime * 100;

            Vector3 targetDirection = GetMousePosition() - transform.position;
            transform.up = Vector3.RotateTowards(transform.up, targetDirection, 5 * Time.deltaTime, 999);
        }

    }
    private Vector3 GetMousePosition()
    {
        return playerCam.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10f);
    }


}
