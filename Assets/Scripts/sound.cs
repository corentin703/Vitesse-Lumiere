﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    [SerializeField] AudioSource music;
    [SerializeField] Rigidbody player;
    float playerSpeed;

    void Update()
    {
        playerSpeed = System.Math.Abs(player.velocity.x) + System.Math.Abs(player.velocity.z);
        music.volume = 1 - playerSpeed / 1000;
    }
}
