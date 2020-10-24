using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartStates : MonoBehaviour
{

    // set up colour states
    public Color Ready;
    public Color Waiting;
    public Color Go; 

    Material material;


    // set up Audio components 
    AudioSource source;


    void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other) 
    {
        material.color = Ready;
        Debug.Log("A collider hit the start point");
        source.Play();
        
    }

    void OnTriggerExit(Collider other)
    {
        material.color = Waiting;
    }

}
