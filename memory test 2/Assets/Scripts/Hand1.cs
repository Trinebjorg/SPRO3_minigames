using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hand1 : MonoBehaviour
{
    public float Speed;

    Animator animator;
    SkinnedMeshRenderer mesh;
    private float gripTarget;
    private float triggerTarget;
    private float gripCurrent;
    private float triggerCurrent;
  
    private String animatorGripParam = "Grip";
    private String animatorTriggerParam = "Trigger";


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        mesh = GetComponentInChildren<SkinnedMeshRenderer>(); // Mesh around objects
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand(); // call every frame
    }

    internal void SetGrip(float v)
    {
        gripTarget = v;
    }

    internal void SetTrigger(float v)
    {
        triggerTarget = v;
    }

    void AnimateHand()
    {
        if (gripCurrent != gripTarget) //Check if grip button is pressed
        {
            gripCurrent = Mathf.MoveTowards(gripCurrent, gripTarget, Time.deltaTime * Speed);
            animator.SetFloat(animatorGripParam, gripCurrent);
        }
        
        if (triggerCurrent != triggerTarget) // Same here
        {
            triggerCurrent = Mathf.MoveTowards(triggerCurrent, triggerTarget, Time.deltaTime * Speed);
            animator.SetFloat(animatorTriggerParam, triggerCurrent);
        }
    }

    public void ToggleVisibility()
    {
        mesh.enabled = !mesh.enabled; // Takes value inside mesh.en -> flips it around -> sets it
    }
}
