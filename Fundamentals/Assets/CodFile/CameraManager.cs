using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private CameraFollow cameraFollow = null;
    private CameraLookAT cameraLookAT= null;
    public enum CameraStates {idle,follow,LookAT,Both };
    public CameraStates cameraState = CameraStates.idle;

    private void Start()
    {
        cameraFollow = GetComponent<CameraFollow>();
        cameraLookAT = GetComponent<CameraLookAT>();
        
        SetCameraState(cameraState);
    }
    public void SetCameraState(CameraStates states)
    {
        switch (states)
        {
            case CameraStates.idle: stateIdle(); break;
            case CameraStates.follow: stateFollow(); break;
            case CameraStates.LookAT: stateLookAT(); break;
            case CameraStates.Both: stateBoth(); break;
        }

    }
    void stateIdle()
    {
        cameraFollow.enabled = false;
        cameraLookAT.enabled = false;   
    }
    void stateFollow()
    {
        cameraFollow.enabled = true;
        cameraLookAT.enabled = false;
    }
    void stateLookAT()
    {
        cameraLookAT.enabled=true;
        cameraFollow.enabled = false;
    }
    void stateBoth()
    {
        cameraLookAT.enabled = true;
        cameraFollow.enabled = true;
    }
}
