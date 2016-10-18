using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class JoinHostScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Host()
    {
        NetworkManager.singleton.StartHost();

        /*NetworkServer.Listen(4444);
        var myClient = ClientScene.ConnectLocalServer();
        myClient.RegisterHandler(MsgType.Connect, (NetworkMessage netMsg) => { Debug.Log(netMsg.reader); });*/
        gameObject.SetActive(false);
    }

    public void Join()
    {
        NetworkManager.singleton.StartClient();
        /*var myClient = new NetworkClient();
        myClient.RegisterHandler(MsgType.Connect, (NetworkMessage netMsg) => { Debug.Log(netMsg.reader); });
        myClient.Connect("127.0.0.1", 4444);*/
        gameObject.SetActive(false);
    }
}
