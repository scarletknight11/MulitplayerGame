using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun; 

public class ConnectToServer : MonoBehaviourPunCallbacks {


    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();   
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("We are connected into server");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.LoadLevel("Lobby");
    }


}
