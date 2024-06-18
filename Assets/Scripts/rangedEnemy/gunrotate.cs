using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunrotate : MonoBehaviour
{
    private Transform player;   public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
    }

    // Update is called once per frame
    void Update()
    {
     
       
        
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            enemy.transform.Rotate(0, 180, 0);
        }
    }
}
