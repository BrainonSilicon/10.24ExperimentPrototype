// SCRIPTS NO LONGER WORKING AS OF 10/25 NIGHT

// NEW PLAN IS TO START A FRESH BUILD, FRESH SCENE, AND TO PULL FROM 10.24 GIT



using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script that captures the timing components related to movement 
// ie. between Start Point and Target


public class MovementTimeScript : MonoBehaviour
{
    // set up Time tracking
    public static float time;

    private float startTime; // time at first frame
    private float targetCollision; // time of collision with target
    // private float targetCollisionMS; // time in millisecs
    private float targetExit; // time at exit of target point 
    private float movementTime; // time between exiting startPoint and colliding with target
    // private float movementTimeMS; // time in millisecs
    private float MTStarted;
    // private float MTStartedMS;



    // set up Lists for the time stamps 
    List<float> movementTimes = new List<float>();
    

    void Awake()
    {   
        startTime = Time.time;
        // startPointExit = GameObject.Find("StartPoint").GetComponent<StartStates>();   
        
        // NULL REFERENCE EXCEPTION - TODO FIX LATER  
        // MTStarted = GetComponent<StartTimeScript>().startPointExit;
        // MTStartedMS = (MTStarted * 1000) // time in millisec
    }

    // may want to add the same if()statements to check which collided with which
    // could also try "oncollision" 
    void OnTriggerEnter(Collider other) 
    {
        targetCollision = Time.time;
        Debug.Log("Collided with Target at " + targetCollision);
        // movementTime = (targetCollision - MTStarted);
        // Debug.Log("Collided with Target at " + targetCollision + "Movement Time ended");
        
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Return to start");
        
    }

}










// 10/25 MORNING ADDITIONS - COLLISIONS STARTED OVERWRITING SO STARTED FRESH PRE-10/25 NIGHT BREAK
// STUFF BROKE SO I'M STARTING BLANK SLATE 

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;


// public class MovementTimeScript : MonoBehaviour
// {

//     // set up Time tracking 
//     public static float time;

//     private float startTime; // time at first frame 
//     private float targetCollision; // time of collision with target 
//     private float targetExit; // time at exit of target point 
//     private float movementTime; // time between exiting startPoint and colliding with target


//     // set up Lists for the time stamps 

//     List<float> movementTimes = new List<float>();
    

//     void Awake()
//     {   
//         startTime = Time.time;   
//     }

//     // may want to add the same if()statements to check which collided with which
//     void OnTriggerEnter(Collider other) 
//     {
//         targetCollision = Time.time;
//         Debug.Log("Movement Time Ended");
//         //collisionTimes.Add(startPointCollision);
        
//     }

//     void OnTriggerExit(Collider other)
//     {
//         Debug.Log("Return to start");
        
//     }

// }
