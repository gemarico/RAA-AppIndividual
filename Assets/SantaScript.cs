using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaScript : MonoBehaviour {

    public GameObject Santa;
    public AudioClip aud0;
    public AudioClip aud1;
    public AudioClip aud2;

    private Animator animator;

    void Start()
    {
        animator = Santa.GetComponent<Animator> ();
       
    }

   

    public void Canta()
    {
        animator.SetTrigger("canta");
        animator.gameObject.GetComponent<AudioSource>().clip = aud1;
        animator.gameObject.GetComponent<AudioSource>().Play();
    }

    public void Baila()
    {
        animator.SetTrigger("baila");
        animator.gameObject.GetComponent<AudioSource>().clip = aud2;
        animator.gameObject.GetComponent<AudioSource>().Play();
    }

}
