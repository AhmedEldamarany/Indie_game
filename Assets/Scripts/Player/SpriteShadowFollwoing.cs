﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteShadowFollwoing : MonoBehaviour
{
    Vector3 offset;
    [SerializeField] Transform player;
    void Start()
    {
        offset = player.position - transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position - offset;
    }
}