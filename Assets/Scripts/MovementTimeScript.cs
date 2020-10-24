using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementTimeScript : MonoBehaviour
{

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
        
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Return to start");
        
    }

}
