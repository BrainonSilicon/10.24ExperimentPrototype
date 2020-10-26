// SCRIPTS NO LONGER WORKING AS OF 10/25 NIGHT

// NEW PLAN IS TO START A FRESH BUILD, FRESH SCENE, AND TO PULL FROM 10.24 GIT

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO put coroutine back in for destroy on collision after 0.5sec



// Script that controls the states of the Target

public class TargetStates : MonoBehaviour
{

    // Set up properties of Target 
    //      - material, colors, audio 
    public Color State1;
    public Color State2;
    Material material; 

    AudioSource sound;


    void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
        sound = GetComponent<AudioSource>();
    }

    // still isn't reconizing controller interaction 
    // void OnTriggerEnter(Collider other) 
    // {
    //     material.color = State1;
    //     sound.Play();
    //     Debug.Log("Collided with Target!");
        
    // }

    void OnTriggerEnter(Collider other)  // changed to on TriggerEnter when i switched the "is Trigger"
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Sphere hit the target");
            material.color = State2;
            sound.Play();
        }
        
    }

    void OnTriggerExit(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            material.color = State1;
        }
        
    }


}



// STUFF BROKE SO I'M STARTING BLANK SLATE 
// 10/25 MORNING ADDITIONS - COLLISIONS STARTED OVERWRITING SO STARTED FRESH PRE-10/25 NIGHT BREAK

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;


// // on collision destroy 


// public class TargetStates : MonoBehaviour
// {

//     public Color State1;
//     public Color State2;
//     Material material; 

//     AudioSource sound;

//     void Awake()
//     {
//         material = GetComponent<MeshRenderer>().material;
//         sound = GetComponent<AudioSource>();
//     }

//     // uncommenting because the target isn't reacting ... Shifted to StartStates.cs
//     IEnumerator Coroutine()
//     {
//         yield return new WaitForSeconds(5.0f);
//         // Destroy(gameObject);
//     }

//     void OnTriggerEnter(Collider other) // changed from OnCollion to OnTrigger with if
//     {
//         if(other.gameObject.name == "Target")
//         {
//             material.color = State1;
//             sound.Play();
//             Debug.Log("Successfully hit target!");
//             StartCoroutine(Coroutine()); //-> moved to StartStates.cs
//             // Destroy(gameObject);

//         }

        
//     }

//     void OnTriggerExit(Collider other)
//     {
//         material.color = State2;
//         Debug.Log("Controller left Target!");
//     }

// }

//     // void OnTriggerEnter(Collider other) 
//     // {
//     //     material.color = State1;
//     //     source.Play();

//     //     StartCoroutine(Coroutine());
//     //     if (other.gameObject.name == "Target")
//     //     {
//     //         Destroy(other.gameObject);
//     //     }
   
//     // }

//     // void OnTriggerExit(Collider other) 
//     // {
//     //     StopAllCoroutines();   
//     // }
