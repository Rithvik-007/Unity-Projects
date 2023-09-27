using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLight : MonoBehaviour
{
    public GameObject LightObj = null;
    public GameObject ParticleObj = null;
    public GameObject DoorObj = null;
    public AudioSource   DoorOpenAudio=null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name== "Cube")
        {
            GetComponent<AudioSource>().Play();
            LightObj.SetActive(true);
            StartCoroutine(playparticle());

        }
    }
    IEnumerator playparticle()
    {
        yield return new WaitForSeconds(2);
        ParticleObj.SetActive(true);
        DoorOpenAudio.Play ();
        LeanTween.move(DoorObj, DoorObj.transform.position - new Vector3(0, 3, 0), 2);
    } 
    IEnumerator playparticle1()
    {
        yield return new WaitForSeconds(2);
        ParticleObj.SetActive(true);
        LeanTween.move(DoorObj, DoorObj.transform.position - new Vector3(0, -3, 0), 2);
    }
    private void OnTriggerExit(Collider other)
    {   
        if (other.name=="Cube")
        {
            LightObj.SetActive(false);
            
        }
    }


}
