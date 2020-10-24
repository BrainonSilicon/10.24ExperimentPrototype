using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// on collision destroy 


public class TargetStates : MonoBehaviour
{

    public Color State1;
    public Color State2;
    Material material; 

    AudioSource sound;

    void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
        sound = GetComponent<AudioSource>();
    }

    
    IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(5.0f);
        // Destroy(gameObject);
    }

    void OnCollisionEnter(Collision other) 
    {
        material.color = State1;
        sound.Play();
        Debug.Log("Successfully hit target!");
        StartCoroutine(Coroutine());
        //Destroy(gameObject);
        
    }



    // void OnTriggerEnter(Collider other) 
    // {
    //     material.color = State1;
    //     source.Play();

    //     StartCoroutine(Coroutine());
    //     if (other.gameObject.name == "Target")
    //     {
    //         Destroy(other.gameObject);
    //     }
   
    // }

    // void OnTriggerExit(Collider other) 
    // {
    //     StopAllCoroutines();   
    // }

  
}
