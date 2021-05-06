using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.Serialization;

public class CamClient : NetworkBehaviour
{
    public GameObject cameraMountPoint;
    public Camera camera;
     
    void Start()
    {
        if (isLocalPlayer)
        {
            camera.targetDisplay = 0;
        }
        else
        {
            camera.targetDisplay = 9;
        }
    }

}
