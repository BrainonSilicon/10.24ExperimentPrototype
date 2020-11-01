
// THIS MAY BE VALID BUT JUST LEAVE IT AND START EVERYTHING COMPLETE 
// FROM SCRATCH BECAUSE IT DOES NOT WORK WITH 
// THE LOGIC 
// JACK HAS

// WHIS IS WHY I ASKED TO BUILD FROM SCRATCH 





// set up env 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UXF;

// Script that controls the states of the Start Point

public class StartStates : MonoBehaviour
{
    
    // set up UXF 

    // Set up properties of Start Point 
    //      - material, colors, audio,

    Material material;
    
    public Color Ready; // color that represents "ready for subject to start task"
    public Color Waiting; // color that represents "you are in the start area"
    public Color GoSignal; // color channge that represents "you can move now"

    AudioSource source; // may need to use AudioClip instead?

    public GameObject Target; 

    // add UXF 
    public Session session; 

    public Vector3 StartPointPosition;

    void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
        source = GetComponent<AudioSource>();
        //get position
 
        StartPointPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z); // may not need this anymore 
        Debug.Log("Start Position is " + StartPointPosition); // may break build 
    }

    //  set up Coroutine which will control the "wait" period
    IEnumerator CoroutineTargetAppearance()
    {
        yield return new WaitForSeconds(2.0f); // wait for 2sec
        material.color = GoSignal;
        Instantiate(Target); // TODO check architecture 
        session.BeginNextTrial(); 

    }

     void OnTriggerEnter(Collider other) 
    {
        if(GetComponent<Collider>().name == "StartPoint" & !session.InTrial) // check this -> may need to add tag?
        {
            material.color = Ready;
            Debug.Log("A collider hit the start point");
            source.Play();
            StartCoroutine(CoroutineTargetAppearance());
        }

    }

    void OnTriggerExit(Collider other)
    {
        material.color = Waiting;
        Debug.Log("Controller left StartPoint!");
        // took this out once I added the Coroutine in Target state 
        // if (GetComponent<Collider>().name == "StartPoint")
        // {
        //     StopAllCoroutines(); // this may not work with architecture, but it works for now 
        // }
    }

}


// push to git for posterity and then delete 
 

// // SCRIPTS NO LONGER WORKING AS OF 10/25 NIGHT

// // NEW PLAN IS TO START A FRESH BUILD, FRESH SCENE, AND TO PULL FROM 10.24 GIT

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// using UXF;

// // Script that controls the states of the Start Point

// public class StartStates : MonoBehaviour
// {
    
//     // Set up properties of Start Point 
//     //      - material, colors, audio 

//     Material material;
    
//     public Color Ready; // color that represents "ready for subject to start task"
//     public Color Waiting; // color that represents "you are in the start area"
//     public Color GoSignal; // color channge that represents "you can move now"

//     AudioSource source;

//     public Vector3 StartPointPosition;

//     // adding UXF 
//     public Session session;

//     void Awake()
//     {
//         material = GetComponent<MeshRenderer>().material;
//         source = GetComponent<AudioSource>();
//         //get position
 
//         StartPointPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
//         Debug.Log("Start Position is " + StartPointPosition);

//     }

//     // // set up the Coroutine which will control the "wait" period
//     // // set up target appearing 
//     public GameObject Target;

//     IEnumerator Coroutine()
//     {
//         // GameObject instance = Instantiate(Target);
//         Debug.Log("Target appeared! Coroutine started.");
//         yield return new WaitForSeconds(2.0f); // wait for 2sec
//         material.color = GoSignal;
//         Instantiate(Target); // TODO need to fix this logic back to 10/23
//         session.BeginNextTrial();
//     }

//     // update the information about the position of Start Point

//     // won't need to use Update as the Start Point is fixed
//     // use on Awake instead 
//     // void Update() 
//     // {
//     //     // use Vector3
//     // }



//     // going to try it first without the if statement 

//     // add the if statement logic from 10/23 back in 
//     void OnTriggerEnter(Collider other) 
//     {
//         material.color = Waiting;
//         Debug.Log("The controller hit the Start Point!");
//         source.Play();
//         StartCoroutine(Coroutine());
//     }

//     void OnTriggerExit(Collider other) 
//     {
//         material.color = Ready;
//         Debug.Log("The controller has left the Start Point");
//         // StopAllCoroutines(); // may not want this as will need coroutines if Ryan wants diff "states"
//         // coroutines traditionally do not need to be stopped, this may not hold for UXF (FAFO)
//     }


// }



// // 10/25 MORNING ADDITIONS - COLLISIONS STARTED OVERWRITING SO STARTED FRESH PRE-10/25 NIGHT BREAK

// // using System.Collections;
// // using System.Collections.Generic;
// // using UnityEngine;


// // public class StartStates : MonoBehaviour
// // {

// //     // set up colour states
// //     public Color Ready; // color that represents "ready for subject to start task"
// //     public Color Waiting; // color that represents "you are in the start area"
// //     public Color GoSignal; // color channge that represents "you can move now"

// //     Material material;


// //     // set up Audio components 
// //     AudioSource source;

// //     // set up target appearing 
// //     public GameObject Target;


// //     void Awake()
// //     {
// //         material = GetComponent<MeshRenderer>().material;
// //         source = GetComponent<AudioSource>();
// //     }

// //     // set up the coroutine
// //     // IEnumerator Coroutine()
// //     // {
// //     //     GameObject instance = Instantiate(Target);
// //     //     Debug.Log("Target appeared! Coroutine started.");
// //     //     yield return new WaitForSeconds(5.0f);
// //     //     material.color = GoSignal;
// //     // }
    
// //     // the Controller acts as the Trigger 
// //     void OnTriggerEnter(Collider other) 
// //     {
// //         if(GetComponent<Collider>().name == "StartPoint") // check this -> may need to add tag?
// //         {
// //             material.color = Ready;
// //             Debug.Log("A collider hit the start point");
// //             source.Play();
// //             // StartCoroutine(Coroutine());
// //         }
    
// //     }

// //     void OnTriggerExit(Collider other)
// //     {
// //         material.color = Waiting;
// //         Debug.Log("Controller left StartPoint!");
// //     }

// // }
