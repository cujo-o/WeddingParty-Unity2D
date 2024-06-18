using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class gunScript : MonoBehaviour
{
    public Transform bulletSpawn;
    public GameObject Bullet;
    public int currentclip, maxclipsize = 10, currentammo, maxammosize = 100;
    public AudioSource fires;
    public TextMeshProUGUI text;

    public randowsounds bridesounds;
    public float firerate = 1f; private float nextfiretime;
    public float attackrate;
    void Start()
    {
      
        updateammotext();
    }
    // Update is called once per frame
    void Update()
    {
        if (nextfiretime < Time.time)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                fire();
                nextfiretime = Time.time + firerate;
               
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            reload();
            updateammotext();
        }
       
    }
    public void fire()
    {
        if (currentclip > 0)
        {
            Instantiate(Bullet, bulletSpawn.transform.position,transform.rotation);
            nextfiretime = Time.time + firerate;
            currentclip--;

            bridesounds.shootsound();
        }
    }
    public void reload()
    {
        bridesounds.reloadsound();

        int reloadamount = maxclipsize - currentclip;
        reloadamount = (currentammo - reloadamount) >= 0 ? reloadamount : currentammo;
        currentclip += reloadamount;
        currentammo -= reloadamount;
       


    }
    public void addammo(int ammoamount)
    {
        currentammo += ammoamount;
        if (currentammo > maxammosize)
        {
            currentammo = maxammosize;
        }




    }
    public void updateammotext()
    {
        text.text = $"{currentclip}/{currentammo}";
       
    }
}