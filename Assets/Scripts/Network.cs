using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Network : MonoBehaviour
{

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("1.0");
    }

    private void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }

    void OnJoinedRoom()
    {

    }
}
