using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject toFollow;

    private void LateUpdate()
    {
        transform.position = toFollow.transform.position + new Vector3(0,0,-10);   
    }
}
    