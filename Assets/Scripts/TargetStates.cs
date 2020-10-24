using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// on collision destroy 


public class TargetStates : MonoBehaviour
{

    public Color State1;
    public Color State2;
    Material material; 

    AudioSource source;

    IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(0.5f);
    }

    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    void OnTriggerEnter(Collider other) 
    {
        material.color = State1;
        StartCoroutine(Coroutine());
        if (other.gameObject.name == "Target")
        {
            Destroy(other.gameObject);
        }
   
    }

    void OnTriggerExit(Collider other) 
    {
        StopAllCoroutines();   
    }

  
}
