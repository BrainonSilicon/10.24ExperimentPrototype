// SCRIPTS NO LONGER WORKING AS OF 10/25 NIGHT

// NEW PLAN IS TO START A FRESH BUILD, FRESH SCENE, AND TO PULL FROM 10.24 GIT

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script that controls the states of the Start Point

public class StartStates : MonoBehaviour
{
    
    // Set up properties of Start Point 
    //      - material, colors, audio 

    Material material;
    
    public Color Ready; // color that represents "ready for subject to start task"
    public Color Waiting; // color that represents "you are in the start area"
    public Color GoSignal; // color channge that represents "you can move now"

    AudioSource source;

    void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
        source = GetComponent<AudioSource>();
    }

    // // set up the Coroutine which will control the "wait" period
    // // set up target appearing 
    public GameObject Target;

    IEnumerator Coroutine()
    {
        // GameObject instance = Instantiate(Target);
        Debug.Log("Target appeared! Coroutine started.");
        yield return new WaitForSeconds(2.0f); // wait for 2sec
        material.color = GoSignal;
        Instantiate(Target);
    }



    // going to try it first without the if statement
    void OnTriggerEnter(Collider other) 
    {
        material.color = Waiting;
        Debug.Log("The controller hit the Start Point!");
        source.Play();
        StartCoroutine(Coroutine());
    }

    void OnTriggerExit(Collider other) 
    {
        material.color = Ready;
        Debug.Log("The controller has left the Start Point");
        
    }


}



// 10/25 MORNING ADDITIONS - COLLISIONS STARTED OVERWRITING SO STARTED FRESH PRE-10/25 NIGHT BREAK

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;


// public class StartStates : MonoBehaviour
// {

//     // set up colour states
//     public Color Ready; // color that represents "ready for subject to start task"
//     public Color Waiting; // color that represents "you are in the start area"
//     public Color GoSignal; // color channge that represents "you can move now"

//     Material material;


//     // set up Audio components 
//     AudioSource source;

//     // set up target appearing 
//     public GameObject Target;


//     void Awake()
//     {
//         material = GetComponent<MeshRenderer>().material;
//         source = GetComponent<AudioSource>();
//     }

//     // set up the coroutine
//     // IEnumerator Coroutine()
//     // {
//     //     GameObject instance = Instantiate(Target);
//     //     Debug.Log("Target appeared! Coroutine started.");
//     //     yield return new WaitForSeconds(5.0f);
//     //     material.color = GoSignal;
//     // }
    
//     // the Controller acts as the Trigger 
//     void OnTriggerEnter(Collider other) 
//     {
//         if(GetComponent<Collider>().name == "StartPoint") // check this -> may need to add tag?
//         {
//             material.color = Ready;
//             Debug.Log("A collider hit the start point");
//             source.Play();
//             // StartCoroutine(Coroutine());
//         }
    
//     }

//     void OnTriggerExit(Collider other)
//     {
//         material.color = Waiting;
//         Debug.Log("Controller left StartPoint!");
//     }

// }
