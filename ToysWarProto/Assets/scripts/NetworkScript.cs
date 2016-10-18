using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;


public class NetworkScript : NetworkManager
{
    int NumPlayers = 0;
    public bool IsVR { get; private set; }

    public override void OnServerConnect(NetworkConnection conn)
    {
        NumPlayers++;
        Debug.Log("Player added (" + NumPlayers + ")");
        if (NumPlayers == 3)
            ServerChangeScene("Network");
    }

    public override void OnServerDisconnect(NetworkConnection conn)
    {
        NumPlayers--;
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        if (NumPlayers > 0)
        {
            Debug.Log("STR mode");
            IsVR = false;
        }
        else
        {
            Debug.Log("VR mode");
            IsVR = true;
        }
    }
}
