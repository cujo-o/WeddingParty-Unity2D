using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rtscript : MonoBehaviour
{
    // Start is called before the first frame update
    public float Horizontal;
   // public GameObject sprite;
    public bool isFacingRight;  

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Flip();
    }
    void Flip()
    {
        if (isFacingRight && Horizontal < 0f || !isFacingRight && Horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
           

          transform.Rotate(0, 180, 0);
        }
    }
}
