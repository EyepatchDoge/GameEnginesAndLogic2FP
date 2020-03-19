﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaulPlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anime;
    public LayerMask groundDec;
    public float gDradious, flyVel;
    public Transform gDeteque;
    public bool playerIsDed;

    // Start is called before the first frame update
    void Start()
    {
        playerIsDed = false;
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D isGrounded = Physics2D.OverlapCircle(gDeteque.position, gDradious, groundDec);
        anime.SetBool("Grounded", isGrounded);
        if (Input.touchCount > 0)
        {
            Touch myTouch = Input.GetTouch(0);
            Ray ray = Camera.main.ScreenPointToRay(myTouch.position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // moves the player up when pressing the screen
                rb.velocity = Vector2.up * flyVel;
                anime.SetBool("Flying", true);
            }
            else
            {
                anime.SetBool("Flying", false);
            }

        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector2.up * flyVel;
            anime.SetBool("Flying", true);
            //rb.gravityScale *= -1;
        }
        else
        {
            anime.SetBool("Flying", false);
        }
        
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(gDeteque.position, gDradious);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            PlayerDead();
        }
    }

    public void PlayerDead()
    {
        anime.SetTrigger("Ded");
        playerIsDed = true;
    }

    public void BackToPlay()
    {
        anime.SetTrigger("Replay");
    }
}