using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnLose : MonoBehaviour
{
    public bridehealth bridehealth;
    public GameObject winpanel;
    public GameObject losepanel;
    // Start is called before the first frame update
    void Start()
    {
        bridehealth = GetComponent<bridehealth>();
     
    }

    // Update is called once per frame
    void Update()
    {
        if (bridehealth.CurrentHealth<=0)
        {
           losepanel.SetActive(true);
        }

        GameObject[] enemynumber = GameObject.FindGameObjectsWithTag("enemy");


        int enumb = enemynumber.Length;
      
        if (enumb <= 0)
        {
            winpanel.SetActive(true);
        }
    }
}

