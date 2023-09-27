using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class CameraMinimap : MonoBehaviour
{
    public Transform target = null;
    public bool MoveFollow = true;
    public bool MoveRotate = true;
    public float offset = 7.0f;
    private Camera minimapCamera = null;
    private bool fullScreen = false;

    private void Start()
    {
        minimapCamera = GetComponent<Camera>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (fullScreen)
            {
                minimapCamera.rect = new Rect(0, 0, 1, 1);


            }
            else
            {
                minimapCamera.rect = new Rect(0.01f, 0.0f, .2f, .3f);

            }
            fullScreen = !fullScreen;

        }

    }

    private void LateUpdate()
    {
        if (MoveFollow)
        {
            transform.position = new Vector3(target.position.x,offset, target.position.z);
        }
        if ((MoveRotate) && minimapCamera.rect!= new Rect(0,0,1,1))
        {
            //transform.rotation=target.rotation;
            transform.rotation = Quaternion.Euler(90,target.eulerAngles.y,0 );
        }
    }
}
