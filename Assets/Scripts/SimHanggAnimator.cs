using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHanggAnimator : MonoBehaviour
{
    private Animator simHandAnim;

    void Start()
    {
        simHandAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            simHandAnim.SetBool("IsClosing", true);  //closing the fist 
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            simHandAnim.SetBool("IsClosing", false); //opening fist
        }
    }
}
