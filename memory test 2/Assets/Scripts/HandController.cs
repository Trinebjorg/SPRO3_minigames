using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]
public class HandController : MonoBehaviour
{
    ActionBasedController controller;
    
    public Hand1 hand;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<ActionBasedController>(); // Get the controller
    }

    // Update is called once per frame
    void Update() // Get Trigger and Grip input
    {
        hand.SetGrip(controller.selectAction.action.ReadValue<float>());
        hand.SetTrigger(controller.activateAction.action.ReadValue<float>());
    }
}
