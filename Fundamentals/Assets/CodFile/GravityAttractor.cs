using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAttractor : MonoBehaviour
{
    public float gravity = -10f;
    public void Attractor(Rigidbody rigidbody)
    {
        Vector3 up =(rigidbody.position - transform.position).normalized;
        Vector3 localup = rigidbody.transform.up;
        rigidbody.AddForce(up * gravity);
        rigidbody.rotation = Quaternion.FromToRotation(localup,up) * rigidbody.rotation;


    }
}
