using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randowsounds : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] shoot;
    private AudioClip shootclip;

    public AudioClip[] reload;
    private AudioClip reloadclip;

    public AudioClip[] jumpt;
    private AudioClip jumpclip;


    public AudioClip[] death;
    private AudioClip deathclip;

    public AudioClip[] damage;
    private AudioClip damageclip;

    public AudioClip[] footsteps;
    private AudioClip footstepclip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
 

    public void shootsound()
    {
        int index = Random.Range(0, shoot.Length);
        shootclip = shoot[index];

        audioSource.clip = shootclip;
        audioSource.Play();
    }
    public void reloadsound()
    {
        int index = Random.Range(0, reload.Length);
       reloadclip = reload[index];

        audioSource.clip = reloadclip;
        audioSource.Play();
    }
    public void damagesound()
    {
        int index = Random.Range(0, damage.Length);
       damageclip = damage[index];

        audioSource.clip = damageclip;
        audioSource.Play();
    }
    public void deathsound()
    {
        int index = Random.Range(0, death.Length);
      deathclip = death[index];

        audioSource.clip = deathclip;
        audioSource.Play();
    }
    public void footstepsound()
    {
        int index = Random.Range(0, footsteps.Length);
       footstepclip = footsteps[index];

        audioSource.clip = footstepclip;
        audioSource.Play();
    }
    public void jumpsound()
    {
        int index = Random.Range(0, jumpt.Length);
       jumpclip = jumpt[index];

        audioSource.clip = jumpclip;
        audioSource.Play();
    }
}
