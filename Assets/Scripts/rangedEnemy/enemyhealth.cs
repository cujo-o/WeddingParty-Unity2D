﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public Animator anim;
    public float Health = 100.0f;  //Health of the player. Just for stating sake and easy modification in the editor
    public float CurrentHealth;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = Health;
    }

    void Update()
    {
    }

    //This function is for the player to detect damage
    public void TakeDamage(float damage)
    {
        //  PlayerHit.Play(); //If there's a Hit audio, play it. Else just comment this code out to prevent compile errors
        CurrentHealth -= damage; //Reduces the current health of the player
        anim.SetTrigger("damage");
        if (CurrentHealth <= 0)
        {
            Death();
        }
    }

 
   


    public void Death()
    {
        Death2();
       // anim.SetTrigger("die");
        //If there's a ragdoll enabled for the player, enable it. Else just comment this code out to prevent compile errors
        //   DeathSound.Play(); //If we have a death audio, play it. Else just comment this code out to prevent compile errors.
    }

    public void Death2()
    {
        Destroy(gameObject);
    }
}
