using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTriggerZone : MonoBehaviour
{
    public Animator bridgeAnimator;  

    private void OnTriggerEnter(Collider theGameObjectWeCollidedWith)
    {
        if(theGameObjectWeCollidedWith.tag == "Player") 
        {
            bridgeAnimator.SetTrigger("Raise");
        }
    }
}
