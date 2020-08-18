using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRInput : MonoBehaviour
{
    public bool isLeftHand; //if true,left controller
    public float gripValue;

    private string gripAxis;

    // Start is called before the first frame update
    void Awake()
    {
        if(isleftHand)
        {
            gripAxis = "LeftGrip";
        }
        else
        {
            gripAxis = "RightGrip";
        }
    }

    // Update is called once per frame
    void Update()
    {
        gripValue = Input.GetAxis(gripAxis); 
    }
}
