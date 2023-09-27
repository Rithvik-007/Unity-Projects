using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TriggerTarget : MonoBehaviour
{
    public int hitPoints = 2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name=="Sphere")
        {
            hitPoints--;

            if (hitPoints<=0)
            {
                Destroy(this.gameObject);
               

            }
            
        }
    }
}
