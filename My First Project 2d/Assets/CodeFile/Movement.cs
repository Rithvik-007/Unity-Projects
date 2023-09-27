using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 50f;
    private float movement;
    private float steer;
    public float steerspeed = 300f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        steer=Input.GetAxis("Horizontal");
        movement = Input.GetAxis("Vertical");
        transform.Translate(0, movement*speed*Time.deltaTime, 0);
        transform.Rotate(0, 0, -steer*steerspeed*Time.deltaTime);
    }
}
