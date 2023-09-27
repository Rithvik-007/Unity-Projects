using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEnter");  
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("TriggerStay");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("TriggerExit");

    }
}
