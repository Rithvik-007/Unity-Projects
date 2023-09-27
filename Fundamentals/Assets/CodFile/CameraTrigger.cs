using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public CameraManager manager=null;
    public CameraManager.CameraStates cameraStates = CameraManager.CameraStates.idle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name=="Cube")
        {
            manager.SetCameraState(cameraStates);
        }
    }
}
