using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Launcher : MonoBehaviourPunCallbacks
{
    public PhotonView PlayerPrefab;

    
    
   

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }


    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected To Master");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }
    

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined a room succesfully");
        PhotonNetwork.Instantiate(PlayerPrefab.name, Vector3.zero, Quaternion.identity);
    }
    
}
