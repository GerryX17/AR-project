﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetBehaviour : MonoBehaviour
{
    public int speed = 15;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Rotation on y axis
        // be sure to capitalize Rotate or you'll get errors
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
