﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeTriggerZone : MonoBehaviour
{
    public Animator bridgeAnimator;

    private void OnTriggerEnter(Collider theGameObjectWeCollidedWith)
    {
        bridgeAnimator.SetTrigger("Raise");
    }
}
