using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponswitching : MonoBehaviour
{
    public GameObject knifeui; public GameObject revolver;
    public GameObject revolverui;  // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))//knife
        {
            knifeui.SetActive(true);
            revolverui.SetActive(false);
            revolver.SetActive(false);

        } 
        if (Input.GetKeyDown(KeyCode.Alpha2))//revolver
        {

            knifeui.SetActive(false);
            revolverui.SetActive(true);
            revolver.SetActive(true);
        }
    }
}
