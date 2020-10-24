using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script will be broken into the start states (colour and audio) 
    // and the timing controls 
    // leave as is for debugging prototype 10/24/2020
    

public class StartStates : MonoBehaviour
{

    // set up colour states
    public Color Ready;
    public Color Waiting;
    public Color Go; 

    Material material;


    // set up Audio components 
    AudioSource source;

    // set up Lists for the time stamps 

    // List<float> collisionTimes = new List<float>();
    // List<float> reactionTimes = new List<float>();
    //List<float> movementTimes = new List<float>();

    void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
        // startTime = Time.time;
        source = GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider other) 
    {
        material.color = Ready;
        Debug.Log("A collider hit the start point");
        // startPointCollision = Time.time;
        // collisionTimes.Add(startPointCollision);
        source.Play();
        
    }

    void OnTriggerExit(Collider other)
    {
        material.color = Waiting;
        // startPointExit = Time.time;
        // reactionTime = (startPointExit - startPointCollision);
        // reactionTimes.Add(reactionTime);

    }

}
