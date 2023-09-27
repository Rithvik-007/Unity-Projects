using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;// Default it starts with false
    [SerializeField] float delay = 0.5f;
    [SerializeField] Color32 PickedPackage = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackage = new Color32(1, 1, 1, 1);

    SpriteRenderer sp;

    void Start()
    {
        sp= GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Dashed");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Package" && hasPackage==false)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            sp.color = PickedPackage;
            Destroy(collision.gameObject,delay);
            

        }
        if(collision.tag =="Customer" && hasPackage)
        {
            Debug.Log("Reached Customer");
            hasPackage = false;
            sp.color= noPackage;
        }
    }
}
