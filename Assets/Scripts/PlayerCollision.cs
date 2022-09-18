using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameManager gameManager;
    private PlayerMovement movement;

    private void Start()
    {
        gameManager = GetComponent<GameManager>();
        movement = GetComponent<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag=="Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
