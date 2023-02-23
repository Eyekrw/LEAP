using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioControl : MonoBehaviour
{
    public AudioSource click;
    void Start()
    {
        click = gameObject.AddComponent<AudioSource>();
        click.mute = false;
        click.loop = false;
        click.playOnAwake = false;
    }
    public void clickSound()
    {
        click.Play();
    }
}
