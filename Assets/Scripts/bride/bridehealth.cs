using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bridehealth : MonoBehaviour
{
    public Animator anim;
    public Slider PlayerHealthBar;
    public float Health = 100.0f;  //Health of the player. Just for stating sake and easy modification in the editor
    public float CurrentHealth; // Start is called before the first frame update
    public randowsounds bridesounds;
    void Start()
    {
        //If you want to use a health bar, utilize this code, else just comment it out
        CurrentHealth = Health;
        PlayerHealthBar.value = CurrentHealth;
        bridesounds = GetComponent<randowsounds>();
        //Use these codes below if the Player has all its colliders on the gameobject the script is attached on(It wont be important because you will definitely have other colliders on e.g, the hands, legs, spine, head,etc when you enable ragdoll on the character. Just drag and drop the colliders and rigidbodies into the field in the editor)

    }
   
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemybullet"))
        {
            TakeDamage(10f);
            Destroy(collision.gameObject);
        }
    }

    //This function is for the player to detect damage
    public void TakeDamage(float damage)
    {
        bridesounds.damagesound(); //If there's a Hit audio, play it. Else just comment this code out to prevent compile errors
        CurrentHealth -= damage; //Reduces the current health of the player
        anim.SetTrigger("damage");
        PlayerHealthBar.value = CurrentHealth; //Sets the playerhealth bar to be the same value with the current health
        if (CurrentHealth <= 0)
        {
            Death2();
        }
    }




    //As the name implies, It handles the player's death, heck, it kills the player😢
    public void Death()
    {
        anim.SetTrigger("die");
        //If there's a ragdoll enabled for the player, enable it. Else just comment this code out to prevent compile errors
        //   DeathSound.Play(); //If we have a death audio, play it. Else just comment this code out to prevent compile errors.
    }

    public void Death2()
    {
        bridesounds.deathsound();
        Destroy(gameObject);
    }
}
