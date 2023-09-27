using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastSetup : MonoBehaviour
{
    public bool RayCastExample = true;
    public bool RayCastPlaceObject = true;
    public float distance = 4;
    public Camera cam;
    public GameObject raycastObj;

    private void Update()
    {
        if(RayCastExample)
        {
            Vector3 dir = this.transform.TransformDirection(Vector3.forward);
            Debug.DrawRay (transform.position, dir*distance,Color.red);
            RaycastHit hit;
            if (Physics.Raycast(transform.position,dir,out hit,distance))
            {
                if(hit.collider.name=="Item")
                {
                    Debug.Log("Item found");
                    hit.collider.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
                }
                
            }
        }
        if(RayCastPlaceObject)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray;
                RaycastHit hit;

                ray = cam.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray,out hit, 100))
                {
                    if(hit.collider)
                    {
                        Instantiate(raycastObj, hit.point, Quaternion.identity);
                    }
                }
            }

        }

    }

}
