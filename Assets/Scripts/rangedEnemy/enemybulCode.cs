using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybulCode : MonoBehaviour
{
    public float bLife;
    public Rigidbody2D rb;
    public float speed;

    void Update()
    {
        rb.velocity = transform.right * speed;
    }
    void Awake()
    {
        Destroy(gameObject, bLife);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
           collision.gameObject.GetComponent<bridehealth>().TakeDamage(5f);
            Destroy(gameObject);
        }
       
    }
}
