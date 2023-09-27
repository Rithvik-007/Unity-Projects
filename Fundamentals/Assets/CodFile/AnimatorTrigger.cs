using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTrigger : MonoBehaviour
{
    public Animator animator = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Cube")
        {
            //animator.Play("rock floating");
            //animator.enabled = false;
            animator.SetBool("on", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
            if (other.name == "Cube")
            {
                //animator.Play("Spin");
                animator.SetBool("on", false);


                //animator.enabled = true;

        }
    }
}
