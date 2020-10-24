using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementTimeScript : MonoBehaviour
{

    // I'm being lazy and putting Audio here for now TODO change into its own script
    AudioSource source;

    // set up Time tracking 
    public static float time;

    private float startTime; // time at first frame 
    private float targetCollision; // time of collision with target 
    private float targetExit; // time at exit of target point 
    private float movementTime; // time between exiting startPoint and colliding with target


    // set up Lists for the time stamps 

    List<float> movementTimes = new List<float>();
    

    void Awake()
    {   
        startTime = Time.time;   
    }

    void OnTriggerEnter(Collider other) 
    {
        targetCollision = Time.time;
        Debug.Log("Movement Time Ended");
        //collisionTimes.Add(startPointCollision);
        source = GetComponent<AudioSource>();
        if (other.gameObject.name == "Target")
        {
            Destroy(other.gameObject);
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Return to start");
        
    }

}
