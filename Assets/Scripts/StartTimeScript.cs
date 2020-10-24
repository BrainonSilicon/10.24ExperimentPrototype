using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimeScript : MonoBehaviour
{
  // set up Time tracking 
    public static float time;

    private float startTime; // time at first frame 
    private float startPointCollision; // time when controller enters startPoint 
    private float startPointExit; // time of startPoint exit 
    private float reactionTime; // time between entering start point and leaving 
    
    // set up the target 
    public GameObject Target;


    // set up Lists for the time stamps 

    // collisionTimes List is for debugging and Sanity Checks
    List<float> collisionTimes = new List<float>();
    List<float> reactionTimes = new List<float>();
   

    void Awake()
    {
       
        startTime = Time.time;
        Debug.Log("Start time = " + startTime);
       
    }

    void OnTriggerEnter(Collider other) 
    {
        startPointCollision = Time.time;
        collisionTimes.Add(startPointCollision);
        GameObject instance = Instantiate(Target);
        Debug.Log("Target appeared!");
        //Instantiate(Target);
        // target = Instantiate(newTarget, //where we want it to go))
        
    }

    void OnTriggerExit(Collider other)
    {
        startPointExit = Time.time;
        reactionTime = (startPointExit - startPointCollision);
        reactionTimes.Add(reactionTime);
        Debug.Log("Reaction time was " + reactionTime);

    }
}
