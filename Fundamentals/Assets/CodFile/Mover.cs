using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UIElements;
using Color = UnityEngine.Color;

public class Mover : MonoBehaviour
{
    public float speed = 5;
    public int Rotationspeed = 150;
    public Color colorChange= Color.white;
    public GameObject prefabwallhitParticle = null;
    public GameObject sphereprefab= null;
    public Transform Socket;
    public float eject = 400;
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject obj=Instantiate(sphereprefab, Socket.position, Socket.rotation);
            obj.name = "Sphere";
            float rnd = Random.Range(0.35f, 1.0f);
            obj.transform.localScale = Vector3.one*rnd;
            obj.GetComponent<Rigidbody>().AddForce(Socket.forward*eject, ForceMode.Acceleration);
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,0,speed * Time.deltaTime);
                                  
        }       
        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(speed * Time.deltaTime,0,0);

        }
        else if( Input.GetKey(KeyCode.Q))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A  ))
        {
            transform.Rotate(0,-Rotationspeed * Time.deltaTime, 0);

        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, Rotationspeed * Time.deltaTime, 0);

        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            transform.localScale = Vector3.one * 0.5f;
            
        }
        else if ( Input.GetKeyDown(KeyCode.C))
        {
            transform.localScale = Vector3.one;

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = colorChange;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
     if (other.name == "wallhit")
        {
            Instantiate(prefabwallhitParticle, this.transform.position, Quaternion.identity);

        }

    }

}
  