// SCRIPTS NO LONGER WORKING AS OF 10/25 NIGHT

// NEW PLAN IS TO START A FRESH BUILD, FRESH SCENE, AND TO PULL FROM 10.24 GIT

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Script that captures the timing components related to Reaction Time
// ie. between arriving at start point, reacting to target, and leaving

public class StartTimeScript : MonoBehaviour
{
    // set up Time tracking 

    public static float time; // changed from public static float

    private float startTime; // time at first frame 
    private float startPointCollision; // time when controller enters startPoint 
    // private float startPointCollisionMS;
    public float startPointExit; // time of startPoint exit 
    // private float startPointExitMS; // time in millisecs
    private float reactionTime; // time between entering start point and leaving 
    // private float reactionTimeMS; // time in millisecs

    // set up the target 
    // public GameObject Target;


    // set up Lists for the time stamps 
    List<float> collisionTimes = new List<float>(); // collisionTimes List is for debugging and Sanity Checks
    List<float> reactionTimes = new List<float>();

    void Awake()
    {
        startTime = Time.time; // this is time in seconds 
        Debug.Log("Start time = " + startTime);
    }

    // using OnTriggerEnter 
    void OnTriggerEnter(Collider other) 
    {
        startPointCollision = Time.time;
        // startPointCollisionMS = (startPointCollison * 1000); // convert time in sec to millisec 
        collisionTimes.Add(startPointCollision); 
        // instantiate Target      
    }

    void OnTriggerExit(Collider other) {
        startPointExit = Time.time;
        // startPointExitMS = (startPointExit * 1000); // convert time in sec to millisec 
        reactionTime = ((startPointExit - startPointCollision) - 2); // because I have the 2.0sec WaitForSeconds. This will want to be the target appearance time later.
        // reactionTimeMS = (reactionTime * 1000); //convert to millisecs
        reactionTimes.Add(reactionTime); // TODO change the list to reactionTimeMS
        Debug.Log("Reaction time was " + reactionTime);
    }

}





// STUFF BROKE SO I'M STARTING BLANK SLATE 
// 10/25 MORNING ADDITIONS - COLLISIONS STARTED OVERWRITING SO STARTED FRESH PRE-10/25 NIGHT BREAK

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class StartTimeScript : MonoBehaviour
// {
//   // set up Time tracking 
//     public float time; // changed from public static float

//     private float startTime; // time at first frame 
//     private float startPointCollision; // time when controller enters startPoint 
//     private float startPointExit; // time of startPoint exit 
//     private float reactionTime; // time between entering start point and leaving 
    
//     // set up the target 
//     public GameObject Target;


//     // set up Lists for the time stamps 

//     // collisionTimes List is for debugging and Sanity Checks
//     List<float> collisionTimes = new List<float>();
//     List<float> reactionTimes = new List<float>();
   

//     void Awake()
//     {
       
//         startTime = Time.time;
//         Debug.Log("Start time = " + startTime);
       
//     }

//     void OnTriggerEnter(Collider other) 
//     {
//         startPointCollision = Time.time;
//         collisionTimes.Add(startPointCollision);
//         GameObject instance = Instantiate(Target);
//         Debug.Log("Target appeared!");
//         //Instantiate(Target);
//         // target = Instantiate(newTarget, //where we want it to go))
        
//     }

//     void OnTriggerExit(Collider other)
//     {
//         startPointExit = Time.time;
//         reactionTime = (startPointExit - startPointCollision);
//         reactionTimes.Add(reactionTime);
//         Debug.Log("Reaction time was " + reactionTime);

//     }
// }
