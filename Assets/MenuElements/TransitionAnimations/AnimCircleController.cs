using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVisibilityDuringAnimation : MonoBehaviour
{
    private Animator animator;
    private GameObject myObject;

    private void Start()
    {
        // Assuming the animator is attached to the same GameObject
        animator = GetComponent<Animator>();

        // Replace "YourObjectName" with the actual name of your object
        myObject = transform.Find("Circle").gameObject;

        // Ensure the object is initially invisible
        myObject.SetActive(false);
    }

    private void Update()
    {
        // Check if the animation is playing
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
        {
            // Set the object visible during the animation
            myObject.SetActive(true);
        }
        else
        {
            // Set the object invisible when the animation is not playing
            myObject.SetActive(false);
        }
    }
}

