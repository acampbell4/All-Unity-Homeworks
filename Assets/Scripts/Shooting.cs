﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject pelletPrefab;
    public Transform spawnPoint;
    public float shootingForce;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            //do the shooting

        }
    }
}
