﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;

    // Update is called once per frame
    void Update()
    {
        // Jump is space key
        if (Input.GetButtonDown("Jump"))
        {
            Shoot();
        }
    }

    void Shoot()
    {

    }
}
