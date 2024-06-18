using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float speed; public bool isFacingRight; private Vector2 moveinput;
    private Transform player; public float shootingrange; public Transform here;
    public float lineofsight; public GameObject bullet; public GameObject bulletparent;
    public float firerate = 1f; private float nextfiretime; public Animator Anim;
	

	
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        float distancefromplayer = Vector2.Distance(player.position, transform.position);
        if (distancefromplayer < lineofsight && distancefromplayer > shootingrange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
        else if (distancefromplayer <= shootingrange && nextfiretime < Time.time)

        {
          //  Anim.SetTrigger("fire");
            nextfiretime = Time.time + firerate;
            fire(); }


        flip();

    }
    public void flip()
    {
       // Vector3 Scale = transform.localScale;
        if (player.transform.position.x > transform.position.x)
        {
            // Scale.x = Mathf.Abs(Scale.x);
          //  transform.Rotate(0, 0, 0);
        }
       else
        {
          //  transform.Rotate(0, 0, 0);
          //  transform.Rotate(0, 0, 0);

            // Scale.x = Mathf.Abs(Scale.x) * -1;
        }
        //transform.localScale = Scale;

    }
    public void fire()
    {
        Instantiate(bullet, bulletparent.transform.position, bulletparent.transform.rotation);


    }
   
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(here.position, lineofsight);
        Gizmos.DrawWireSphere(here.position, shootingrange);
    }
}
