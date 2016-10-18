using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject playerVR = null;
    [SerializeField]
    GameObject playerSTR = null;

    void Start ()
    {
        bool isVr = ((NetworkScript)NetworkManager.singleton).IsVR;

        if (isVr)
        {
            if (playerVR != null)
                Instantiate(playerVR);
        }
        else
        {
            if (playerSTR != null)
                Instantiate(playerSTR);
        }

        int layerToHide = LayerMask.NameToLayer(isVr ? "STR": "VR");
        var objs = FindObjectsOfType<GameObject>();
        foreach (var obj in objs)
        {
            if (obj.layer == layerToHide)
                obj.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
