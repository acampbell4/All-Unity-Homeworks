using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRHandAnimator : MonoBehaviour
{
    private VRInput controller;
    private Animator handAnimator;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<VRInput>();
        handAnimator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller && handAnimator)
        {
            handAnimator.Play( "Fist Closing", 0, controller.gripValue);
        }
    }
}
