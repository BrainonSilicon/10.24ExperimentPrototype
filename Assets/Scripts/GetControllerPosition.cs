using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.InteractionSubsystems;

public class GetControllerPosition : MonoBehaviour
{
    // public GameObject Head; // this might break it as we no longer need Head to be manually called
    public Rigidbody LeftHand, RightHand;

    // can maybe make these public so the interaction manager could grab them?
    private List<XRNodeState> mNodeStates = new List<XRNodeState>();
    private Vector3 mHeadPos, mLeftHandPos, mRightHandPos;
    private Quaternion mHeadRot, mLeftHandRot, mRightHandRot;

    private void Start()
    {
        List<XRInputSubsystem> subsystems = new List<XRInputSubsystem>();
        SubsystemManager.GetInstances<XRInputSubsystem>(subsystems);
        for (int i = 0; i < subsystems.Count; i++)
        {
            subsystems[i].TrySetTrackingOriginMode(TrackingOriginModeFlags.Floor);
        }
    }

    // private void Update()
    // {
    //     InputTracking.GetNodeStates(mNodeStates);

    //     foreach (XRNodeState nodeState in mNodeStates)
    //     {
    //         switch (nodeState.nodeType)
    //         {
    //             case XRNode.Head:
    //                 nodeState.TryGetPosition(out mHeadPos);
    //                 nodeState.TryGetRotation(out mHeadRot);
    //                 break;
    //         }
    //     }
    //     Head.transform.position = mHeadPos;
    //     Head.transform.rotation = mHeadRot.normalized;
    // }

    // this tracks the rigid body attached to the hands 
    private void FixedUpdate() // using FixedUpdate might cause jitter - need to test
    {
        InputTracking.GetNodeStates(mNodeStates);

        foreach (XRNodeState nodeState in mNodeStates)
        {
            switch (nodeState.nodeType)
            {
                case XRNode.LeftHand:
                    nodeState.TryGetPosition(out mLeftHandPos);
                    nodeState.TryGetRotation(out mLeftHandRot);
                    break;
                case XRNode.RightHand:
                    nodeState.TryGetPosition(out mRightHandPos);
                    nodeState.TryGetRotation(out mRightHandRot);
                    break;
            }
        }

        LeftHand.MovePosition(mLeftHandPos);
        LeftHand.MoveRotation(mLeftHandRot.normalized); // use normalized so it's set to standard space
        RightHand.MovePosition(mRightHandPos);
        RightHand.MoveRotation(mRightHandRot.normalized); // use normalized so it's set to standard space
    }




    // private XRNode XRController = XRNode.LeftHand;

    // private List<InputDevice> devices = new List<InputDevice>();
    // private InputDevice device;
    
    // public Vector3 position;

    // // leftHandController = newList<UnityEngine.XR.InputDevice>();

    // void GetDevice()
    // {
    //     InputDevice.GetDevicesAtXRNode(XRController, devices);
    // }



    // void OnEnable()
    // {
    //     if (!device.isValid)
    //     {
    //         GetDevice();
    //     }
    // }



    // public static void GetNodeStates(List<XRNodeState>nodeStates);
    
}
