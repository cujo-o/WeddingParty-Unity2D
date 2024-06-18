using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcode : MonoBehaviour
{
    public float bLife;
    public Rigidbody2D rb;
    public float speed;

    void Update()
    {
        rb.velocity = transform.right * speed;
    }
   
  
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            collision.gameObject.GetComponent<enemyhealth>().TakeDamage(40f);
            Destroy(gameObject);
        }
    }
}
