using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using JetBrains.Annotations;
using System;

public class SpawnBullet : MonoBehaviourPunCallbacks
{
    [SerializeField] GameObject BulletPrefab;

    [SerializeField] float timer;
    [SerializeField] float timeBetweenShots;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (photonView.IsMine)
        {
            
                if (timer >= timeBetweenShots)
                {
                    if (Input.GetMouseButton(0))
                    {
                        PhotonNetwork.Instantiate(BulletPrefab.name, transform.position, transform.GetComponentInParent<Transform>().transform.rotation);
                        Debug.Log("shoot");
                        timer = 0;
                    }
                }
                else
                {
                    timer += Time.deltaTime;
                }
            
        }
    }
}
