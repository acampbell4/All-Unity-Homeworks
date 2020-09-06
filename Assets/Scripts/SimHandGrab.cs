using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandGrab : MonoBehaviour
{
    public GameObject collidingObject; //what we're touching 
    public GameObject heldObject;       //what we're holding

    private void onTriggerEnter(Collider otherThingWeTouched)
    {
        collidingObject = otherThingWeTouched.gameObject;  //saving what we are touching 
    }
    private void onTriggerExit(Collider other)
    {
        if (other.gameObject == collidingObject) //checking that you have exited the colliding object and not some other one
        {
            collidingObject = null;             //we are no longer touching an object
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (collidingObject)  //shorthand for colliding object == true 
            {
                heldObject = collidingObject;  //do the grab

                Grab();
            }
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            if (heldObject)
            {
                Release();
            }
        }
    }
    private void Grab()
    {
        heldObject.transform.SetParent(this.transform);
        heldObject.GetComponent<Rigidbody>().isKinematic = true;
    }

    private void Release()
    {
        heldObject.transform.SetParent(null);
        heldObject.GetComponent<Rigidbody>().isKinematic = false;
        heldObject = null;

    }
}