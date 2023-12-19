using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System;

public class CameraController : MonoBehaviourPunCallbacks
{
    public GameObject cameraHolder;
    public Vector3 offset;

    public void Update()
    {   
        if (photonView.IsMine)
        {
                cameraHolder.transform.position = transform.position + offset;
        }
    }
}
